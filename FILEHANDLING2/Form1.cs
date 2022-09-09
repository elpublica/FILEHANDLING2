using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILEHANDLING2
{
    public partial class Form1 : Form
    {
        public static string oper;
        //superglobal que va a ser acesible cuando yo la llame qie le pertenece a la forma1
                                 //solo puede tener un valor para la instancia 
                                 //nos va permitir accederla desde donde yo quiera, siempre y cuando se el mismo.exe
        bool openclose = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oper = "NEW";
            Form f2 = new Form2();
            f2.TopLevel = false;//rescribiendo los valores
            f2.TopMost = true;//rescribiendo los valores

            panel2.Width = f2.Width;
            panel2.Height = f2.Height;
            //this.Hide();//arreglo de formas f2(1),f3(2),f4(3)
            this.panel2.Controls.Add(f2);
            f2.Show();
            //this.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oper = "OPEN";
            Form f2 = new Form2();//se crean los planos de los valores de default

            f2.TopLevel = false;//rescribiendo los valores
            f2.TopMost = true;//rescribiendo los valores

            panel2.Width = f2.Width;
            panel2.Height = f2.Height;

            this.panel2.Controls.Add(f2);
            f2.Show();//construye//cada vez que lo llames cree un nuevo dinamico 

            //constructor
            //destruye--que deja de existir 
            /*this.Hide();
            f2.ShowDialog();
            this.Show();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          if(openclose)//codigo para desplegar el boton
          {
              panel1.Height += 20;
              if(panel1.Size == panel1.MaximumSize)
              {
                  timer1.Stop();
                  openclose = false;
              }
          }
            else
          {
              panel1.Height -= 20;
              if (panel1.Size == panel1.MinimumSize)
              {
                  timer1.Stop();
                  openclose = true;
              }
          }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.button3.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.button4.PerformClick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.button5.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.button6.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.button7.PerformClick();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
