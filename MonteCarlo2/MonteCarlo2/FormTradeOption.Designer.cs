
namespace MonteCarlo2
{
    partial class FormTradeOption
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.data_Options = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callPutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.underlyingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTradeDataSet1 = new MonteCarlo2.DbTradeDataSet1();
            this.optionsTableAdapter = new MonteCarlo2.DbTradeDataSet1TableAdapters.OptionsTableAdapter();
            this.btn_TradeOption = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_buy = new System.Windows.Forms.RadioButton();
            this.radio_sell = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Options)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Available Option";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(85, 202);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 3;
            // 
            // data_Options
            // 
            this.data_Options.AllowUserToAddRows = false;
            this.data_Options.AllowUserToDeleteRows = false;
            this.data_Options.AutoGenerateColumns = false;
            this.data_Options.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Options.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.callPutDataGridViewTextBoxColumn,
            this.underlyingDataGridViewTextBoxColumn,
            this.tenorDataGridViewTextBoxColumn,
            this.rebateDataGridViewTextBoxColumn,
            this.barrierDataGridViewTextBoxColumn,
            this.strikeDataGridViewTextBoxColumn});
            this.data_Options.DataSource = this.optionsBindingSource;
            this.data_Options.Location = new System.Drawing.Point(12, 52);
            this.data_Options.Name = "data_Options";
            this.data_Options.ReadOnly = true;
            this.data_Options.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Options.Size = new System.Drawing.Size(748, 93);
            this.data_Options.TabIndex = 4;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // callPutDataGridViewTextBoxColumn
            // 
            this.callPutDataGridViewTextBoxColumn.DataPropertyName = "CallPut";
            this.callPutDataGridViewTextBoxColumn.HeaderText = "CallPut";
            this.callPutDataGridViewTextBoxColumn.Name = "callPutDataGridViewTextBoxColumn";
            this.callPutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // underlyingDataGridViewTextBoxColumn
            // 
            this.underlyingDataGridViewTextBoxColumn.DataPropertyName = "Underlying";
            this.underlyingDataGridViewTextBoxColumn.HeaderText = "Underlying";
            this.underlyingDataGridViewTextBoxColumn.Name = "underlyingDataGridViewTextBoxColumn";
            this.underlyingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenorDataGridViewTextBoxColumn
            // 
            this.tenorDataGridViewTextBoxColumn.DataPropertyName = "Tenor";
            this.tenorDataGridViewTextBoxColumn.HeaderText = "Tenor";
            this.tenorDataGridViewTextBoxColumn.Name = "tenorDataGridViewTextBoxColumn";
            this.tenorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rebateDataGridViewTextBoxColumn
            // 
            this.rebateDataGridViewTextBoxColumn.DataPropertyName = "Rebate";
            this.rebateDataGridViewTextBoxColumn.HeaderText = "Rebate";
            this.rebateDataGridViewTextBoxColumn.Name = "rebateDataGridViewTextBoxColumn";
            this.rebateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barrierDataGridViewTextBoxColumn
            // 
            this.barrierDataGridViewTextBoxColumn.DataPropertyName = "Barrier";
            this.barrierDataGridViewTextBoxColumn.HeaderText = "Barrier";
            this.barrierDataGridViewTextBoxColumn.Name = "barrierDataGridViewTextBoxColumn";
            this.barrierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strikeDataGridViewTextBoxColumn
            // 
            this.strikeDataGridViewTextBoxColumn.DataPropertyName = "Strike";
            this.strikeDataGridViewTextBoxColumn.HeaderText = "Strike";
            this.strikeDataGridViewTextBoxColumn.Name = "strikeDataGridViewTextBoxColumn";
            this.strikeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataMember = "Options";
            this.optionsBindingSource.DataSource = this.dbTradeDataSet1;
            // 
            // dbTradeDataSet1
            // 
            this.dbTradeDataSet1.DataSetName = "DbTradeDataSet1";
            this.dbTradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // optionsTableAdapter
            // 
            this.optionsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_TradeOption
            // 
            this.btn_TradeOption.Location = new System.Drawing.Point(227, 173);
            this.btn_TradeOption.Name = "btn_TradeOption";
            this.btn_TradeOption.Size = new System.Drawing.Size(126, 89);
            this.btn_TradeOption.TabIndex = 5;
            this.btn_TradeOption.Text = "Buy/Sell";
            this.btn_TradeOption.UseVisualStyleBackColor = true;
            this.btn_TradeOption.Click += new System.EventHandler(this.btn_TradeOption_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // radio_buy
            // 
            this.radio_buy.AutoSize = true;
            this.radio_buy.Location = new System.Drawing.Point(12, 163);
            this.radio_buy.Name = "radio_buy";
            this.radio_buy.Size = new System.Drawing.Size(43, 17);
            this.radio_buy.TabIndex = 7;
            this.radio_buy.TabStop = true;
            this.radio_buy.Text = "Buy";
            this.radio_buy.UseVisualStyleBackColor = true;
            // 
            // radio_sell
            // 
            this.radio_sell.AutoSize = true;
            this.radio_sell.Location = new System.Drawing.Point(85, 163);
            this.radio_sell.Name = "radio_sell";
            this.radio_sell.Size = new System.Drawing.Size(42, 17);
            this.radio_sell.TabIndex = 8;
            this.radio_sell.TabStop = true;
            this.radio_sell.Text = "Sell";
            this.radio_sell.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(85, 242);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 10;
            // 
            // FormTradeOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 284);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radio_sell);
            this.Controls.Add(this.radio_buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_TradeOption);
            this.Controls.Add(this.data_Options);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label1);
            this.Name = "FormTradeOption";
            this.Text = "Trade Option";
            this.Load += new System.EventHandler(this.FormTradeOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Options)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.DataGridView data_Options;
        private DbTradeDataSet1 dbTradeDataSet1;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private DbTradeDataSet1TableAdapters.OptionsTableAdapter optionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callPutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn underlyingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_TradeOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_buy;
        private System.Windows.Forms.RadioButton radio_sell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Price;
    }
}