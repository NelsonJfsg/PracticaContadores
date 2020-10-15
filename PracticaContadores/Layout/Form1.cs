using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaContadores
{


    public partial class Form1 : Form
    {

        //Variables 
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void ButtNewNumber_Click(object sender, EventArgs e)
        {
            if (num > 25)
            {
                MessageBox.Show("Contador maximo a 25.");
            }
            else
            {
                LabelScreen.Text = num.ToString();
                num++;
            }
        }

        private void ButDeleteNumber_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                MessageBox.Show("Contador minimo a 0");
            }
            else
            {
                num--;
                LabelScreen.Text = num.ToString();
            }
            

        }
    }
}
