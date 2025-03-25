namespace TP_Form
{
    partial class Form_Cotation
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
            label1 = new Label();
            txt_Nom = new TextBox();
            label2 = new Label();
            txt_Adresse = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_Math = new TextBox();
            label5 = new Label();
            txt_Français = new TextBox();
            label6 = new Label();
            txt_Prog = new TextBox();
            label7 = new Label();
            txt_Algo = new TextBox();
            label8 = new Label();
            txt_Bur = new TextBox();
            combo_Sex = new ComboBox();
            lbl_Message = new Label();
            btn_Coter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(46, 79);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom:";
            // 
            // txt_Nom
            // 
            txt_Nom.ForeColor = Color.DarkCyan;
            txt_Nom.Location = new Point(151, 79);
            txt_Nom.Name = "txt_Nom";
            txt_Nom.Size = new Size(291, 33);
            txt_Nom.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(46, 127);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Adresse:";
            // 
            // txt_Adresse
            // 
            txt_Adresse.ForeColor = Color.DarkCyan;
            txt_Adresse.Location = new Point(151, 124);
            txt_Adresse.Name = "txt_Adresse";
            txt_Adresse.Size = new Size(291, 33);
            txt_Adresse.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(48, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 0;
            label3.Text = "Sexe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(48, 295);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 0;
            label4.Text = "Math(/50)";
            // 
            // txt_Math
            // 
            txt_Math.ForeColor = Color.DarkCyan;
            txt_Math.Location = new Point(255, 292);
            txt_Math.Name = "txt_Math";
            txt_Math.Size = new Size(187, 33);
            txt_Math.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(51, 344);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 0;
            label5.Text = "Français(/40)";
            // 
            // txt_Français
            // 
            txt_Français.ForeColor = Color.DarkCyan;
            txt_Français.Location = new Point(255, 341);
            txt_Français.Name = "txt_Français";
            txt_Français.Size = new Size(187, 33);
            txt_Français.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(51, 395);
            label6.Name = "label6";
            label6.Size = new Size(198, 25);
            label6.TabIndex = 0;
            label6.Text = "Programmation(/60)";
            // 
            // txt_Prog
            // 
            txt_Prog.ForeColor = Color.DarkCyan;
            txt_Prog.Location = new Point(255, 392);
            txt_Prog.Name = "txt_Prog";
            txt_Prog.Size = new Size(187, 33);
            txt_Prog.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(51, 440);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 0;
            label7.Text = "Algo(/50)";
            // 
            // txt_Algo
            // 
            txt_Algo.ForeColor = Color.DarkCyan;
            txt_Algo.Location = new Point(255, 440);
            txt_Algo.Name = "txt_Algo";
            txt_Algo.Size = new Size(187, 33);
            txt_Algo.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Cyan;
            label8.Location = new Point(51, 491);
            label8.Name = "label8";
            label8.Size = new Size(177, 25);
            label8.TabIndex = 0;
            label8.Text = "Bureautique(/100)";
            // 
            // txt_Bur
            // 
            txt_Bur.ForeColor = Color.DarkCyan;
            txt_Bur.Location = new Point(255, 488);
            txt_Bur.Name = "txt_Bur";
            txt_Bur.Size = new Size(187, 33);
            txt_Bur.TabIndex = 1;
            // 
            // combo_Sex
            // 
            combo_Sex.BackColor = SystemColors.ActiveCaptionText;
            combo_Sex.FlatStyle = FlatStyle.Popup;
            combo_Sex.ForeColor = Color.DarkCyan;
            combo_Sex.FormattingEnabled = true;
            combo_Sex.Items.AddRange(new object[] { "Masculin", "Feminin" });
            combo_Sex.Location = new Point(151, 172);
            combo_Sex.Name = "combo_Sex";
            combo_Sex.Size = new Size(291, 33);
            combo_Sex.TabIndex = 2;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.ForeColor = Color.Cyan;
            lbl_Message.Location = new Point(12, 667);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(27, 25);
            lbl_Message.TabIndex = 3;
            lbl_Message.Text = "...";
            // 
            // btn_Coter
            // 
            btn_Coter.ForeColor = Color.DarkCyan;
            btn_Coter.Location = new Point(207, 576);
            btn_Coter.Name = "btn_Coter";
            btn_Coter.Size = new Size(119, 42);
            btn_Coter.TabIndex = 4;
            btn_Coter.Text = "Coter";
            btn_Coter.UseVisualStyleBackColor = true;
            btn_Coter.Click += btn_Coter_Click;
            // 
            // Form_Cotation
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(557, 881);
            Controls.Add(btn_Coter);
            Controls.Add(lbl_Message);
            Controls.Add(combo_Sex);
            Controls.Add(txt_Bur);
            Controls.Add(txt_Algo);
            Controls.Add(txt_Prog);
            Controls.Add(label8);
            Controls.Add(txt_Français);
            Controls.Add(label7);
            Controls.Add(txt_Math);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_Adresse);
            Controls.Add(label4);
            Controls.Add(txt_Nom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 128, 0);
            Margin = new Padding(5);
            Name = "Form_Cotation";
            Text = "Form_Cotation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Nom;
        private Label label2;
        private TextBox txt_Adresse;
        private Label label3;
        private Label label4;
        private TextBox txt_Math;
        private Label label5;
        private TextBox txt_Français;
        private Label label6;
        private TextBox txt_Prog;
        private Label label7;
        private TextBox txt_Algo;
        private Label label8;
        private TextBox txt_Bur;
        private ComboBox combo_Sex;
        private Label lbl_Message;
        private Button btn_Coter;
    }
}