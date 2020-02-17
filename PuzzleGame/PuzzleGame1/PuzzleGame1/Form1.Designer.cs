namespace PuzzleGame1
{
    partial class Form1
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
            this.pnl = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHamle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.button9);
            this.pnl.Controls.Add(this.button8);
            this.pnl.Controls.Add(this.button7);
            this.pnl.Controls.Add(this.button6);
            this.pnl.Controls.Add(this.button5);
            this.pnl.Controls.Add(this.button4);
            this.pnl.Controls.Add(this.button3);
            this.pnl.Controls.Add(this.button2);
            this.pnl.Controls.Add(this.button1);
            this.pnl.Location = new System.Drawing.Point(181, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(284, 264);
            this.pnl.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(180, 165);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 65);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.swapLabel);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(109, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 65);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.swapLabel);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 65);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.swapLabel);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(180, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 65);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.swapLabel);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.swapLabel);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.swapLabel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.swapLabel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.swapLabel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.swapLabel);
            // 
            // lblHamle
            // 
            this.lblHamle.AutoSize = true;
            this.lblHamle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHamle.Location = new System.Drawing.Point(12, 12);
            this.lblHamle.Name = "lblHamle";
            this.lblHamle.Size = new System.Drawing.Size(134, 27);
            this.lblHamle.TabIndex = 1;
            this.lblHamle.Text = "Hamle Sayısı:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 52);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(134, 34);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 326);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblHamle);
            this.Controls.Add(this.pnl);
            this.Name = "Form1";
            this.Text = "Bulmaca ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHamle;
        private System.Windows.Forms.Button btnNewGame;
    }
}

