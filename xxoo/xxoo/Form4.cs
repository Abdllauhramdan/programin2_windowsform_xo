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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int Oo = 0;
        int Xx = 0;
        int cont = 0;
        bool g = true;
        private void button13_Click(object sender, EventArgs e)
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
          if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == button4.Text && button1.Text != "" && button1.Enabled ==false  ||
              button5.Text == button6.Text && button6.Text == button7.Text && button7.Text == button8.Text && button5.Text != "" && button5.Enabled == false ||
              button9.Text == button10.Text && button10.Text == button11.Text && button11.Text == button12.Text && button9.Text != "" && button9.Enabled == false ||
              button13.Text == button14.Text && button14.Text == button15.Text && button15.Text == button16.Text && button13.Text != "" && button13.Enabled == false ||
              button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == button13.Text && button1.Text != "" && button1.Enabled == false ||
              button2.Text == button6.Text && button6.Text == button10.Text && button10.Text == button14.Text && button2.Text != "" && button2.Enabled == false ||
              button3.Text == button7.Text && button7.Text == button11.Text && button11.Text == button15.Text && button3.Text != "" && button3.Enabled == false ||
              button4.Text == button8.Text && button8.Text == button12.Text && button12.Text == button16.Text && button4.Text != "" && button4.Enabled == false||
              button4.Text == button7.Text && button7.Text == button10.Text && button10.Text == button13.Text && button4.Text != "" && button4.Enabled == false ||
              button1.Text == button6.Text && button6.Text == button11.Text && button11.Text == button16.Text && button1.Text != "" && button1.Enabled == false )
            {
                if (g == true)
                {
                    MessageBox.Show("the winter in X !!!");
                    reset();
                    Xx++;
                    label2.Text = Xx.ToString();
                    g = true;
                    cont = 0;
                }
                else if (g == false )
                {
                    MessageBox.Show("the winter in O !!!");
                    reset();
                    Oo++;
                    label4.Text = Oo.ToString();
                    g = true;
                    cont = 0;
                }

            }
            else if (button1.Enabled == false &&
            button2.Enabled == false &&
            button3.Enabled == false &&
            button4.Enabled == false &&
            button5.Enabled == false &&
            button6.Enabled == false &&
            button7.Enabled == false &&
            button8.Enabled == false &&
            button9.Enabled == false &&
            button10.Enabled == false &&
            button11.Enabled == false &&
            button12.Enabled == false &&
            button13.Enabled == false &&
            button14.Enabled == false &&
            button15.Enabled == false &&
            button16.Enabled == false &&
            cont >= 16)
            {
                MessageBox.Show("Draw !!!");
                reset();
                g = true;
                cont = 0;
            }
        }

        private void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reset();
            Oo = 0;
            Xx = 0;
            cont = 0;
            label2.Text = ".......";
            label4.Text = ".......";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
           
        }
    }
}
