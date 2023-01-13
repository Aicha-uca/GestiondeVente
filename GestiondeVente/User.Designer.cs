namespace GestiondeVente
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Ajouter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Modifier = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Supprimer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mdp = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BorderRadius = 8;
            this.btn_Ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ajouter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ajouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ajouter.Image")));
            this.btn_Ajouter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Ajouter.Location = new System.Drawing.Point(134, 59);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(131, 29);
            this.btn_Ajouter.TabIndex = 0;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BorderRadius = 8;
            this.btn_Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modifier.Image")));
            this.btn_Modifier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Modifier.Location = new System.Drawing.Point(310, 59);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(138, 29);
            this.btn_Modifier.TabIndex = 1;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BorderRadius = 8;
            this.btn_Supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Supprimer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Supprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Supprimer.Image")));
            this.btn_Supprimer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Supprimer.Location = new System.Drawing.Point(494, 59);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(147, 29);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom";
            // 
            // txt_nom
            // 
            this.txt_nom.BorderRadius = 8;
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.DefaultText = "";
            this.txt_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nom.FillColor = System.Drawing.SystemColors.Control;
            this.txt_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nom.Location = new System.Drawing.Point(191, 187);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.PlaceholderText = "";
            this.txt_nom.SelectedText = "";
            this.txt_nom.Size = new System.Drawing.Size(128, 27);
            this.txt_nom.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mot de passe";
            // 
            // txt_mdp
            // 
            this.txt_mdp.BorderRadius = 8;
            this.txt_mdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mdp.DefaultText = "";
            this.txt_mdp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mdp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mdp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mdp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mdp.FillColor = System.Drawing.SystemColors.Control;
            this.txt_mdp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mdp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mdp.Location = new System.Drawing.Point(191, 245);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '\0';
            this.txt_mdp.PlaceholderText = "";
            this.txt_mdp.SelectedText = "";
            this.txt_mdp.Size = new System.Drawing.Size(128, 27);
            this.txt_mdp.TabIndex = 16;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(403, 140);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(406, 208);
            this.guna2DataGridView1.TabIndex = 17;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(867, 720);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_Ajouter;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Modifier;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Supprimer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_mdp;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}