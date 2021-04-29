using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Management;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using static MonteCarlo2.European;

namespace MonteCarlo2
{
    partial class Form1
    {

        
        Stopwatch watch = new Stopwatch();
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.strike_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spot_text = new System.Windows.Forms.TextBox();
            this.vol_text = new System.Windows.Forms.TextBox();
            this.rate_text = new System.Windows.Forms.TextBox();
            this.tenor_text = new System.Windows.Forms.TextBox();
            this.steps_text = new System.Windows.Forms.TextBox();
            this.sims_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.price_label = new System.Windows.Forms.Label();
            this.price_text = new System.Windows.Forms.TextBox();
            this.theta_text = new System.Windows.Forms.TextBox();
            this.rho_text = new System.Windows.Forms.TextBox();
            this.vega_text = new System.Windows.Forms.TextBox();
            this.gamma_text = new System.Windows.Forms.TextBox();
            this.delta_text = new System.Windows.Forms.TextBox();
            this.se_text = new System.Windows.Forms.TextBox();
            this.rho_label = new System.Windows.Forms.Label();
            this.theta_label = new System.Windows.Forms.Label();
            this.vega_label = new System.Windows.Forms.Label();
            this.gamma_label = new System.Windows.Forms.Label();
            this.delta_label = new System.Windows.Forms.Label();
            this.se_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textTimer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.multithread = new System.Windows.Forms.CheckBox();
            this.Processors = new System.Windows.Forms.Label();
            this.txt_processors = new System.Windows.Forms.TextBox();
            this.option_type = new System.Windows.Forms.ComboBox();
            this.barrierUI = new System.Windows.Forms.RadioButton();
            this.barrierDO = new System.Windows.Forms.RadioButton();
            this.barrierDI = new System.Windows.Forms.RadioButton();
            this.barrierUO = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rebate_txt = new System.Windows.Forms.TextBox();
            this.BarrierValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(0, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(211, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Call";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(302, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Put";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // strike_text
            // 
            this.strike_text.Location = new System.Drawing.Point(12, 45);
            this.strike_text.Name = "strike_text";
            this.strike_text.Size = new System.Drawing.Size(100, 20);
            this.strike_text.TabIndex = 3;
            this.strike_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strike";
            // 
            // spot_text
            // 
            this.spot_text.Location = new System.Drawing.Point(12, 131);
            this.spot_text.Name = "spot_text";
            this.spot_text.Size = new System.Drawing.Size(100, 20);
            this.spot_text.TabIndex = 5;
            this.spot_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // vol_text
            // 
            this.vol_text.Location = new System.Drawing.Point(12, 157);
            this.vol_text.Name = "vol_text";
            this.vol_text.Size = new System.Drawing.Size(100, 20);
            this.vol_text.TabIndex = 6;
            this.vol_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // rate_text
            // 
            this.rate_text.Location = new System.Drawing.Point(12, 183);
            this.rate_text.Name = "rate_text";
            this.rate_text.Size = new System.Drawing.Size(100, 20);
            this.rate_text.TabIndex = 10;
            this.rate_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // tenor_text
            // 
            this.tenor_text.Location = new System.Drawing.Point(12, 211);
            this.tenor_text.Name = "tenor_text";
            this.tenor_text.Size = new System.Drawing.Size(100, 20);
            this.tenor_text.TabIndex = 9;
            this.tenor_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // steps_text
            // 
            this.steps_text.Location = new System.Drawing.Point(12, 237);
            this.steps_text.Name = "steps_text";
            this.steps_text.Size = new System.Drawing.Size(100, 20);
            this.steps_text.TabIndex = 8;
            this.steps_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // sims_text
            // 
            this.sims_text.Location = new System.Drawing.Point(12, 263);
            this.sims_text.Name = "sims_text";
            this.sims_text.Size = new System.Drawing.Size(100, 20);
            this.sims_text.TabIndex = 7;
            this.sims_text.TextChanged += new System.EventHandler(this.txt_textChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Simulations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Steps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tenor (Years)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Risk Free Rate (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vol (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Spot";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider4
            // 
            this.errorProvider4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider5
            // 
            this.errorProvider5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider6
            // 
            this.errorProvider6.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider6.ContainerControl = this;
            this.errorProvider6.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider7
            // 
            this.errorProvider7.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider7.ContainerControl = this;
            this.errorProvider7.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // errorProvider8
            // 
            this.errorProvider8.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider8.ContainerControl = this;
            this.errorProvider8.RightToLeftChanged += new System.EventHandler(this.Form1_Load);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(545, 45);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(31, 13);
            this.price_label.TabIndex = 17;
            this.price_label.Text = "Price";
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(439, 41);
            this.price_text.Name = "price_text";
            this.price_text.ReadOnly = true;
            this.price_text.Size = new System.Drawing.Size(100, 20);
            this.price_text.TabIndex = 18;
            // 
            // theta_text
            // 
            this.theta_text.Location = new System.Drawing.Point(439, 219);
            this.theta_text.Name = "theta_text";
            this.theta_text.ReadOnly = true;
            this.theta_text.Size = new System.Drawing.Size(100, 20);
            this.theta_text.TabIndex = 19;
            // 
            // rho_text
            // 
            this.rho_text.Location = new System.Drawing.Point(439, 254);
            this.rho_text.Name = "rho_text";
            this.rho_text.ReadOnly = true;
            this.rho_text.Size = new System.Drawing.Size(100, 20);
            this.rho_text.TabIndex = 20;
            // 
            // vega_text
            // 
            this.vega_text.Location = new System.Drawing.Point(439, 183);
            this.vega_text.Name = "vega_text";
            this.vega_text.ReadOnly = true;
            this.vega_text.Size = new System.Drawing.Size(100, 20);
            this.vega_text.TabIndex = 21;
            // 
            // gamma_text
            // 
            this.gamma_text.Location = new System.Drawing.Point(439, 147);
            this.gamma_text.Name = "gamma_text";
            this.gamma_text.ReadOnly = true;
            this.gamma_text.Size = new System.Drawing.Size(100, 20);
            this.gamma_text.TabIndex = 22;
            // 
            // delta_text
            // 
            this.delta_text.Location = new System.Drawing.Point(439, 111);
            this.delta_text.Name = "delta_text";
            this.delta_text.ReadOnly = true;
            this.delta_text.Size = new System.Drawing.Size(100, 20);
            this.delta_text.TabIndex = 23;
            // 
            // se_text
            // 
            this.se_text.Location = new System.Drawing.Point(439, 78);
            this.se_text.Name = "se_text";
            this.se_text.ReadOnly = true;
            this.se_text.Size = new System.Drawing.Size(100, 20);
            this.se_text.TabIndex = 24;
            // 
            // rho_label
            // 
            this.rho_label.AutoSize = true;
            this.rho_label.Location = new System.Drawing.Point(545, 257);
            this.rho_label.Name = "rho_label";
            this.rho_label.Size = new System.Drawing.Size(27, 13);
            this.rho_label.TabIndex = 25;
            this.rho_label.Text = "Rho";
            // 
            // theta_label
            // 
            this.theta_label.AutoSize = true;
            this.theta_label.Location = new System.Drawing.Point(545, 226);
            this.theta_label.Name = "theta_label";
            this.theta_label.Size = new System.Drawing.Size(35, 13);
            this.theta_label.TabIndex = 26;
            this.theta_label.Text = "Theta";
            this.theta_label.Click += new System.EventHandler(this.label10_Click);
            // 
            // vega_label
            // 
            this.vega_label.AutoSize = true;
            this.vega_label.Location = new System.Drawing.Point(545, 186);
            this.vega_label.Name = "vega_label";
            this.vega_label.Size = new System.Drawing.Size(32, 13);
            this.vega_label.TabIndex = 27;
            this.vega_label.Text = "Vega";
            // 
            // gamma_label
            // 
            this.gamma_label.AutoSize = true;
            this.gamma_label.Location = new System.Drawing.Point(545, 150);
            this.gamma_label.Name = "gamma_label";
            this.gamma_label.Size = new System.Drawing.Size(43, 13);
            this.gamma_label.TabIndex = 28;
            this.gamma_label.Text = "Gamma";
            // 
            // delta_label
            // 
            this.delta_label.AutoSize = true;
            this.delta_label.Location = new System.Drawing.Point(545, 115);
            this.delta_label.Name = "delta_label";
            this.delta_label.Size = new System.Drawing.Size(32, 13);
            this.delta_label.TabIndex = 29;
            this.delta_label.Text = "Delta";
            // 
            // se_label
            // 
            this.se_label.AutoSize = true;
            this.se_label.Location = new System.Drawing.Point(545, 81);
            this.se_label.Name = "se_label";
            this.se_label.Size = new System.Drawing.Size(75, 13);
            this.se_label.TabIndex = 30;
            this.se_label.Text = "Standard Error";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Use Antithetic Variance Reduction";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 312);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 17);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Use Delta-Based Control Variate";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textTimer
            // 
            this.textTimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimer.Location = new System.Drawing.Point(258, 344);
            this.textTimer.Name = "textTimer";
            this.textTimer.Size = new System.Drawing.Size(196, 33);
            this.textTimer.TabIndex = 34;
            this.textTimer.Text = "00:00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Computation Timer";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(220, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 31);
            this.progressBar1.TabIndex = 36;
            // 
            // multithread
            // 
            this.multithread.AutoSize = true;
            this.multithread.Location = new System.Drawing.Point(205, 289);
            this.multithread.Name = "multithread";
            this.multithread.Size = new System.Drawing.Size(118, 17);
            this.multithread.TabIndex = 37;
            this.multithread.Text = "Use MultiThreading";
            this.multithread.UseVisualStyleBackColor = true;
            // 
            // Processors
            // 
            this.Processors.AutoSize = true;
            this.Processors.Location = new System.Drawing.Point(470, 316);
            this.Processors.Name = "Processors";
            this.Processors.Size = new System.Drawing.Size(157, 13);
            this.Processors.TabIndex = 38;
            this.Processors.Text = "Number of Available Processors";
            // 
            // txt_processors
            // 
            this.txt_processors.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_processors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_processors.Location = new System.Drawing.Point(470, 330);
            this.txt_processors.Name = "txt_processors";
            this.txt_processors.Size = new System.Drawing.Size(150, 31);
            this.txt_processors.TabIndex = 40;
            // 
            // option_type
            // 
            this.option_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option_type.FormattingEnabled = true;
            this.option_type.Items.AddRange(new object[] {
            "European",
            "Asian",
            "Digital",
            "Barrier",
            "Lookback",
            "Range"});
            this.option_type.Location = new System.Drawing.Point(12, 18);
            this.option_type.Name = "option_type";
            this.option_type.Size = new System.Drawing.Size(121, 21);
            this.option_type.TabIndex = 41;
            // 
            // barrierUI
            // 
            this.barrierUI.AutoSize = true;
            this.barrierUI.Location = new System.Drawing.Point(6, 16);
            this.barrierUI.Name = "barrierUI";
            this.barrierUI.Size = new System.Drawing.Size(72, 17);
            this.barrierUI.TabIndex = 42;
            this.barrierUI.TabStop = true;
            this.barrierUI.Text = "Up and In";
            this.barrierUI.UseVisualStyleBackColor = true;
            // 
            // barrierDO
            // 
            this.barrierDO.AutoSize = true;
            this.barrierDO.Location = new System.Drawing.Point(97, 55);
            this.barrierDO.Name = "barrierDO";
            this.barrierDO.Size = new System.Drawing.Size(94, 17);
            this.barrierDO.TabIndex = 43;
            this.barrierDO.TabStop = true;
            this.barrierDO.Text = "Down and Out";
            this.barrierDO.UseVisualStyleBackColor = true;
            // 
            // barrierDI
            // 
            this.barrierDI.AutoSize = true;
            this.barrierDI.Location = new System.Drawing.Point(6, 55);
            this.barrierDI.Name = "barrierDI";
            this.barrierDI.Size = new System.Drawing.Size(86, 17);
            this.barrierDI.TabIndex = 44;
            this.barrierDI.TabStop = true;
            this.barrierDI.Text = "Down and In";
            this.barrierDI.UseVisualStyleBackColor = true;
            // 
            // barrierUO
            // 
            this.barrierUO.AutoSize = true;
            this.barrierUO.Location = new System.Drawing.Point(97, 16);
            this.barrierUO.Name = "barrierUO";
            this.barrierUO.Size = new System.Drawing.Size(80, 17);
            this.barrierUO.TabIndex = 45;
            this.barrierUO.TabStop = true;
            this.barrierUO.Text = "Up and Out";
            this.barrierUO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barrierUI);
            this.groupBox1.Controls.Add(this.barrierDO);
            this.groupBox1.Controls.Add(this.barrierDI);
            this.groupBox1.Controls.Add(this.barrierUO);
            this.groupBox1.Location = new System.Drawing.Point(205, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 84);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barrier Type";
            // 
            // rebate_txt
            // 
            this.rebate_txt.Location = new System.Drawing.Point(12, 105);
            this.rebate_txt.Name = "rebate_txt";
            this.rebate_txt.Size = new System.Drawing.Size(100, 20);
            this.rebate_txt.TabIndex = 47;
            // 
            // BarrierValue
            // 
            this.BarrierValue.Location = new System.Drawing.Point(12, 74);
            this.BarrierValue.Name = "BarrierValue";
            this.BarrierValue.Size = new System.Drawing.Size(100, 20);
            this.BarrierValue.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Barrier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Digital - Rebate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Select Option Type Below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BarrierValue);
            this.Controls.Add(this.rebate_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.option_type);
            this.Controls.Add(this.txt_processors);
            this.Controls.Add(this.Processors);
            this.Controls.Add(this.multithread);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTimer);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.se_label);
            this.Controls.Add(this.delta_label);
            this.Controls.Add(this.gamma_label);
            this.Controls.Add(this.vega_label);
            this.Controls.Add(this.theta_label);
            this.Controls.Add(this.rho_label);
            this.Controls.Add(this.se_text);
            this.Controls.Add(this.delta_text);
            this.Controls.Add(this.gamma_text);
            this.Controls.Add(this.vega_text);
            this.Controls.Add(this.rho_text);
            this.Controls.Add(this.theta_text);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rate_text);
            this.Controls.Add(this.tenor_text);
            this.Controls.Add(this.steps_text);
            this.Controls.Add(this.sims_text);
            this.Controls.Add(this.vol_text);
            this.Controls.Add(this.spot_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strike_text);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Monte Carlo Simulator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox strike_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spot_text;
        private System.Windows.Forms.TextBox vol_text;
        private System.Windows.Forms.TextBox rate_text;
        private System.Windows.Forms.TextBox tenor_text;
        private System.Windows.Forms.TextBox steps_text;
        private System.Windows.Forms.TextBox sims_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;




        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.SetIconAlignment(strike_text, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconPadding(strike_text, 3);
            errorProvider2.SetIconAlignment(spot_text, ErrorIconAlignment.MiddleRight);
            errorProvider2.SetIconPadding(spot_text, 3);
            errorProvider3.SetIconAlignment(vol_text, ErrorIconAlignment.MiddleRight);
            errorProvider3.SetIconPadding(vol_text, 3);
            errorProvider4.SetIconAlignment(tenor_text, ErrorIconAlignment.MiddleRight);
            errorProvider4.SetIconPadding(tenor_text, 3);
            errorProvider5.SetIconAlignment(rate_text, ErrorIconAlignment.MiddleRight);
            errorProvider5.SetIconPadding(rate_text, 3);
            errorProvider6.SetIconAlignment(steps_text, ErrorIconAlignment.MiddleRight);
            errorProvider6.SetIconPadding(steps_text, 3);
            errorProvider7.SetIconAlignment(sims_text, ErrorIconAlignment.MiddleRight);
            errorProvider7.SetIconPadding(sims_text, 3);

        }

        /// <summary>
        /// 
        ///This method provides some of the error handling of the user inputs. It does not
        ///allow for negative values or non-numeric values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_textChanged(object sender, EventArgs e)
        {
            double strike;
            double spot;
            double vol;
            double tenor;
            double rate;
            int steps;
            int paths;
            if (!double.TryParse(strike_text.Text, out strike) || strike <= 0)
                errorProvider1.SetError(strike_text, "Enter Positive Number");
            else
                errorProvider1.SetError(strike_text, string.Empty);
            if (!double.TryParse(vol_text.Text, out vol) || vol <= 0)
                errorProvider3.SetError(vol_text, "Enter Positive Number");
            else
                errorProvider3.SetError(vol_text, string.Empty);
            if (!double.TryParse(tenor_text.Text, out tenor) || tenor <= 0)
                errorProvider4.SetError(tenor_text, "Enter Positive Number");
            else
                errorProvider4.SetError(tenor_text, string.Empty);
            if (!double.TryParse(spot_text.Text, out spot) || spot <= 0)
                errorProvider2.SetError(spot_text, "Enter Positive Number");
            else
                errorProvider2.SetError(spot_text, string.Empty);
            if (!double.TryParse(rate_text.Text, out rate) || rate <= 0)
                errorProvider5.SetError(rate_text, "Enter Positive Number");
            else
                errorProvider5.SetError(rate_text, string.Empty);
            if (!int.TryParse(steps_text.Text, out steps) || steps <= 0)
                errorProvider6.SetError(steps_text, "Enter Positive Integer");
            else
                errorProvider6.SetError(steps_text, string.Empty);
            if (!int.TryParse(sims_text.Text, out paths) || paths <= 0 || paths > 1000000)
                errorProvider7.SetError(sims_text, "Enter Positive Integer that is less than 1000001");
            else
                errorProvider7.SetError(sims_text, string.Empty);
        }

        public delegate void get_matrix(int a, int b);

        /// <summary>
        /// 
        /// This is the "calculate" button method which runs the simulation by instantiating 
        /// an Option object based on the user inputs, and then printing values to the GUI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            int coreCount = Environment.ProcessorCount;
            txt_processors.Text = coreCount.ToString();
            progressBar1.Value = 0;
            this.button1.Enabled = false;
            watch.Restart();
            watch.Start();
            //this.textTimer.Text = "...timing...";
            

            double strike;
            double volatility;
            double spot;
            double tenor;
            double rate;
            double barrier = -1;
            double rebate_input = -1;
            int steps;
            int paths;

            bool call = radioButton1.Checked;



            if (
            double.TryParse(strike_text.Text, out strike) == false ||
            double.TryParse(vol_text.Text, out volatility) == false ||
            double.TryParse(spot_text.Text, out spot) == false ||
            double.TryParse(tenor_text.Text, out tenor) == false ||
            double.TryParse(rate_text.Text, out rate) == false ||
            int.TryParse(steps_text.Text, out steps) == false ||
            int.TryParse(sims_text.Text, out paths) == false ||
            (radioButton1.Checked == false & radioButton2.Checked == false)
            || strike <= 0 || spot <= 0 || volatility <= 0 || tenor <= 0
            || rate <= 0 || steps <= 0 || paths <= 0 || paths > 1000000 
            )
            {
                MessageBox.Show("Invalid Inputs");
                
            }
            else if (option_type.SelectedItem.ToString() == "Barrier" &&
                (double.TryParse(BarrierValue.Text, out barrier) == false ||
                barrier <= 0))
            {
                MessageBox.Show("Invalid Inputs");
            }
            else if (option_type.SelectedItem.ToString() == "Digital" &&
                (double.TryParse(rebate_txt.Text, out rebate_input) == false ||
                rebate_input <= 0))
            {
                MessageBox.Show("Invalid Inputs");
            }
            else
            {
                Option option;

                //Euro 
                if (option_type.SelectedItem.ToString() == "European")
                {
                    option = new European
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call
                    };
                }

                //Asian
                else if (option_type.SelectedItem.ToString() == "Asian")
                {
                    option = new Asian
                    {

                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call
                    };
                }
                //Barrier
                else if (option_type.SelectedItem.ToString() == "Barrier")
                {
                    bool downIn = barrierDI.Checked;
                    bool downOut = barrierDO.Checked;
                    bool upIn = barrierUI.Checked;
                    bool upOut = barrierUO.Checked;

                    option = new Barrier
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call,
                        down_in = downIn,
                        down_out = downOut,
                        up_in = upIn,
                        up_out = upOut,
                        barrier_value = barrier
                    };
                }
                //Digital
                else if (option_type.SelectedItem.ToString() == "Digital")
                {
                    double digital_rebate = rebate_input;
                    option = new Digital
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call,
                        rebate = rebate_input
                    };
                }
                else if (option_type.SelectedItem.ToString() == "Lookback")
                {
                    option = new Lookback
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call

                    };
                }
                else if (option_type.SelectedItem.ToString() == "Range")
                {
                    option = new Range
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        //is call does not matter for Range 
                        isCall = call
                    };
                }
                //temporary else statement until all options implemented
                else
                {
                    option = new European
                    {
                        Strike = strike,
                        Vol = volatility / 100,
                        Underlying = spot,
                        Tenor = tenor,
                        Rate = rate / 100,
                        isCall = call
                    };
                }

                //variance reduction techniques
                bool antithetic = checkBox1.Checked;
                bool cv = checkBox2.Checked;

                double[] price;
                Dictionary<string, double> greeks;


                if (multithread.Checked)
                {
                    // initialize random matrix with correct dimensions paths x steps
                    matrix = new double[paths, steps];

                    coreCount = 2; //my computer has 2 but this code can be easily changed for more
                    //coreCount = Environment.Processors...

                    //create array of threads equal to number of cores
                    List<Thread> threads = new List<Thread>();
                    for (int i = 0; i < coreCount; i++)
                    {
                        threads.Add(new Thread(new ParameterizedThreadStart(rand_matrix_thread)));
                    }

                    Params p1 = new Params
                    {
                        index_start = 0,
                        index_end = paths/2,
                        m_steps = steps

                    };
                    Params p2 = new Params
                    {
                        index_start = p1.index_end,
                        index_end = paths,
                        m_steps = steps
                    };
                    threads[0].Start(p1);
                    threads[1].Start(p2);
                    threads[0].Join();
                    threads[0].Join();

                    progressBar1.Value = 33;

                    price = option.Price(option.Vol, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, matrix, antithetic, cv);
                    progressBar1.Value = 66;
                    greeks = Greeks.Calculate(paths, steps, option, matrix, antithetic, cv, price[0]);

                }
                
                //non threading logic
                else
                {
                    progressBar1.Value = 33;
                    NormRand rnd = new NormRand();
                    double[,] random_matrix = rnd.BoxMuller_Matrix(paths, steps);
                    price = option.Price(option.Vol, option.Rate, option.Underlying, option.Strike, option.Tenor, paths, steps, random_matrix, antithetic, cv);
                    progressBar1.Value = 66;
                    greeks = Greeks.Calculate(paths, steps, option, random_matrix, antithetic, cv, price[0]);
                }

                   // print values to GUI 
                    price_text.Text = price[0].ToString();
                    se_text.Text = price[1].ToString();
                    delta_text.Text = greeks["delta"].ToString();
                    gamma_text.Text = greeks["gamma"].ToString();
                    vega_text.Text = greeks["vega"].ToString();
                    theta_text.Text = greeks["theta"].ToString();
                    rho_text.Text = greeks["rho"].ToString();
                    progressBar1.Value = 100;
               


            }

            watch.Stop();
            textTimer.Text = watch.Elapsed.Hours.ToString() + ":"
                + watch.Elapsed.Minutes.ToString() + ":"
                + watch.Elapsed.Seconds.ToString() + ":"
                + watch.Elapsed.Milliseconds.ToString();
            watch.Restart();
            this.button1.Enabled = true;

        }
        public void IncrementProgressMethod()
        {
            progressBar1.Value +=1;
        }
        //int progress = 0;
        public static double[,] matrix;
        NormRand rand = new NormRand();
        Random rnd = new Random();

        //static int ob = 0;
        
        public void rand_matrix_thread(object a)
        {
            
            Params p = (Params)a;
            
                //bpx_muller method
                for (int i = p.index_start; i < p.index_end; i++)
                {
                    for (int j = 0; j < p.m_steps; j++)
                    {
                        lock (this)
                        {
                            double number1 = rnd.NextDouble();
                            double number2 = rnd.NextDouble();
                            double uniform1 = 1.0 - number1;
                            double uniform2 = 1.0 - number2;
                            double norm = Math.Sqrt(-2 * Math.Log(uniform1)) * Math.Cos(2 * Math.PI * uniform2);
                            matrix[i, j] = norm;
                        }

                    }
                //this.BeginInvoke(myDelegate);
            }
                   
        }
        
       

        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
        private Label se_label;
        private Label delta_label;
        private Label gamma_label;
        private Label vega_label;
        private Label theta_label;
        private Label rho_label;
        private TextBox se_text;
        private TextBox delta_text;
        private TextBox gamma_text;
        private TextBox vega_text;
        private TextBox rho_text;
        private TextBox theta_text;
        private TextBox price_text;
        private Label price_label;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textTimer;
        private Label label8;
        private ProgressBar progressBar1;
        private TextBox txt_processors;
        private Label Processors;
        private CheckBox multithread;
        private RadioButton barrierUO;
        private RadioButton barrierDI;
        private RadioButton barrierDO;
        private RadioButton barrierUI;
        private ComboBox option_type;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox BarrierValue;
        private TextBox rebate_txt;
        private Label label10;
        private Label label11;
    }
    public class Params
    {
        public int index_start { get; set; }
        public int index_end { get; set; }

        public int m_steps { get; set; }
    } 
}


