namespace MemoryGame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.pb_Brain = new System.Windows.Forms.PictureBox();
            this.pb_Brain2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Brain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Brain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(104, 136);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(176, 40);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Iniciar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(184, 96);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '•';
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 11;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(184, 48);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(104, 96);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_Pass.TabIndex = 9;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(104, 48);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 13);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Nombre";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(112, 216);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(160, 23);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.Text = "Registrar Nuevo Jugador";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // pb_Brain
            // 
            this.pb_Brain.Image = global::MemoryGame.Properties.Resources.desmemoriados_brain;
            this.pb_Brain.Location = new System.Drawing.Point(0, 192);
            this.pb_Brain.Name = "pb_Brain";
            this.pb_Brain.Size = new System.Drawing.Size(88, 72);
            this.pb_Brain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Brain.TabIndex = 14;
            this.pb_Brain.TabStop = false;
            // 
            // pb_Brain2
            // 
            this.pb_Brain2.Image = global::MemoryGame.Properties.Resources.desmemoriados_brain;
            this.pb_Brain2.Location = new System.Drawing.Point(296, 192);
            this.pb_Brain2.Name = "pb_Brain2";
            this.pb_Brain2.Size = new System.Drawing.Size(88, 72);
            this.pb_Brain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Brain2.TabIndex = 14;
            this.pb_Brain2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources.desmemoriados_brain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MemoryGame.Properties.Resources.desmemoriados_brain;
            this.pictureBox2.Location = new System.Drawing.Point(296, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Brain2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_Brain);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Brain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Brain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.PictureBox pb_Brain;
        private System.Windows.Forms.PictureBox pb_Brain2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}