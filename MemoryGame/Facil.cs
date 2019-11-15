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
    public partial class Facil : Form
    {
        public Facil()
        {
            InitializeComponent();
            // Se inicializa la función para hacer el "llenado" de todas las labels
            LlenarCuadrados();
        }

        // Se determinan de manera global las variables que se usarán
        Random random = new Random();
        Label firstClicked = null;
        Label secondClicked = null;
        Player player = new Player();

        // Se crea la lista con los íconos (fuente webdings) en número par para evitar repeticiones
        List<string> iconos = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        internal Player Player { get => player; set => player = value; }

        private void label_Click(object sender, EventArgs e)
        {
            // Inicialización del timer para controlar el el tiempo que están descubiertas dos labels a la vez
            if (tm_Facil.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si se hace click en un label se evalúa y se "voltea" cambiando el color de la fuente
                if (clickedLabel.ForeColor == Color.Black)
                   
                    return;
                
                // Se mantiene el color de la letra en caso no esté clickeada
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                
                // En caso contario se colorea el segundo click
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                CheckForWinner();
                // Se evalúan los valores de ambos clicks
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    Player.Score += 3;
                    return;
                }
                
                // Timer que mantiene a la vista ambos cliks en caso no sean iguales
                tm_Facil.Start();
            }
        }

        private void tm_Facil_Tick(object sender, EventArgs e)
        {
            // En caso sean iguales se detiene el timer para dejarlas descubiertas y se da valor null a ambas labels
            tm_Facil.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        // Función que permite llenar los cuadrados usando la lista
        private void LlenarCuadrados()
        {            
            foreach (Control control in tlp_Facil.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(iconos.Count);
                    iconLabel.Text = iconos[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    iconos.RemoveAt(randomNumber);
                }
            }
        }

        

        // Verificar si completa o no todos los pares
        private void CheckForWinner()
        {
            foreach (Control control in tlp_Facil.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)                        
                        return;
                }
            }
            player.Wins++;
            MessageBox.Show("Ha completado el puzzle, su puntaje total es: " + player.Score,
                            "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                BD_Connection con = new BD_Connection();
                Player.Score = this.player.Score;
                Player.Wins = this.player.Wins;
                if (con.RegisterScoreWins(player) > 0)
                {
                    MessageBox.Show("Su puntaje se ha guardado, verifique en el listado", "Puntaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
