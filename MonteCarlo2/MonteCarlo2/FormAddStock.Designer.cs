
namespace MonteCarlo2
{
    partial class FormAddStock
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
            this.txt_StockName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Exchange = new System.Windows.Forms.TextBox();
            this.txt_StockTicker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_StockName
            // 
            this.txt_StockName.Location = new System.Drawing.Point(69, 6);
            this.txt_StockName.Name = "txt_StockName";
            this.txt_StockName.Size = new System.Drawing.Size(100, 20);
            this.txt_StockName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txt_Exchange
            // 
            this.txt_Exchange.Location = new System.Drawing.Point(69, 75);
            this.txt_Exchange.Name = "txt_Exchange";
            this.txt_Exchange.Size = new System.Drawing.Size(100, 20);
            this.txt_Exchange.TabIndex = 2;
            // 
            // txt_StockTicker
            // 
            this.txt_StockTicker.Location = new System.Drawing.Point(69, 40);
            this.txt_StockTicker.Name = "txt_StockTicker";
            this.txt_StockTicker.Size = new System.Drawing.Size(100, 20);
            this.txt_StockTicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exchange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticker";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(12, 114);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(146, 33);
            this.btnAddStock.TabIndex = 6;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // FormAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 159);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_StockTicker);
            this.Controls.Add(this.txt_Exchange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_StockName);
            this.Name = "FormAddStock";
            this.Text = "FormAddStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_StockName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Exchange;
        private System.Windows.Forms.TextBox txt_StockTicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddStock;
    }
}