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
    public partial class Intermedio : Form
    {
        public Intermedio()
        {
            InitializeComponent();
            LlenarCuadrados();
        }

        Random random = new Random();        
        Label firstClicked = null;
        Label secondClicked = null;

        List<string> iconos = new List<string>()
         {
             "D", "D", "Z", "Z", "%", "%", "(", "(",
             ":", ":", "2", "2", "$", "$", "c", "c",
             "-", "-", "j", "j", ".", ".", "P", "P",
             ")", ")", "*", "*", "+", "+", "`", "`"
         };

        /*string[] iconos = new string[] {
        };*/

       private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)

                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void LlenarCuadrados()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(iconos.Count);
                    iconLabel.Text = iconos[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    //iconos[randomNumber].Remove;
                }
            }
            /* Label label;
             int randomNumber;

             for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
             {
                 if (tableLayoutPanel1.Controls[i] is Label)
                     label = (Label)tableLayoutPanel1.Controls[i];
                 else
                     continue;

                 randomNumber = random.Next(0, iconos.Count);
                 label.Text = iconos[randomNumber];

                 //iconos.RemoveAt(randomNumber);
             }*/
        }
    }
}
