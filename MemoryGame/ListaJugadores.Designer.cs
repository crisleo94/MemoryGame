namespace MemoryGame
{
    partial class ListaJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaJugadores));
            this.dtgv_List = new System.Windows.Forms.DataGridView();
            this.lbl_TituloLista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_List
            // 
            this.dtgv_List.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgv_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_List.Location = new System.Drawing.Point(32, 120);
            this.dtgv_List.Name = "dtgv_List";
            this.dtgv_List.Size = new System.Drawing.Size(416, 248);
            this.dtgv_List.TabIndex = 0;
            // 
            // lbl_TituloLista
            // 
            this.lbl_TituloLista.AutoSize = true;
            this.lbl_TituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloLista.Location = new System.Drawing.Point(128, 40);
            this.lbl_TituloLista.Name = "lbl_TituloLista";
            this.lbl_TituloLista.Size = new System.Drawing.Size(239, 31);
            this.lbl_TituloLista.TabIndex = 1;
            this.lbl_TituloLista.Text = "Mejores Puntajes";
            // 
            // ListaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_TituloLista);
            this.Controls.Add(this.dtgv_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaJugadores";
            this.Text = "ListaJugadores";
            this.Load += new System.EventHandler(this.CargarLista);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_List;
        private System.Windows.Forms.Label lbl_TituloLista;
    }
}