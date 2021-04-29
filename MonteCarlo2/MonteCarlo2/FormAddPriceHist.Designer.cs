
namespace MonteCarlo2
{
    partial class FormAddPriceHist
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
            this.txt_ClosePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StockPrice = new System.Windows.Forms.Button();
            this.drop_stockPrice = new System.Windows.Forms.ComboBox();
            this.tradeToolDataSet1 = new MonteCarlo2.TradeToolDataSet1();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new MonteCarlo2.TradeToolDataSet1TableAdapters.StocksTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_ClosePrice = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tradeToolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ClosePrice
            // 
            this.txt_ClosePrice.Location = new System.Drawing.Point(71, 45);
            this.txt_ClosePrice.Name = "txt_ClosePrice";
            this.txt_ClosePrice.Size = new System.Drawing.Size(100, 20);
            this.txt_ClosePrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock";
            // 
            // btn_StockPrice
            // 
            this.btn_StockPrice.Location = new System.Drawing.Point(27, 144);
            this.btn_StockPrice.Name = "btn_StockPrice";
            this.btn_StockPrice.Size = new System.Drawing.Size(144, 28);
            this.btn_StockPrice.TabIndex = 2;
            this.btn_StockPrice.Text = "Add Price";
            this.btn_StockPrice.UseVisualStyleBackColor = true;
            this.btn_StockPrice.Click += new System.EventHandler(this.btn_StockPrice_Click);
            // 
            // drop_stockPrice
            // 
            this.drop_stockPrice.DataSource = this.stocksBindingSource;
            this.drop_stockPrice.DisplayMember = "Name";
            this.drop_stockPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_stockPrice.FormattingEnabled = true;
            this.drop_stockPrice.Location = new System.Drawing.Point(71, 6);
            this.drop_stockPrice.Name = "drop_stockPrice";
            this.drop_stockPrice.Size = new System.Drawing.Size(121, 21);
            this.drop_stockPrice.TabIndex = 3;
            this.drop_stockPrice.ValueMember = "Ticker";
            // 
            // tradeToolDataSet1
            // 
            this.tradeToolDataSet1.DataSetName = "TradeToolDataSet1";
            this.tradeToolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.tradeToolDataSet1;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Close Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            
            // 
            // date_ClosePrice
            // 
            this.date_ClosePrice.Location = new System.Drawing.Point(12, 95);
            this.date_ClosePrice.Name = "date_ClosePrice";
            this.date_ClosePrice.Size = new System.Drawing.Size(212, 20);
            this.date_ClosePrice.TabIndex = 9;
            this.date_ClosePrice.Value = new System.DateTime(2021, 4, 28, 15, 50, 9, 0);
            // 
            // FormAddPriceHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 198);
            this.Controls.Add(this.date_ClosePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drop_stockPrice);
            this.Controls.Add(this.btn_StockPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ClosePrice);
            this.Name = "FormAddPriceHist";
            this.Text = "FormAddPriceHist";
            this.Load += new System.EventHandler(this.FormAddPriceHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tradeToolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ClosePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_StockPrice;
        private System.Windows.Forms.ComboBox drop_stockPrice;
        private TradeToolDataSet1 tradeToolDataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private TradeToolDataSet1TableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_ClosePrice;
    }
}