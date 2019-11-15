using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MemoryGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BD_Connection connection = new BD_Connection();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Start(txt_Name.Text, txt_Pass.Text);
        }

        private void Start(string name, string pass)
        {            
            Player player = connection.RecuperarUser(name, pass);
            if(player == null)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clean();
            }
            else
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Player = player;
                inicio.Show();                
            }            
            /*try
            {
                connection.Connect();
                connection.Command1 = new SqlCommand("select * from Player where " +
                    "player_name = @player_name and pass = @pass", connection.Connection1);
                connection.Command1.Parameters.AddWithValue("@player_name", name);
                connection.Command1.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter sqlData = new SqlDataAdapter(connection.Command1);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                Player player = new Player();


                if (dt.Rows.Count > 0)
                {                    
                    this.Hide();
                    if (dt.Rows[0][0].ToString() == name && dt.Rows[0][2].ToString() == pass)
                    {
                        Inicio inicio = new Inicio(dt.Rows[0][1].ToString());
                        inicio.Show();
                    }

                }
                else {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clean();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     */
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPlayer newPlayer = new NewPlayer();
            newPlayer.Show();
        }

        private void Clean()
        {
            txt_Name.Text = "";
            txt_Pass.Text = "";
        }
    }
}
