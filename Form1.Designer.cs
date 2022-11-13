namespace GuessNumberCasino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.betTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.magicNumberTextbox = new System.Windows.Forms.TextBox();
            this.magicNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pocketMoneyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.betTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.magicNumberTextbox);
            this.groupBox1.Controls.Add(this.magicNumberLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pocketMoneyTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(626, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 34);
            this.button6.TabIndex = 14;
            this.button6.Text = "-100";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "+100";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bet";
            // 
            // betTextbox
            // 
            this.betTextbox.Location = new System.Drawing.Point(291, 340);
            this.betTextbox.Name = "betTextbox";
            this.betTextbox.ReadOnly = true;
            this.betTextbox.Size = new System.Drawing.Size(51, 31);
            this.betTextbox.TabIndex = 11;
            this.betTextbox.Text = "100";
            this.betTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter a number between 1-10";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Reveal Magic Number";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // magicNumberTextbox
            // 
            this.magicNumberTextbox.Location = new System.Drawing.Point(290, 431);
            this.magicNumberTextbox.Name = "magicNumberTextbox";
            this.magicNumberTextbox.Size = new System.Drawing.Size(51, 31);
            this.magicNumberTextbox.TabIndex = 0;
            this.magicNumberTextbox.Text = "0";
            this.magicNumberTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.magicNumberTextbox.MouseEnter += new System.EventHandler(this.magicNumberTextbox_MouseEnter);
            this.magicNumberTextbox.MouseLeave += new System.EventHandler(this.magicNumberTextbox_MouseLeave);
            // 
            // magicNumberLabel
            // 
            this.magicNumberLabel.AutoSize = true;
            this.magicNumberLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.magicNumberLabel.Location = new System.Drawing.Point(278, 208);
            this.magicNumberLabel.Name = "magicNumberLabel";
            this.magicNumberLabel.Size = new System.Drawing.Size(81, 96);
            this.magicNumberLabel.TabIndex = 7;
            this.magicNumberLabel.Text = "0";
            this.magicNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Magic Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________________________________________________";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(326, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add 5000$";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add 500$";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add 50$";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pocketMoneyTextbox
            // 
            this.pocketMoneyTextbox.Location = new System.Drawing.Point(163, 79);
            this.pocketMoneyTextbox.Name = "pocketMoneyTextbox";
            this.pocketMoneyTextbox.ReadOnly = true;
            this.pocketMoneyTextbox.Size = new System.Drawing.Size(99, 31);
            this.pocketMoneyTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money in pocket:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 583);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino - Guess the number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Button button4;
        private TextBox magicNumberTextbox;
        private Label magicNumberLabel;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox pocketMoneyTextbox;
        private Label label1;
        private Button button6;
        private Button button5;
        private Label label4;
        private TextBox betTextbox;
    }
}