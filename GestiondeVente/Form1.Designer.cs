namespace GestiondeVente
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.guna2GradientPanel1.Controls.Add(this.guna2ImageButton1);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton1);
            this.guna2GradientPanel1.Controls.Add(this.txt_password);
            this.guna2GradientPanel1.Controls.Add(this.txt_username);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(520, 1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(281, 470);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(92, 286);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(110, 31);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "Login";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txt_password
            // 
            this.txt_password.Animated = true;
            this.txt_password.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_password.BorderRadius = 8;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "password";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.LightCoral;
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(47, 218);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(200, 36);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.Animated = true;
            this.txt_username.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_username.BorderRadius = 8;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "Email";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.LightCoral;
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(47, 148);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(200, 36);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(103, 27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.FillColor = System.Drawing.Color.LightCoral;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-25, 1);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(549, 470);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(263, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(18, 21);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

