
namespace MonteCarlo2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolLabel = new System.Windows.Forms.Label();
            this.txtVolatility = new System.Windows.Forms.TextBox();
            this.dataTotals = new System.Windows.Forms.DataGridView();
            this.profitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gammaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thetaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rhoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.do_stuff = new System.Windows.Forms.Button();
            this.dataInstruments = new System.Windows.Forms.DataGridView();
            this.tradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeToolDataSet = new MonteCarlo2.TradeToolDataSet();
            this.tradesTableAdapter = new MonteCarlo2.TradeToolDataSetTableAdapters.TradesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.underlyingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonteCarloPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalStockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstruments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeToolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tradeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.historicalStockPriceToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // VolLabel
            // 
            this.VolLabel.AutoSize = true;
            this.VolLabel.Location = new System.Drawing.Point(12, 33);
            this.VolLabel.Name = "VolLabel";
            this.VolLabel.Size = new System.Drawing.Size(97, 13);
            this.VolLabel.TabIndex = 1;
            this.VolLabel.Text = "Pricing Volatility (%)";
            // 
            // txtVolatility
            // 
            this.txtVolatility.Location = new System.Drawing.Point(115, 30);
            this.txtVolatility.Name = "txtVolatility";
            this.txtVolatility.Size = new System.Drawing.Size(100, 20);
            this.txtVolatility.TabIndex = 2;
            // 
            // dataTotals
            // 
            this.dataTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profitCol,
            this.DeltaCol,
            this.gammaCol,
            this.vegaCol,
            this.thetaCol,
            this.rhoCol});
            this.dataTotals.Location = new System.Drawing.Point(15, 81);
            this.dataTotals.Name = "dataTotals";
            this.dataTotals.Size = new System.Drawing.Size(658, 111);
            this.dataTotals.TabIndex = 3;
            // 
            // profitCol
            // 
            this.profitCol.HeaderText = "Total P/L";
            this.profitCol.Name = "profitCol";
            this.profitCol.ReadOnly = true;
            // 
            // DeltaCol
            // 
            this.DeltaCol.HeaderText = "Total Delta";
            this.DeltaCol.Name = "DeltaCol";
            this.DeltaCol.ReadOnly = true;
            // 
            // gammaCol
            // 
            this.gammaCol.HeaderText = "Total Gamma";
            this.gammaCol.Name = "gammaCol";
            this.gammaCol.ReadOnly = true;
            // 
            // vegaCol
            // 
            this.vegaCol.HeaderText = "Total Vega";
            this.vegaCol.Name = "vegaCol";
            this.vegaCol.ReadOnly = true;
            // 
            // thetaCol
            // 
            this.thetaCol.HeaderText = "Total Theta";
            this.thetaCol.Name = "thetaCol";
            this.thetaCol.ReadOnly = true;
            // 
            // rhoCol
            // 
            this.rhoCol.HeaderText = "Total Rho";
            this.rhoCol.Name = "rhoCol";
            this.rhoCol.ReadOnly = true;
            // 
            // do_stuff
            // 
            this.do_stuff.Location = new System.Drawing.Point(15, 210);
            this.do_stuff.Name = "do_stuff";
            this.do_stuff.Size = new System.Drawing.Size(75, 23);
            this.do_stuff.TabIndex = 4;
            this.do_stuff.Text = "go";
            this.do_stuff.UseVisualStyleBackColor = true;
            this.do_stuff.Click += new System.EventHandler(this.add_instrument);
            // 
            // dataInstruments
            // 
            this.dataInstruments.AutoGenerateColumns = false;
            this.dataInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstruments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.instrumentTypeDataGridViewTextBoxColumn,
            this.underlyingCol,
            this.priceDataGridViewTextBoxColumn,
            this.MonteCarloPrice,
            this.timestampDataGridViewTextBoxColumn});
            this.dataInstruments.DataSource = this.tradesBindingSource;
            this.dataInstruments.Location = new System.Drawing.Point(12, 239);
            this.dataInstruments.Name = "dataInstruments";
            this.dataInstruments.Size = new System.Drawing.Size(661, 150);
            this.dataInstruments.TabIndex = 5;
            // 
            // tradesBindingSource
            // 
            this.tradesBindingSource.DataMember = "Trades";
            this.tradesBindingSource.DataSource = this.tradeToolDataSet;
            // 
            // tradeToolDataSet
            // 
            this.tradeToolDataSet.DataSetName = "TradeToolDataSet";
            this.tradeToolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradesTableAdapter
            // 
            this.tradesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // instrumentTypeDataGridViewTextBoxColumn
            // 
            this.instrumentTypeDataGridViewTextBoxColumn.DataPropertyName = "InstrumentType";
            this.instrumentTypeDataGridViewTextBoxColumn.HeaderText = "InstrumentType";
            this.instrumentTypeDataGridViewTextBoxColumn.Name = "instrumentTypeDataGridViewTextBoxColumn";
            // 
            // underlyingCol
            // 
            this.underlyingCol.HeaderText = "Stock Ticker";
            this.underlyingCol.Name = "underlyingCol";
            this.underlyingCol.ReadOnly = true;
            this.underlyingCol.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // MonteCarloPrice
            // 
            this.MonteCarloPrice.HeaderText = "Market Price";
            this.MonteCarloPrice.Name = "MonteCarloPrice";
            this.MonteCarloPrice.ReadOnly = true;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // historicalStockPriceToolStripMenuItem
            // 
            this.historicalStockPriceToolStripMenuItem.Name = "historicalStockPriceToolStripMenuItem";
            this.historicalStockPriceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.historicalStockPriceToolStripMenuItem.Text = "Historical Stock Price";
            this.historicalStockPriceToolStripMenuItem.Click += new System.EventHandler(this.historicalStockPriceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocksToolStripMenuItem,
            this.historicalPricesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            // 
            // historicalPricesToolStripMenuItem
            // 
            this.historicalPricesToolStripMenuItem.Name = "historicalPricesToolStripMenuItem";
            this.historicalPricesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historicalPricesToolStripMenuItem.Text = "Historical Prices";
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 452);
            this.Controls.Add(this.dataInstruments);
            this.Controls.Add(this.do_stuff);
            this.Controls.Add(this.dataTotals);
            this.Controls.Add(this.txtVolatility);
            this.Controls.Add(this.VolLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstruments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeToolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label VolLabel;
        private System.Windows.Forms.TextBox txtVolatility;
        private System.Windows.Forms.DataGridView dataTotals;
        private System.Windows.Forms.Button do_stuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gammaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn thetaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rhoCol;
        private System.Windows.Forms.DataGridView dataInstruments;
        private TradeToolDataSet tradeToolDataSet;
        private System.Windows.Forms.BindingSource tradesBindingSource;
        private TradeToolDataSetTableAdapters.TradesTableAdapter tradesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn underlyingCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonteCarloPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem historicalStockPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalPricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
    }


    public class myData
    {
        public double value1 { get; set; }
        public double value2 { get; set; }
        public double value3 { get; set; }
        public double value4 { get; set; }
        public double value5 { get; set; }
        public double value6 { get; set; }
    }
   
}