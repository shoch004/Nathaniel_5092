
namespace MonteCarlo2
{
    partial class FormTrade
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
            this.btn_tradeStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.radio_buy = new System.Windows.Forms.RadioButton();
            this.drop_TradeStock = new System.Windows.Forms.ComboBox();
            this.dbTradeDataSet1 = new MonteCarlo2.DbTradeDataSet1();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.optionsTableAdapter = new MonteCarlo2.DbTradeDataSet1TableAdapters.OptionsTableAdapter();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new MonteCarlo2.DbTradeDataSet1TableAdapters.StocksTableAdapter();
            this.radio_sell = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tradeStock
            // 
            this.btn_tradeStock.Location = new System.Drawing.Point(15, 163);
            this.btn_tradeStock.Name = "btn_tradeStock";
            this.btn_tradeStock.Size = new System.Drawing.Size(184, 31);
            this.btn_tradeStock.TabIndex = 0;
            this.btn_tradeStock.Text = "Buy/Sell";
            this.btn_tradeStock.UseVisualStyleBackColor = true;
            this.btn_tradeStock.Click += new System.EventHandler(this.btn_tradeStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(78, 86);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 2;
            // 
            // radio_buy
            // 
            this.radio_buy.AutoSize = true;
            this.radio_buy.Location = new System.Drawing.Point(15, 12);
            this.radio_buy.Name = "radio_buy";
            this.radio_buy.Size = new System.Drawing.Size(43, 17);
            this.radio_buy.TabIndex = 3;
            this.radio_buy.TabStop = true;
            this.radio_buy.Text = "Buy";
            this.radio_buy.UseVisualStyleBackColor = true;
            // 
            // drop_TradeStock
            // 
            this.drop_TradeStock.DataSource = this.stocksBindingSource;
            this.drop_TradeStock.DisplayMember = "Name";
            this.drop_TradeStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_TradeStock.FormattingEnabled = true;
            this.drop_TradeStock.Location = new System.Drawing.Point(78, 46);
            this.drop_TradeStock.Name = "drop_TradeStock";
            this.drop_TradeStock.Size = new System.Drawing.Size(121, 21);
            this.drop_TradeStock.TabIndex = 4;
            this.drop_TradeStock.ValueMember = "Ticker";
            // 
            // dbTradeDataSet1
            // 
            this.dbTradeDataSet1.DataSetName = "DbTradeDataSet1";
            this.dbTradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.dbTradeDataSet1;
            // 
            // optionsTableAdapter
            // 
            this.optionsTableAdapter.ClearBeforeFill = true;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.dbTradeDataSet1;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // radio_sell
            // 
            this.radio_sell.AutoSize = true;
            this.radio_sell.Location = new System.Drawing.Point(78, 12);
            this.radio_sell.Name = "radio_sell";
            this.radio_sell.Size = new System.Drawing.Size(42, 17);
            this.radio_sell.TabIndex = 5;
            this.radio_sell.TabStop = true;
            this.radio_sell.Text = "Sell";
            this.radio_sell.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(78, 125);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 8;
            // 
            // FormTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 209);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_sell);
            this.Controls.Add(this.drop_TradeStock);
            this.Controls.Add(this.radio_buy);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tradeStock);
            this.Name = "FormTrade";
            this.Text = "FormTrade";
            this.Load += new System.EventHandler(this.FormTrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tradeStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.RadioButton radio_buy;
        private System.Windows.Forms.ComboBox drop_TradeStock;
        private DbTradeDataSet1 dbTradeDataSet1;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private DbTradeDataSet1TableAdapters.OptionsTableAdapter optionsTableAdapter;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private DbTradeDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.RadioButton radio_sell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Quantity;
    }
}