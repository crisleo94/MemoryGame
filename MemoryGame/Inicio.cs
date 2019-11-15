using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        Player player = new Player();

        internal Player Player { get => player; set => player = value; }

        public void OpenDif(object formHijo)
        {
            if (this.pnl_View.Controls.Count > 0)
                this.pnl_View.Controls.RemoveAt(0);
            Form hijo = formHijo as Form;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            this.pnl_View.Controls.Add(hijo);
            hijo.Show();
        }        

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Desea reiniciar?", "Reinicio", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (rbtn_Facil.Checked)
                {                    
                    Facil facil = new Facil();
                    facil.Player = this.Player;
                    OpenDif(facil);
                }
                else if (rbtn_Medium.Checked)
                {
                    Intermedio intermedio = new Intermedio();
                    OpenDif(intermedio);
                }
                else if(rbtn_Insane.Checked)
                {
                    Insano insano = new Insano();
                    OpenDif(insano);
                }                
            }            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Está seguro que desea salir del juego", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rbtn_Checked(object sender, EventArgs e)
        {
            if (rbtn_Facil.Checked)
            {
                DialogResult dial = MessageBox.Show("¿Jugar modo fácil?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dial == DialogResult.Yes)
                {
                    Facil facil = new Facil();
                    facil.Player = this.Player;
                    OpenDif(facil);
                }
            }
            else if (rbtn_Medium.Checked)
            {
                DialogResult dial = MessageBox.Show("¿Jugar intermedio?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dial == DialogResult.Yes)
                {
                    Intermedio intermedio = new Intermedio();
                    OpenDif(intermedio);
                }
            }
            else if (rbtn_Insane.Checked)
            {
                DialogResult dial = MessageBox.Show("¿Estás Seguro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dial == DialogResult.Yes)
                {
                    Insano insano = new Insano();
                    OpenDif(insano);
                }
            }
        }

        private void loadInicio(object sender, EventArgs e)
        {
            lbl_PlayerN.Text = player.Nickname;
        }

        private void btn_BestScores_Click(object sender, EventArgs e)
        {
            ListaJugadores list = new ListaJugadores();
            list.Player = this.Player;
            OpenDif(list);
        }
    }
}
