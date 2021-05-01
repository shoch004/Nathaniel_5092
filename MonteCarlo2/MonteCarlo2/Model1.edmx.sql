
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2021 13:39:04
-- Generated from EDMX file: C:\Users\Nate\Documents\Nathaniel_repo\MonteCarlo2\MonteCarlo2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbTrade];
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
    [CallPut] nvarchar(max)  NULL,
    [Underlying] nvarchar(max)  NOT NULL,
    [Tenor] float  NOT NULL,
    [Rebate] float  NULL,
    [Barrier] float  NULL,
    [Strike] float  NOT NULL
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

-- Creating table 'TBills'
CREATE TABLE [dbo].[TBills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tenor] float  NOT NULL,
    [Rate] float  NOT NULL
);
GO

-- Creating table 'StockPrices'
CREATE TABLE [dbo].[StockPrices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClosePrice] float  NOT NULL,
    [StockID] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Trades'
CREATE TABLE [dbo].[Trades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantity] float  NOT NULL,
    [TradePrice] float  NOT NULL,
    [MarketPrice] float  NULL,
    [Timestamp] datetime  NOT NULL,
    [InstrumentType] nvarchar(max)  NOT NULL,
    [Instrument] nvarchar(max)  NOT NULL,
    [Delta] float  NULL,
    [PL] float  NULL
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

-- Creating primary key on [Id] in table 'TBills'
ALTER TABLE [dbo].[TBills]
ADD CONSTRAINT [PK_TBills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StockPrices'
ALTER TABLE [dbo].[StockPrices]
ADD CONSTRAINT [PK_StockPrices]
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------