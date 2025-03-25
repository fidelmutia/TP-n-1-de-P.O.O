namespace TP_Form
{
    partial class Form_Calculatrice
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
            label1 = new Label();
            txt_Nbre1 = new TextBox();
            label2 = new Label();
            txt_Nbre2 = new TextBox();
            label3 = new Label();
            txt_Rep = new TextBox();
            lbl_Rep = new Label();
            btn_Calcul = new Button();
            radio_Sum = new RadioButton();
            radio_Sub = new RadioButton();
            radio_Mult = new RadioButton();
            radio_Div = new RadioButton();
            lbl_message = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 40);
            label1.TabIndex = 0;
            label1.Text = "CALCULATRICE";
            // 
            // txt_Nbre1
            // 
            txt_Nbre1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Nbre1.ForeColor = Color.DarkCyan;
            txt_Nbre1.Location = new Point(135, 124);
            txt_Nbre1.Multiline = true;
            txt_Nbre1.Name = "txt_Nbre1";
            txt_Nbre1.RightToLeft = RightToLeft.No;
            txt_Nbre1.Size = new Size(220, 34);
            txt_Nbre1.TabIndex = 1;
            txt_Nbre1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(199, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre1";
            // 
            // txt_Nbre2
            // 
            txt_Nbre2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Nbre2.ForeColor = Color.DarkCyan;
            txt_Nbre2.Location = new Point(135, 198);
            txt_Nbre2.Multiline = true;
            txt_Nbre2.Name = "txt_Nbre2";
            txt_Nbre2.RightToLeft = RightToLeft.No;
            txt_Nbre2.Size = new Size(220, 34);
            txt_Nbre2.TabIndex = 1;
            txt_Nbre2.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(199, 170);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre2";
            // 
            // txt_Rep
            // 
            txt_Rep.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Rep.ForeColor = Color.DarkCyan;
            txt_Rep.Location = new Point(135, 480);
            txt_Rep.Multiline = true;
            txt_Rep.Name = "txt_Rep";
            txt_Rep.ReadOnly = true;
            txt_Rep.RightToLeft = RightToLeft.No;
            txt_Rep.Size = new Size(220, 34);
            txt_Rep.TabIndex = 1;
            txt_Rep.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Rep
            // 
            lbl_Rep.AutoSize = true;
            lbl_Rep.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Rep.ForeColor = Color.Cyan;
            lbl_Rep.Location = new Point(199, 452);
            lbl_Rep.Name = "lbl_Rep";
            lbl_Rep.Size = new Size(88, 25);
            lbl_Rep.TabIndex = 2;
            lbl_Rep.Text = "Reponse";
            // 
            // btn_Calcul
            // 
            btn_Calcul.BackColor = Color.FromArgb(0, 192, 192);
            btn_Calcul.FlatStyle = FlatStyle.System;
            btn_Calcul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcul.ForeColor = Color.DarkCyan;
            btn_Calcul.Location = new Point(177, 398);
            btn_Calcul.Name = "btn_Calcul";
            btn_Calcul.Size = new Size(131, 32);
            btn_Calcul.TabIndex = 3;
            btn_Calcul.Text = "Calculer";
            btn_Calcul.UseVisualStyleBackColor = false;
            btn_Calcul.Click += btn_Calcul_Click;
            // 
            // radio_Sum
            // 
            radio_Sum.AutoSize = true;
            radio_Sum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radio_Sum.ForeColor = Color.Cyan;
            radio_Sum.Location = new Point(225, 238);
            radio_Sum.Name = "radio_Sum";
            radio_Sum.Size = new Size(46, 34);
            radio_Sum.TabIndex = 4;
            radio_Sum.TabStop = true;
            radio_Sum.Text = "+";
            radio_Sum.UseVisualStyleBackColor = true;
            // 
            // radio_Sub
            // 
            radio_Sub.AutoSize = true;
            radio_Sub.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radio_Sub.ForeColor = Color.Cyan;
            radio_Sub.Location = new Point(225, 278);
            radio_Sub.Name = "radio_Sub";
            radio_Sub.Size = new Size(39, 34);
            radio_Sub.TabIndex = 4;
            radio_Sub.TabStop = true;
            radio_Sub.Text = "-";
            radio_Sub.UseVisualStyleBackColor = true;
            // 
            // radio_Mult
            // 
            radio_Mult.AutoSize = true;
            radio_Mult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radio_Mult.ForeColor = Color.Cyan;
            radio_Mult.Location = new Point(225, 318);
            radio_Mult.Name = "radio_Mult";
            radio_Mult.Size = new Size(41, 34);
            radio_Mult.TabIndex = 4;
            radio_Mult.TabStop = true;
            radio_Mult.Text = "*";
            radio_Mult.UseVisualStyleBackColor = true;
            // 
            // radio_Div
            // 
            radio_Div.AutoSize = true;
            radio_Div.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            radio_Div.ForeColor = Color.Cyan;
            radio_Div.Location = new Point(226, 358);
            radio_Div.Name = "radio_Div";
            radio_Div.Size = new Size(40, 34);
            radio_Div.TabIndex = 4;
            radio_Div.TabStop = true;
            radio_Div.Text = "/";
            radio_Div.UseVisualStyleBackColor = true;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_message.ForeColor = Color.Cyan;
            lbl_message.Location = new Point(226, 534);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(22, 21);
            lbl_message.TabIndex = 5;
            lbl_message.Text = "...";
            // 
            // Form_Calculatrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(520, 568);
            Controls.Add(lbl_message);
            Controls.Add(radio_Div);
            Controls.Add(radio_Mult);
            Controls.Add(radio_Sub);
            Controls.Add(radio_Sum);
            Controls.Add(btn_Calcul);
            Controls.Add(lbl_Rep);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Rep);
            Controls.Add(txt_Nbre2);
            Controls.Add(txt_Nbre1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 128, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Calculatrice";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Nbre1;
        private Label label2;
        private TextBox txt_Nbre2;
        private Label label3;
        private TextBox txt_Rep;
        private Label lbl_Rep;
        private Button btn_Calcul;
        private RadioButton radio_Sum;
        private RadioButton radio_Sub;
        private RadioButton radio_Mult;
        private RadioButton radio_Div;
        private Label lbl_message;
    }
}
