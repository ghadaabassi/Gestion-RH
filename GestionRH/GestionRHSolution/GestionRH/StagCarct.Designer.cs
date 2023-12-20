namespace GestionRH
{
    partial class StagCarct
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(917, 597);
            label7.Name = "label7";
            label7.Size = new Size(274, 54);
            label7.TabIndex = 13;
            label7.Text = "Experiencess ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(541, 597);
            label6.Name = "label6";
            label6.Size = new Size(274, 54);
            label6.TabIndex = 12;
            label6.Text = "Experiencess ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(173, 597);
            label5.Name = "label5";
            label5.Size = new Size(274, 54);
            label5.TabIndex = 11;
            label5.Text = "Experiencess ";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(917, 427);
            label3.Name = "label3";
            label3.Size = new Size(147, 59);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(550, 427);
            label2.Name = "label2";
            label2.Size = new Size(303, 59);
            label2.TabIndex = 9;
            label2.Text = "Encadrant";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 427);
            label1.Name = "label1";
            label1.Size = new Size(163, 59);
            label1.TabIndex = 8;
            label1.Text = "Sujet";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(323, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 117);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(239, 30);
            label4.Name = "label4";
            label4.Size = new Size(304, 60);
            label4.TabIndex = 4;
            label4.Text = "Stagiaire";
            label4.Click += label4_Click;
            // 
            // StagCarct
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1365, 849);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "StagCarct";
            Text = "StagCarct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
    }
}