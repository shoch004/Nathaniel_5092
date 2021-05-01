
namespace MonteCarlo2
{
    partial class FormAddRate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.btn_AddRate = new System.Windows.Forms.Button();
            this.txt_Tenor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate (%)";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Location = new System.Drawing.Point(88, 12);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 20);
            this.txt_Rate.TabIndex = 1;
            // 
            // btn_AddRate
            // 
            this.btn_AddRate.Location = new System.Drawing.Point(28, 101);
            this.btn_AddRate.Name = "btn_AddRate";
            this.btn_AddRate.Size = new System.Drawing.Size(185, 32);
            this.btn_AddRate.TabIndex = 2;
            this.btn_AddRate.Text = "Add Rate";
            this.btn_AddRate.UseVisualStyleBackColor = true;
            this.btn_AddRate.Click += new System.EventHandler(this.btn_AddRate_Click);
            // 
            // txt_Tenor
            // 
            this.txt_Tenor.Location = new System.Drawing.Point(88, 63);
            this.txt_Tenor.Name = "txt_Tenor";
            this.txt_Tenor.Size = new System.Drawing.Size(100, 20);
            this.txt_Tenor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenor (years)";
            // 
            // FormAddRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Tenor);
            this.Controls.Add(this.btn_AddRate);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.label1);
            this.Name = "FormAddRate";
            this.Text = "FormAddRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.Button btn_AddRate;
        private System.Windows.Forms.TextBox txt_Tenor;
        private System.Windows.Forms.Label label2;
    }
}