using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xxoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int Oo = 0;
        int Xx = 0;
        int d = 0;
        int cont = 0;
        bool g = true;
        private void but_Click(object sender, EventArgs e)
        {
            Button f = (Button)sender;
            if (g)
            {
                f.Text = "O";
                g = false;
                cont++;
            }
            else
            {
                f.Text = "X";
                g = true;
                cont++;
            }
            f.Enabled = false;
            outt();
        }
        private void outt()
        {
                 if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text!="" 
                 || b4.Text == b5.Text && b5.Text == b6.Text && b4.Text != ""
                 || b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != ""
                 || b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != ""
                 || b2.Text == b5.Text && b5.Text == b8.Text && b2.Text != ""
                 || b3.Text == b6.Text && b6.Text == b9.Text && b3.Text != ""
                 || b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != ""
                 || b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != "")
            { 
                if (g==true)
                {
                    MessageBox.Show("the winter in X !!!");
                    reset();
                    Xx++;
                    label2.Text = Xx.ToString();
                    g = true;
                    cont = 0;
                }
                else if (g==false|| cont == 9)
                {
                    MessageBox.Show("the winter in O !!!");
                    reset();
                    Oo++;
                    label4.Text = Oo.ToString();
                    g = true;
                    cont = 0;

                }
            }
            else if (b1.Enabled == false &&
     b2.Enabled == false &&
     b3.Enabled == false &&
     b4.Enabled == false &&
     b5.Enabled == false &&
     b6.Enabled == false &&
     b7.Enabled == false &&
     b8.Enabled == false &&
     b9.Enabled == false &&
    
     cont >= 9)
            {
                MessageBox.Show("Draw !!!");
                reset();
                g = true;
                cont = 0;
            }
        }
        private void  reset()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
             Oo = 0;
             Xx = 0;
            d = 0;
             cont = 0;
            label2.Text = ".......";
            label4.Text = ".......";
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
        }
    }
}
