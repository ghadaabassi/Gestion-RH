namespace GestionRH
{
    partial class RH
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listView1 = new ListView();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(515, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 15.9000006F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(244, 17);
            label1.Name = "label1";
            label1.Size = new Size(394, 69);
            label1.TabIndex = 0;
            label1.Text = "Gestion RH";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(39, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 109);
            panel2.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(299, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(168, 45);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Stagiaire";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(67, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 45);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Employe";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listView1.Location = new Point(41, 293);
            listView1.Name = "listView1";
            listView1.ShowGroups = false;
            listView1.Size = new Size(533, 518);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(39, 835);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 115);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(299, 31);
            button2.Name = "button2";
            button2.Size = new Size(222, 69);
            button2.TabIndex = 1;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(49, 31);
            button1.Name = "button1";
            button1.Size = new Size(213, 69);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(715, 306);
            label2.Name = "label2";
            label2.Size = new Size(95, 62);
            label2.TabIndex = 4;
            label2.Text = "Id :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(715, 440);
            label3.Name = "label3";
            label3.Size = new Size(195, 62);
            label3.TabIndex = 5;
            label3.Text = "Salaire :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(715, 580);
            label4.Name = "label4";
            label4.Size = new Size(393, 62);
            label4.TabIndex = 6;
            label4.Text = "Date Embauche :";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(951, 807);
            button3.Name = "button3";
            button3.Size = new Size(485, 95);
            button3.TabIndex = 7;
            button3.Text = "Caracteristiques";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // RH
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1799, 980);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RH";
            Text = "RH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListView listView1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
    }
}