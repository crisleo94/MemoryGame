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
    public partial class ListaJugadores : Form
    {
        public ListaJugadores()
        {
            InitializeComponent();
        }

        Player player = new Player();

        internal Player Player { get => player; set => player = value; }

        private void CargarLista(object sender, EventArgs e)
        {
            try
            {
                BD_Connection con = new BD_Connection();
                var listarJugadores = con.RecuperarUsers();
                DataTable tbt = new DataTable();
                tbt.Columns.Add("Usuario");
                tbt.Columns.Add("Puntaje");
                tbt.Columns.Add("Partidas Ganadas");
                DataRow row = tbt.NewRow();
                foreach (var player in listarJugadores)
                {
                    row = tbt.NewRow();
                    row["Usuario"] = player.Nickname;
                    row["Puntaje"] = player.Score;
                    row["Partidas Ganadas"] = player.Wins;

                    tbt.Rows.Add(row);
                }

                dtgv_List.DataSource = tbt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
