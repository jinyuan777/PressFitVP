namespace VP
{
    partial class TEST
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapgCassette = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CstQtyTXT = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CstNumTXT = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tapgDraw = new System.Windows.Forms.TabPage();
            this.tapgMDU = new System.Windows.Forms.TabPage();
            this.tapgMcu = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tapgCassette.SuspendLayout();
            this.tapgMcu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapgCassette);
            this.tabControl1.Controls.Add(this.tapgDraw);
            this.tabControl1.Controls.Add(this.tapgMDU);
            this.tabControl1.Controls.Add(this.tapgMcu);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tapgCassette
            // 
            this.tapgCassette.BackColor = System.Drawing.Color.Gainsboro;
            this.tapgCassette.Controls.Add(this.button9);
            this.tapgCassette.Controls.Add(this.label2);
            this.tapgCassette.Controls.Add(this.CstQtyTXT);
            this.tapgCassette.Controls.Add(this.button8);
            this.tapgCassette.Controls.Add(this.label1);
            this.tapgCassette.Controls.Add(this.CstNumTXT);
            this.tapgCassette.Controls.Add(this.button5);
            this.tapgCassette.Controls.Add(this.button6);
            this.tapgCassette.Location = new System.Drawing.Point(4, 33);
            this.tapgCassette.Name = "tapgCassette";
            this.tapgCassette.Padding = new System.Windows.Forms.Padding(3);
            this.tapgCassette.Size = new System.Drawing.Size(690, 327);
            this.tapgCassette.TabIndex = 0;
            this.tapgCassette.Text = "Cassette";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(77, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "DISPENSE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "掉藥數量";
            // 
            // CstQtyTXT
            // 
            this.CstQtyTXT.Location = new System.Drawing.Point(230, 43);
            this.CstQtyTXT.Name = "CstQtyTXT";
            this.CstQtyTXT.Size = new System.Drawing.Size(100, 33);
            this.CstQtyTXT.TabIndex = 7;
            this.CstQtyTXT.Text = "0";
            this.CstQtyTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(230, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 40);
            this.button8.TabIndex = 6;
            this.button8.Text = "DROP";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "藥盒號碼";
            // 
            // CstNumTXT
            // 
            this.CstNumTXT.Location = new System.Drawing.Point(90, 43);
            this.CstNumTXT.Name = "CstNumTXT";
            this.CstNumTXT.Size = new System.Drawing.Size(100, 33);
            this.CstNumTXT.TabIndex = 4;
            this.CstNumTXT.Text = "0";
            this.CstNumTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(77, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 40);
            this.button5.TabIndex = 3;
            this.button5.Text = "LED OFF";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(77, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "LED ON";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tapgDraw
            // 
            this.tapgDraw.BackColor = System.Drawing.Color.Gainsboro;
            this.tapgDraw.Location = new System.Drawing.Point(4, 33);
            this.tapgDraw.Name = "tapgDraw";
            this.tapgDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tapgDraw.Size = new System.Drawing.Size(690, 327);
            this.tapgDraw.TabIndex = 1;
            this.tapgDraw.Text = "DRAW";
            // 
            // tapgMDU
            // 
            this.tapgMDU.BackColor = System.Drawing.Color.Gainsboro;
            this.tapgMDU.Location = new System.Drawing.Point(4, 33);
            this.tapgMDU.Name = "tapgMDU";
            this.tapgMDU.Size = new System.Drawing.Size(690, 327);
            this.tapgMDU.TabIndex = 2;
            this.tapgMDU.Text = "MDU";
            // 
            // tapgMcu
            // 
            this.tapgMcu.BackColor = System.Drawing.Color.Gainsboro;
            this.tapgMcu.Controls.Add(this.button4);
            this.tapgMcu.Controls.Add(this.button3);
            this.tapgMcu.Controls.Add(this.button2);
            this.tapgMcu.Controls.Add(this.button1);
            this.tapgMcu.Location = new System.Drawing.Point(4, 33);
            this.tapgMcu.Name = "tapgMcu";
            this.tapgMcu.Size = new System.Drawing.Size(690, 327);
            this.tapgMcu.TabIndex = 3;
            this.tapgMcu.Text = "MCU";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "CUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(24, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Presure DOWN";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(24, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Presure    UP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(563, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 33);
            this.button7.TabIndex = 1;
            this.button7.Text = "CLOSE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 419);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Name = "TEST";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            this.tabControl1.ResumeLayout(false);
            this.tapgCassette.ResumeLayout(false);
            this.tapgCassette.PerformLayout();
            this.tapgMcu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapgCassette;
        private System.Windows.Forms.TabPage tapgDraw;
        private System.Windows.Forms.TabPage tapgMDU;
        private System.Windows.Forms.TabPage tapgMcu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CstQtyTXT;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CstNumTXT;
        private System.Windows.Forms.Button button9;
    }
}