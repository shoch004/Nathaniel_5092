
namespace MonteCarlo2
{
    partial class FormAddOptions
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
            this.btn_AddOption = new System.Windows.Forms.Button();
            this.drop_OptionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_call = new System.Windows.Forms.RadioButton();
            this.txt_Strike = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drop_Stock = new System.Windows.Forms.ComboBox();
            this.dbTradeDataSet = new MonteCarlo2.DbTradeDataSet();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new MonteCarlo2.DbTradeDataSetTableAdapters.StocksTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Rebate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Barrier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Tenor = new System.Windows.Forms.TextBox();
            this.radio_put = new System.Windows.Forms.RadioButton();
            this.barrier_type = new System.Windows.Forms.GroupBox();
            this.radioBarrierDO = new System.Windows.Forms.RadioButton();
            this.radioBarrierDI = new System.Windows.Forms.RadioButton();
            this.radioBarrierUO = new System.Windows.Forms.RadioButton();
            this.radioBarrierUI = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.barrier_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddOption
            // 
            this.btn_AddOption.Location = new System.Drawing.Point(43, 227);
            this.btn_AddOption.Name = "btn_AddOption";
            this.btn_AddOption.Size = new System.Drawing.Size(277, 48);
            this.btn_AddOption.TabIndex = 0;
            this.btn_AddOption.Text = "Add Option";
            this.btn_AddOption.UseVisualStyleBackColor = true;
            this.btn_AddOption.Click += new System.EventHandler(this.btn_AddOption_Click);
            // 
            // drop_OptionType
            // 
            this.drop_OptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_OptionType.FormattingEnabled = true;
            this.drop_OptionType.Items.AddRange(new object[] {
            "European",
            "Asian",
            "Barrier",
            "Digital",
            "Lookback",
            "Range"});
            this.drop_OptionType.Location = new System.Drawing.Point(102, 13);
            this.drop_OptionType.Name = "drop_OptionType";
            this.drop_OptionType.Size = new System.Drawing.Size(121, 21);
            this.drop_OptionType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Option Type";
            // 
            // radio_call
            // 
            this.radio_call.AutoSize = true;
            this.radio_call.Location = new System.Drawing.Point(282, 27);
            this.radio_call.Name = "radio_call";
            this.radio_call.Size = new System.Drawing.Size(42, 17);
            this.radio_call.TabIndex = 3;
            this.radio_call.TabStop = true;
            this.radio_call.Text = "Call";
            this.radio_call.UseVisualStyleBackColor = true;
            // 
            // txt_Strike
            // 
            this.txt_Strike.Location = new System.Drawing.Point(102, 87);
            this.txt_Strike.Name = "txt_Strike";
            this.txt_Strike.Size = new System.Drawing.Size(100, 20);
            this.txt_Strike.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Underlying";
            // 
            // drop_Stock
            // 
            this.drop_Stock.DataSource = this.stocksBindingSource;
            this.drop_Stock.DisplayMember = "Name";
            this.drop_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_Stock.FormattingEnabled = true;
            this.drop_Stock.Location = new System.Drawing.Point(102, 48);
            this.drop_Stock.Name = "drop_Stock";
            this.drop_Stock.Size = new System.Drawing.Size(121, 21);
            this.drop_Stock.TabIndex = 6;
            this.drop_Stock.ValueMember = "Ticker";
            // 
            // dbTradeDataSet
            // 
            this.dbTradeDataSet.DataSetName = "DbTradeDataSet";
            this.dbTradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.dbTradeDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Strike";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digital - Rebate";
            // 
            // txt_Rebate
            // 
            this.txt_Rebate.Location = new System.Drawing.Point(102, 122);
            this.txt_Rebate.Name = "txt_Rebate";
            this.txt_Rebate.Size = new System.Drawing.Size(100, 20);
            this.txt_Rebate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Barrier";
            // 
            // txt_Barrier
            // 
            this.txt_Barrier.Location = new System.Drawing.Point(102, 156);
            this.txt_Barrier.Name = "txt_Barrier";
            this.txt_Barrier.Size = new System.Drawing.Size(100, 20);
            this.txt_Barrier.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tenor";
            // 
            // txt_Tenor
            // 
            this.txt_Tenor.Location = new System.Drawing.Point(102, 191);
            this.txt_Tenor.Name = "txt_Tenor";
            this.txt_Tenor.Size = new System.Drawing.Size(100, 20);
            this.txt_Tenor.TabIndex = 13;
            // 
            // radio_put
            // 
            this.radio_put.AutoSize = true;
            this.radio_put.Location = new System.Drawing.Point(350, 27);
            this.radio_put.Name = "radio_put";
            this.radio_put.Size = new System.Drawing.Size(41, 17);
            this.radio_put.TabIndex = 14;
            this.radio_put.TabStop = true;
            this.radio_put.Text = "Put";
            this.radio_put.UseVisualStyleBackColor = true;
            // 
            // barrier_type
            // 
            this.barrier_type.Controls.Add(this.radioBarrierUI);
            this.barrier_type.Controls.Add(this.radioBarrierUO);
            this.barrier_type.Controls.Add(this.radioBarrierDI);
            this.barrier_type.Controls.Add(this.radioBarrierDO);
            this.barrier_type.Location = new System.Drawing.Point(243, 87);
            this.barrier_type.Name = "barrier_type";
            this.barrier_type.Size = new System.Drawing.Size(148, 74);
            this.barrier_type.TabIndex = 15;
            this.barrier_type.TabStop = false;
            this.barrier_type.Text = "Barrier Type";
            // 
            // radioBarrierDO
            // 
            this.radioBarrierDO.AutoSize = true;
            this.radioBarrierDO.Location = new System.Drawing.Point(4, 19);
            this.radioBarrierDO.Name = "radioBarrierDO";
            this.radioBarrierDO.Size = new System.Drawing.Size(73, 17);
            this.radioBarrierDO.TabIndex = 16;
            this.radioBarrierDO.TabStop = true;
            this.radioBarrierDO.Text = "Down Out";
            this.radioBarrierDO.UseVisualStyleBackColor = true;
            // 
            // radioBarrierDI
            // 
            this.radioBarrierDI.AutoSize = true;
            this.radioBarrierDI.Location = new System.Drawing.Point(83, 19);
            this.radioBarrierDI.Name = "radioBarrierDI";
            this.radioBarrierDI.Size = new System.Drawing.Size(65, 17);
            this.radioBarrierDI.TabIndex = 17;
            this.radioBarrierDI.TabStop = true;
            this.radioBarrierDI.Text = "Down In";
            this.radioBarrierDI.UseVisualStyleBackColor = true;
            // 
            // radioBarrierUO
            // 
            this.radioBarrierUO.AutoSize = true;
            this.radioBarrierUO.Location = new System.Drawing.Point(6, 44);
            this.radioBarrierUO.Name = "radioBarrierUO";
            this.radioBarrierUO.Size = new System.Drawing.Size(59, 17);
            this.radioBarrierUO.TabIndex = 18;
            this.radioBarrierUO.TabStop = true;
            this.radioBarrierUO.Text = "Up Out";
            this.radioBarrierUO.UseVisualStyleBackColor = true;
            // 
            // radioBarrierUI
            // 
            this.radioBarrierUI.AutoSize = true;
            this.radioBarrierUI.Location = new System.Drawing.Point(83, 44);
            this.radioBarrierUI.Name = "radioBarrierUI";
            this.radioBarrierUI.Size = new System.Drawing.Size(51, 17);
            this.radioBarrierUI.TabIndex = 19;
            this.radioBarrierUI.TabStop = true;
            this.radioBarrierUI.Text = "Up In";
            this.radioBarrierUI.UseVisualStyleBackColor = true;
            // 
            // FormAddOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 290);
            this.Controls.Add(this.barrier_type);
            this.Controls.Add(this.radio_put);
            this.Controls.Add(this.txt_Tenor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Barrier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Rebate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drop_Stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Strike);
            this.Controls.Add(this.radio_call);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drop_OptionType);
            this.Controls.Add(this.btn_AddOption);
            this.Name = "FormAddOptions";
            this.Text = "FormAddOptions";
            this.Load += new System.EventHandler(this.FormAddOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.barrier_type.ResumeLayout(false);
            this.barrier_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddOption;
        private System.Windows.Forms.ComboBox drop_OptionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_call;
        private System.Windows.Forms.TextBox txt_Strike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drop_Stock;
        private DbTradeDataSet dbTradeDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private DbTradeDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Rebate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Barrier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Tenor;
        private System.Windows.Forms.RadioButton radio_put;
        private System.Windows.Forms.GroupBox barrier_type;
        private System.Windows.Forms.RadioButton radioBarrierUI;
        private System.Windows.Forms.RadioButton radioBarrierUO;
        private System.Windows.Forms.RadioButton radioBarrierDI;
        private System.Windows.Forms.RadioButton radioBarrierDO;
    }
}