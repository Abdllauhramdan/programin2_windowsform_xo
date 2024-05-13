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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int Oo = 0;
        int Xx = 0;
        int cont = 1;
        bool g = true;
        private void but_Click(object sender, EventArgs e)
        {
            Button f = (Button)sender;
            f.Text = "O";
            f.Enabled = false;
            g = false;
            outt();
            cont += 2;
            if (cont<=10 && (
            button1.Enabled == true ||
            button2.Enabled == true ||
            button3.Enabled == true ||
            button4.Enabled == true ||
            button5.Enabled == true ||
            button6.Enabled == true ||
            button7.Enabled == true ||
            button8.Enabled == true ||
            button9.Enabled == true ))

            {
                put();
            }
            outt();
        }
        private void put()
        {
       
            bool v = true;
            if (button1.Text == button2.Text && button1.Text != "" && button3.Enabled == true)
            {
                button3.Text = "X";
                button3.Enabled = false;
                v = false;
                g = true;
            }
            else if (button4.Text == button5.Text && button4.Text != "" && button6.Enabled == true)
            {
                button6.Text = "X";
                button6.Enabled = false;
                v = false;
                g = true;
            }
            else if (button7.Text ==  button8.Text && button7.Text != "" && button9.Enabled == true)
            {
                button9.Text = "X";
                button9.Enabled = false;
                v = false;
                g = true;
            }
            else if (button1.Text ==  button4.Text && button1.Text != "" && button7.Enabled == true)
            {
                button7.Text = "X";
                button7.Enabled = false;
                v = false;
                g = true;
            }
            else if (button2.Text ==  button5.Text && button2.Text != "" && button8.Enabled == true)
            {
                button8.Text = "X";
                button8.Enabled = false;
                v = false;
                g = true;
            }
            else if (button3.Text ==  button6.Text && button3.Text != "" && button9.Enabled == true)
            {
                button9.Text = "X";
                button9.Enabled = false;
                v = false;
                g = true;
            }
            else if (button3.Text ==  button2.Text && button3.Text != "" && button1.Enabled == true)
            {
                button1.Text = "X";
                button1.Enabled = false;
                v = false;
                g = true;
            }
            else if (button6.Text == button5.Text && button6.Text != "" && button4.Enabled == true)
            {
                button4.Text = "X";
                button4.Enabled = false;
                v = false;
                g = true;
            }
            else if (button9.Text ==  button8.Text && button9.Text != "" && button7.Enabled == true)
            {
                button7.Text = "X";
                button7.Enabled = false;
                v = false;
                g = true;
            }
            else if (button7.Text ==  button4.Text && button7.Text != "" && button1.Enabled == true)
            {
                button1.Text = "X";
                button1.Enabled = false;
                v = false;
                g = true;
            }
            else if (button8.Text ==  button5.Text && button8.Text != "" && button2.Enabled == true)
            {
                button2.Text = "X";
                button2.Enabled = false;
                v = false;
                g = true;
            }
            else if (button9.Text ==  button6.Text && button9.Text != "" && button3.Enabled == true)
            {
                button3.Text = "X";
                button3.Enabled = false;
                v = false;
                g = true;
            }
            else if (button3.Text ==  button5.Text && button3.Text != "" && button7.Enabled == true)
            {
                button7.Text = "X";
                button7.Enabled = false;
                v = false;
                g = true;
            }
            else if (button7.Text ==  button5.Text && button7.Text !="" && button3.Enabled == true)
            {
                button3.Text = "X";
                button3.Enabled = false;
                v = false;
                g = true;
            }
            else if (button1.Text == button5.Text && button1.Text !=""  && button9.Enabled == true)
            {
                button9.Text = "X";
                button9.Enabled = false;
                v = false;
                g = true;
            }
            else if (button9.Text ==  button5.Text && button9.Text != "" && button1.Enabled == true)
            {
                button1.Text = "X";
                button1.Enabled = false;
                v = false;
                g = true;
            }

       
            else
            {

                while (v)
                {
                    Random x = new Random();
                    int y = x.Next(1, 10);
                    switch (y)
                    {

                        case 1:
                            if (button1.Text == "" && button1.Enabled == true)
                            {
                                button1.Text = "X";
                                button1.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 2:
                            if (button2.Text == "" && button2.Enabled == true)
                            {
                                button2.Text = "X";
                                button2.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 3:
                            if (button3.Text == "" && button3.Enabled == true)
                            {
                                button3.Text = "X";
                                button3.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 4:
                            if (button4.Text == "" && button4.Enabled == true)
                            {
                                button4.Text = "X";
                                button4.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 5:
                            if (button5.Text == "" && button5.Enabled == true)
                            {
                                button5.Text = "X";
                                button5.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 6:
                            if (button6.Text == "" && button6.Enabled == true)
                            {
                                button6.Text = "X";
                                button6.Enabled = false;
                                v = false;
                                g = true;
                            }

                            break;
                        case 7:
                            if (button7.Text == "" && button7.Enabled == true)
                            {
                                button7.Text = "X";
                                button7.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 8:
                            if (button8.Text == "" && button8.Enabled == true)
                            {
                                button8.Text = "X";
                                button8.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        case 9:
                            if (button9.Text == "" && button9.Enabled == true)
                            {
                                button9.Text = "X";
                                button9.Enabled = false;
                                v = false;
                                g = true;
                            }
                            break;
                        default:
                            MessageBox.Show("erorr");
                            break;
                    }
                }
            }
        }

        private void outt()
        {
           if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != ""
            || button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != ""
            || button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != ""
            || button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != ""
            || button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != ""
            || button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != ""
            || button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != ""
            || button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
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
            else if (button1.Enabled == false&&
            button2.Enabled == false&&
            button3.Enabled == false&&
            button4.Enabled == false&&
            button5.Enabled == false&&
            button6.Enabled == false&&
            button7.Enabled == false&&
            button8.Enabled == false&&
            button9.Enabled == false&&
            cont>=9 )
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

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            put();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Oo = 0;
            Xx = 0;
            label4.Text = ".....";
            label2.Text = ".....";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            reset();
            g = true;
            cont = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Close();
            this.Close();
        }
    }
}
