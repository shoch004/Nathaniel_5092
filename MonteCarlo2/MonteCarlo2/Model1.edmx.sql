
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2021 15:45:13
-- Generated from EDMX file: C:\Users\Nate\Documents\Nathaniel_repo\MonteCarlo2\MonteCarlo2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TradeTool];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Options'
CREATE TABLE [dbo].[Options] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [isCall] varbinary(max)  NULL,
    [Strike] float  NOT NULL,
    [StockID] int  NOT NULL,
    [Expiration] float  NOT NULL,
    [Rebate] float  NULL,
    [Barrier] float  NULL,
    [TBillId] int  NOT NULL,
    [Stock_Id] int  NOT NULL
);
GO

-- Creating table 'Stocks'
CREATE TABLE [dbo].[Stocks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ticker] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Exchange] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StockPrices'
CREATE TABLE [dbo].[StockPrices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClosePrice] float  NOT NULL,
    [StockID] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Stock_Id] int  NOT NULL
);
GO

-- Creating table 'TBills'
CREATE TABLE [dbo].[TBills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tenor] float  NOT NULL,
    [Rate] float  NOT NULL
);
GO

-- Creating table 'Trades'
CREATE TABLE [dbo].[Trades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [InstrumentType] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [Option_Id] int  NOT NULL,
    [Stock_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [PK_Options]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Stocks'
ALTER TABLE [dbo].[Stocks]
ADD CONSTRAINT [PK_Stocks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StockPrices'
ALTER TABLE [dbo].[StockPrices]
ADD CONSTRAINT [PK_StockPrices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TBills'
ALTER TABLE [dbo].[TBills]
ADD CONSTRAINT [PK_TBills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trades'
ALTER TABLE [dbo].[Trades]
ADD CONSTRAINT [PK_Trades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Stock_Id] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [FK_OptionsStocks]
    FOREIGN KEY ([Stock_Id])
    REFERENCES [dbo].[Stocks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OptionsStocks'
CREATE INDEX [IX_FK_OptionsStocks]
ON [dbo].[Options]
    ([Stock_Id]);
GO

-- Creating foreign key on [Stock_Id] in table 'StockPrices'
ALTER TABLE [dbo].[StockPrices]
ADD CONSTRAINT [FK_StockPricesStocks]
    FOREIGN KEY ([Stock_Id])
    REFERENCES [dbo].[Stocks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockPricesStocks'
CREATE INDEX [IX_FK_StockPricesStocks]
ON [dbo].[StockPrices]
    ([Stock_Id]);
GO

-- Creating foreign key on [TBillId] in table 'Options'
ALTER TABLE [dbo].[Options]
ADD CONSTRAINT [FK_TBillOptions]
    FOREIGN KEY ([TBillId])
    REFERENCES [dbo].[TBills]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBillOptions'
CREATE INDEX [IX_FK_TBillOptions]
ON [dbo].[Options]
    ([TBillId]);
GO

-- Creating foreign key on [Option_Id] in table 'Trades'
ALTER TABLE [dbo].[Trades]
ADD CONSTRAINT [FK_TradeOptions]
    FOREIGN KEY ([Option_Id])
    REFERENCES [dbo].[Options]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TradeOptions'
CREATE INDEX [IX_FK_TradeOptions]
ON [dbo].[Trades]
    ([Option_Id]);
GO

-- Creating foreign key on [Stock_Id] in table 'Trades'
ALTER TABLE [dbo].[Trades]
ADD CONSTRAINT [FK_TradeStocks]
    FOREIGN KEY ([Stock_Id])
    REFERENCES [dbo].[Stocks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TradeStocks'
CREATE INDEX [IX_FK_TradeStocks]
ON [dbo].[Trades]
    ([Stock_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------