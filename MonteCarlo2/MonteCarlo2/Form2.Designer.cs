
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
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalStockPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTradeDataSet2 = new MonteCarlo2.DbTradeDataSet2();
            this.tradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradesTableAdapter = new MonteCarlo2.DbTradeDataSet2TableAdapters.TradesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_antithetic = new System.Windows.Forms.CheckBox();
            this.txt_Steps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.check_multithread = new System.Windows.Forms.CheckBox();
            this.check_controlVariate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Paths = new System.Windows.Forms.TextBox();
            this.group_settings = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInstruments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).BeginInit();
            this.group_settings.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
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
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem1,
            this.optionToolStripMenuItem1});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tradeToolStripMenuItem.Text = "Trade";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.tradeToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem1
            // 
            this.stockToolStripMenuItem1.Name = "stockToolStripMenuItem1";
            this.stockToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.stockToolStripMenuItem1.Text = "Stock";
            this.stockToolStripMenuItem1.Click += new System.EventHandler(this.stockToolStripMenuItem1_Click);
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.optionToolStripMenuItem1.Text = "Option";
            this.optionToolStripMenuItem1.Click += new System.EventHandler(this.optionToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.historicalStockPriceToolStripMenuItem,
            this.rateToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
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
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            this.rateToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rateToolStripMenuItem.Text = "Rate";
            this.rateToolStripMenuItem.Click += new System.EventHandler(this.rateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stocksToolStripMenuItem.Text = "Stocks";
            // 
            // historicalPricesToolStripMenuItem
            // 
            this.historicalPricesToolStripMenuItem.Name = "historicalPricesToolStripMenuItem";
            this.historicalPricesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.historicalPricesToolStripMenuItem.Text = "Historical Prices";
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
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            this.dataTotals.AllowUserToAddRows = false;
            this.dataTotals.AllowUserToDeleteRows = false;
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
            this.dataTotals.ReadOnly = true;
            this.dataTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.do_stuff.Location = new System.Drawing.Point(545, 376);
            this.do_stuff.Name = "do_stuff";
            this.do_stuff.Size = new System.Drawing.Size(128, 82);
            this.do_stuff.TabIndex = 4;
            this.do_stuff.Text = "Calculate";
            this.do_stuff.UseVisualStyleBackColor = true;
            this.do_stuff.Click += new System.EventHandler(this.add_instrument);
            // 
            // dataInstruments
            // 
            this.dataInstruments.AllowUserToAddRows = false;
            this.dataInstruments.AllowUserToDeleteRows = false;
            this.dataInstruments.AutoGenerateColumns = false;
            this.dataInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInstruments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.instrumentDataGridViewTextBoxColumn,
            this.tradePriceDataGridViewTextBoxColumn,
            this.marketPriceDataGridViewTextBoxColumn,
            this.pLDataGridViewTextBoxColumn,
            this.deltaDataGridViewTextBoxColumn});
            this.dataInstruments.DataSource = this.tradesBindingSource1;
            this.dataInstruments.Location = new System.Drawing.Point(15, 220);
            this.dataInstruments.Name = "dataInstruments";
            this.dataInstruments.ReadOnly = true;
            this.dataInstruments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataInstruments.Size = new System.Drawing.Size(658, 150);
            this.dataInstruments.TabIndex = 5;
            this.dataInstruments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataInstruments_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Timestamp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Timestamp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InstrumentType";
            this.dataGridViewTextBoxColumn4.HeaderText = "InstrumentType";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // instrumentDataGridViewTextBoxColumn
            // 
            this.instrumentDataGridViewTextBoxColumn.DataPropertyName = "Instrument";
            this.instrumentDataGridViewTextBoxColumn.HeaderText = "Instrument";
            this.instrumentDataGridViewTextBoxColumn.Name = "instrumentDataGridViewTextBoxColumn";
            this.instrumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradePriceDataGridViewTextBoxColumn
            // 
            this.tradePriceDataGridViewTextBoxColumn.DataPropertyName = "TradePrice";
            this.tradePriceDataGridViewTextBoxColumn.HeaderText = "TradePrice";
            this.tradePriceDataGridViewTextBoxColumn.Name = "tradePriceDataGridViewTextBoxColumn";
            this.tradePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marketPriceDataGridViewTextBoxColumn
            // 
            this.marketPriceDataGridViewTextBoxColumn.DataPropertyName = "MarketPrice";
            this.marketPriceDataGridViewTextBoxColumn.HeaderText = "MarketPrice";
            this.marketPriceDataGridViewTextBoxColumn.Name = "marketPriceDataGridViewTextBoxColumn";
            this.marketPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLDataGridViewTextBoxColumn
            // 
            this.pLDataGridViewTextBoxColumn.DataPropertyName = "PL";
            this.pLDataGridViewTextBoxColumn.HeaderText = "PL";
            this.pLDataGridViewTextBoxColumn.Name = "pLDataGridViewTextBoxColumn";
            this.pLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deltaDataGridViewTextBoxColumn
            // 
            this.deltaDataGridViewTextBoxColumn.DataPropertyName = "Delta";
            this.deltaDataGridViewTextBoxColumn.HeaderText = "Delta";
            this.deltaDataGridViewTextBoxColumn.Name = "deltaDataGridViewTextBoxColumn";
            this.deltaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tradesBindingSource1
            // 
            this.tradesBindingSource1.DataMember = "Trades";
            this.tradesBindingSource1.DataSource = this.dbTradeDataSet2;
            // 
            // dbTradeDataSet2
            // 
            this.dbTradeDataSet2.DataSetName = "DbTradeDataSet2";
            this.dbTradeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradesTableAdapter
            // 
            this.tradesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book (Hold CTRL and Click Rows to Select/Unselect)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "P/L and Greeks (Aggregate of Selected Book Positions) ";
            // 
            // check_antithetic
            // 
            this.check_antithetic.AutoSize = true;
            this.check_antithetic.Location = new System.Drawing.Point(301, 25);
            this.check_antithetic.Name = "check_antithetic";
            this.check_antithetic.Size = new System.Drawing.Size(70, 17);
            this.check_antithetic.TabIndex = 8;
            this.check_antithetic.Text = "Antithetic";
            this.check_antithetic.UseVisualStyleBackColor = true;
            // 
            // txt_Steps
            // 
            this.txt_Steps.Location = new System.Drawing.Point(173, 23);
            this.txt_Steps.Name = "txt_Steps";
            this.txt_Steps.Size = new System.Drawing.Size(100, 20);
            this.txt_Steps.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Steps for Monte Carlo";
            // 
            // check_multithread
            // 
            this.check_multithread.AutoSize = true;
            this.check_multithread.Location = new System.Drawing.Point(301, 53);
            this.check_multithread.Name = "check_multithread";
            this.check_multithread.Size = new System.Drawing.Size(92, 17);
            this.check_multithread.TabIndex = 11;
            this.check_multithread.Text = "Multithreading";
            this.check_multithread.UseVisualStyleBackColor = true;
            // 
            // check_controlVariate
            // 
            this.check_controlVariate.AutoSize = true;
            this.check_controlVariate.Location = new System.Drawing.Point(387, 25);
            this.check_controlVariate.Name = "check_controlVariate";
            this.check_controlVariate.Size = new System.Drawing.Size(95, 17);
            this.check_controlVariate.TabIndex = 12;
            this.check_controlVariate.Text = "Control Variate";
            this.check_controlVariate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Paths for Monte Carlo";
            // 
            // txt_Paths
            // 
            this.txt_Paths.Location = new System.Drawing.Point(173, 51);
            this.txt_Paths.Name = "txt_Paths";
            this.txt_Paths.Size = new System.Drawing.Size(100, 20);
            this.txt_Paths.TabIndex = 14;
            // 
            // group_settings
            // 
            this.group_settings.Controls.Add(this.label3);
            this.group_settings.Controls.Add(this.txt_Paths);
            this.group_settings.Controls.Add(this.check_antithetic);
            this.group_settings.Controls.Add(this.label4);
            this.group_settings.Controls.Add(this.txt_Steps);
            this.group_settings.Controls.Add(this.check_controlVariate);
            this.group_settings.Controls.Add(this.check_multithread);
            this.group_settings.Location = new System.Drawing.Point(12, 376);
            this.group_settings.Name = "group_settings";
            this.group_settings.Size = new System.Drawing.Size(527, 87);
            this.group_settings.TabIndex = 15;
            this.group_settings.TabStop = false;
            this.group_settings.Text = "Calculation Settings - Leave Blank for Default Settings";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(598, 194);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Refresh After Adding Instrument or Placing Trade";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.group_settings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradesBindingSource)).EndInit();
            this.group_settings.ResumeLayout(false);
            this.group_settings.PerformLayout();
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
        //private TradeToolDataSet tradeToolDataSet;
        private System.Windows.Forms.BindingSource tradesBindingSource;
        //private TradeToolDataSetTableAdapters.TradesTableAdapter tradesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem historicalStockPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalPricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private DbTradeDataSet2 dbTradeDataSet2;
        private System.Windows.Forms.BindingSource tradesBindingSource1;
        private DbTradeDataSet2TableAdapters.TradesTableAdapter tradesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox check_antithetic;
        private System.Windows.Forms.TextBox txt_Steps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check_multithread;
        private System.Windows.Forms.CheckBox check_controlVariate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Paths;
        private System.Windows.Forms.GroupBox group_settings;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label5;
    }


   
}