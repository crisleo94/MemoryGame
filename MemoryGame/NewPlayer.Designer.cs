namespace MemoryGame
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Nickname = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_NewPTitle = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Nickname = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(48, 64);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Nombre";
            // 
            // lbl_Nickname
            // 
            this.lbl_Nickname.AutoSize = true;
            this.lbl_Nickname.Location = new System.Drawing.Point(48, 112);
            this.lbl_Nickname.Name = "lbl_Nickname";
            this.lbl_Nickname.Size = new System.Drawing.Size(53, 13);
            this.lbl_Nickname.TabIndex = 1;
            this.lbl_Nickname.Text = "nickname";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(48, 160);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_NewPTitle
            // 
            this.lbl_NewPTitle.AutoSize = true;
            this.lbl_NewPTitle.Location = new System.Drawing.Point(80, 16);
            this.lbl_NewPTitle.Name = "lbl_NewPTitle";
            this.lbl_NewPTitle.Size = new System.Drawing.Size(132, 13);
            this.lbl_NewPTitle.TabIndex = 3;
            this.lbl_NewPTitle.Text = "Registro de nuevo jugador";
            this.lbl_NewPTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(128, 64);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Nickname
            // 
            this.txt_Nickname.Location = new System.Drawing.Point(128, 112);
            this.txt_Nickname.Name = "txt_Nickname";
            this.txt_Nickname.Size = new System.Drawing.Size(100, 20);
            this.txt_Nickname.TabIndex = 5;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(128, 160);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '•';
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 6;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(56, 200);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(176, 40);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Registrar";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Back.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Back.Location = new System.Drawing.Point(8, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(35, 23);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "f";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Nickname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_NewPTitle);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Nickname);
            this.Controls.Add(this.lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Nickname;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_NewPTitle;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Nickname;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Back;
    }
}