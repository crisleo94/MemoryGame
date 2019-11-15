namespace MemoryGame
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_BestScores = new System.Windows.Forms.Button();
            this.lbl_PlayerN = new System.Windows.Forms.Label();
            this.rbtn_Insane = new System.Windows.Forms.RadioButton();
            this.rbtn_Medium = new System.Windows.Forms.RadioButton();
            this.rbtn_Facil = new System.Windows.Forms.RadioButton();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.lbl_Player = new System.Windows.Forms.Label();
            this.lbl_TitleHome = new System.Windows.Forms.Label();
            this.pnl_View = new System.Windows.Forms.Panel();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnl_Menu.Controls.Add(this.btn_BestScores);
            this.pnl_Menu.Controls.Add(this.lbl_PlayerN);
            this.pnl_Menu.Controls.Add(this.rbtn_Insane);
            this.pnl_Menu.Controls.Add(this.rbtn_Medium);
            this.pnl_Menu.Controls.Add(this.rbtn_Facil);
            this.pnl_Menu.Controls.Add(this.btn_Close);
            this.pnl_Menu.Controls.Add(this.btn_Restart);
            this.pnl_Menu.Controls.Add(this.lbl_Player);
            this.pnl_Menu.Controls.Add(this.lbl_TitleHome);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(500, 80);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_BestScores
            // 
            this.btn_BestScores.Location = new System.Drawing.Point(8, 8);
            this.btn_BestScores.Name = "btn_BestScores";
            this.btn_BestScores.Size = new System.Drawing.Size(104, 23);
            this.btn_BestScores.TabIndex = 9;
            this.btn_BestScores.Text = "Mejores Jugadores";
            this.btn_BestScores.UseVisualStyleBackColor = true;
            this.btn_BestScores.Click += new System.EventHandler(this.btn_BestScores_Click);
            // 
            // lbl_PlayerN
            // 
            this.lbl_PlayerN.AutoSize = true;
            this.lbl_PlayerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerN.Location = new System.Drawing.Point(80, 56);
            this.lbl_PlayerN.Name = "lbl_PlayerN";
            this.lbl_PlayerN.Size = new System.Drawing.Size(36, 13);
            this.lbl_PlayerN.TabIndex = 8;
            this.lbl_PlayerN.Text = "Player";
            // 
            // rbtn_Insane
            // 
            this.rbtn_Insane.AutoSize = true;
            this.rbtn_Insane.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtn_Insane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Insane.Location = new System.Drawing.Point(448, 48);
            this.rbtn_Insane.Name = "rbtn_Insane";
            this.rbtn_Insane.Size = new System.Drawing.Size(43, 29);
            this.rbtn_Insane.TabIndex = 6;
            this.rbtn_Insane.TabStop = true;
            this.rbtn_Insane.Text = "Insano";
            this.rbtn_Insane.UseVisualStyleBackColor = true;
            this.rbtn_Insane.CheckedChanged += new System.EventHandler(this.rbtn_Checked);
            // 
            // rbtn_Medium
            // 
            this.rbtn_Medium.AutoSize = true;
            this.rbtn_Medium.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtn_Medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Medium.Location = new System.Drawing.Point(376, 48);
            this.rbtn_Medium.Name = "rbtn_Medium";
            this.rbtn_Medium.Size = new System.Drawing.Size(60, 29);
            this.rbtn_Medium.TabIndex = 6;
            this.rbtn_Medium.TabStop = true;
            this.rbtn_Medium.Text = "Intermedio";
            this.rbtn_Medium.UseVisualStyleBackColor = true;
            this.rbtn_Medium.CheckedChanged += new System.EventHandler(this.rbtn_Checked);
            // 
            // rbtn_Facil
            // 
            this.rbtn_Facil.AutoSize = true;
            this.rbtn_Facil.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtn_Facil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Facil.Location = new System.Drawing.Point(328, 48);
            this.rbtn_Facil.Name = "rbtn_Facil";
            this.rbtn_Facil.Size = new System.Drawing.Size(33, 29);
            this.rbtn_Facil.TabIndex = 6;
            this.rbtn_Facil.TabStop = true;
            this.rbtn_Facil.Text = "Fácil";
            this.rbtn_Facil.UseVisualStyleBackColor = true;
            this.rbtn_Facil.CheckedChanged += new System.EventHandler(this.rbtn_Checked);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Close.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Close.Location = new System.Drawing.Point(456, 8);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "O";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Restart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Restart.Location = new System.Drawing.Point(408, 8);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(35, 23);
            this.btn_Restart.TabIndex = 5;
            this.btn_Restart.Text = "P";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player.Location = new System.Drawing.Point(0, 48);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(79, 24);
            this.lbl_Player.TabIndex = 1;
            this.lbl_Player.Text = "Jugador";
            // 
            // lbl_TitleHome
            // 
            this.lbl_TitleHome.AutoSize = true;
            this.lbl_TitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleHome.Location = new System.Drawing.Point(144, 8);
            this.lbl_TitleHome.Name = "lbl_TitleHome";
            this.lbl_TitleHome.Size = new System.Drawing.Size(172, 26);
            this.lbl_TitleHome.TabIndex = 0;
            this.lbl_TitleHome.Text = "Desmemoriados";
            // 
            // pnl_View
            // 
            this.pnl_View.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_View.Location = new System.Drawing.Point(0, 80);
            this.pnl_View.Name = "pnl_View";
            this.pnl_View.Size = new System.Drawing.Size(500, 500);
            this.pnl_View.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.pnl_View);
            this.Controls.Add(this.pnl_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.loadInicio);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_View;
        private System.Windows.Forms.Label lbl_TitleHome;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Label lbl_Player;
        private System.Windows.Forms.RadioButton rbtn_Facil;
        private System.Windows.Forms.Button btn_BestScores;
        private System.Windows.Forms.Label lbl_PlayerN;
        private System.Windows.Forms.RadioButton rbtn_Insane;
        private System.Windows.Forms.RadioButton rbtn_Medium;
    }
}