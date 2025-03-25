namespace TP_Form
{
    partial class TP_Enregistrement
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
            dataGrid = new DataGridView();
            btn_Enregistrer = new Button();
            label1 = new Label();
            txt_Name = new TextBox();
            label2 = new Label();
            txt_Adresse = new TextBox();
            label3 = new Label();
            txt_Contact = new TextBox();
            label4 = new Label();
            combo_Sex = new ComboBox();
            btn_Actualiser = new Button();
            btn_Mod = new Button();
            btn_Supp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(17, 349);
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(480, 265);
            dataGrid.TabIndex = 0;
            dataGrid.CellClick += dataGrid_CellClick;
            // 
            // btn_Enregistrer
            // 
            btn_Enregistrer.ForeColor = Color.DarkCyan;
            btn_Enregistrer.Location = new Point(135, 309);
            btn_Enregistrer.Margin = new Padding(4);
            btn_Enregistrer.Name = "btn_Enregistrer";
            btn_Enregistrer.Size = new Size(116, 32);
            btn_Enregistrer.TabIndex = 1;
            btn_Enregistrer.Text = "Save";
            btn_Enregistrer.UseVisualStyleBackColor = true;
            btn_Enregistrer.Click += btn_Enregistrer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(58, 157);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 3;
            label1.Text = "Sexe";
            // 
            // txt_Name
            // 
            txt_Name.ForeColor = Color.DarkCyan;
            txt_Name.Location = new Point(145, 119);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(281, 29);
            txt_Name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(58, 122);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Nom";
            // 
            // txt_Adresse
            // 
            txt_Adresse.ForeColor = Color.DarkCyan;
            txt_Adresse.Location = new Point(145, 189);
            txt_Adresse.Name = "txt_Adresse";
            txt_Adresse.Size = new Size(281, 29);
            txt_Adresse.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(58, 192);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 3;
            label3.Text = "Adresse";
            // 
            // txt_Contact
            // 
            txt_Contact.ForeColor = Color.DarkCyan;
            txt_Contact.Location = new Point(145, 224);
            txt_Contact.Name = "txt_Contact";
            txt_Contact.Size = new Size(281, 29);
            txt_Contact.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(58, 227);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 3;
            label4.Text = "Contact";
            // 
            // combo_Sex
            // 
            combo_Sex.BackColor = Color.DimGray;
            combo_Sex.FlatStyle = FlatStyle.System;
            combo_Sex.ForeColor = Color.DarkCyan;
            combo_Sex.FormattingEnabled = true;
            combo_Sex.Items.AddRange(new object[] { "Masculin", "Feminin" });
            combo_Sex.Location = new Point(145, 154);
            combo_Sex.Name = "combo_Sex";
            combo_Sex.Size = new Size(281, 29);
            combo_Sex.TabIndex = 4;
            // 
            // btn_Actualiser
            // 
            btn_Actualiser.ForeColor = Color.DarkCyan;
            btn_Actualiser.Location = new Point(17, 309);
            btn_Actualiser.Margin = new Padding(4);
            btn_Actualiser.Name = "btn_Actualiser";
            btn_Actualiser.Size = new Size(110, 32);
            btn_Actualiser.TabIndex = 1;
            btn_Actualiser.Text = "Actualiser";
            btn_Actualiser.UseVisualStyleBackColor = true;
            btn_Actualiser.Click += btn_Actualiser_Click;
            // 
            // btn_Mod
            // 
            btn_Mod.ForeColor = Color.DarkCyan;
            btn_Mod.Location = new Point(259, 309);
            btn_Mod.Margin = new Padding(4);
            btn_Mod.Name = "btn_Mod";
            btn_Mod.Size = new Size(110, 32);
            btn_Mod.TabIndex = 1;
            btn_Mod.Text = "Modifier";
            btn_Mod.UseVisualStyleBackColor = true;
            btn_Mod.Click += btn_Mod_Click;
            // 
            // btn_Supp
            // 
            btn_Supp.ForeColor = Color.DarkCyan;
            btn_Supp.Location = new Point(373, 309);
            btn_Supp.Margin = new Padding(4);
            btn_Supp.Name = "btn_Supp";
            btn_Supp.Size = new Size(124, 32);
            btn_Supp.TabIndex = 1;
            btn_Supp.Text = "Supprimer";
            btn_Supp.UseVisualStyleBackColor = true;
            btn_Supp.Click += btn_Supp_Click_1;
            // 
            // TP_Enregistrement
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(510, 630);
            Controls.Add(combo_Sex);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Contact);
            Controls.Add(txt_Adresse);
            Controls.Add(txt_Name);
            Controls.Add(btn_Actualiser);
            Controls.Add(btn_Supp);
            Controls.Add(btn_Mod);
            Controls.Add(btn_Enregistrer);
            Controls.Add(dataGrid);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 128, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TP_Enregistrement";
            Text = "TP_Enregistrement";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Button btn_Enregistrer;
        private Label label1;
        private TextBox txt_Name;
        private Label label2;
        private TextBox txt_Adresse;
        private Label label3;
        private TextBox txt_Contact;
        private Label label4;
        private ComboBox combo_Sex;
        private Button btn_Actualiser;
        private Button btn_Mod;
        private Button btn_Supp;
    }
}