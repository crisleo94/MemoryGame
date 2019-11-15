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
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
        }

        BD_Connection connection = new BD_Connection();
        Player player = new Player();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                player.Name = txt_Name.Text;
                player.Nickname = txt_Nickname.Text;
                player.Pass = txt_Pass.Text;

                if(connection.RegisterPlayer(player) > 0)
                    MessageBox.Show("Registro creado con exito. Sus datos de ingreso son: " +"\n" + 
                        "Nombre: "+player.Name + "\n" + "Contraseña: "+ player.Pass,
                                        "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("El usuario que ha ingresado ya se encuentra registrado, seleccione uno diferente, o inicie sesión",
                    "Erro de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clean();
            }
        }

        private void Clean()
        {
            txt_Name.Text = "";
            txt_Nickname.Text = "";
            txt_Pass.Text = "";
        }
    }
}
