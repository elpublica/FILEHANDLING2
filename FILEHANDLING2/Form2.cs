using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//abrir,guardar,eliminar archivos del disco duro, desde c++ existe

namespace FILEHANDLING2
{
    public partial class Form2 : Form
    {
        string path = "", filename = "", fullpath = "";
        bool close = false;
        int ta = 8;
        bool fon = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void save(int r1)
        {
            if (fullpath == "" || r1 == 2)
            {
                SaveFileDialog sfd1 = new SaveFileDialog();
                sfd1.Title = "SAVE MY FILE AS....";
                sfd1.CheckFileExists = false;
                //sfd1.InitialDirectory = @"C:\Documentos\";
                sfd1.InitialDirectory = Environment.CurrentDirectory;

                sfd1.Filter = "Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

                if (sfd1.ShowDialog() == DialogResult.OK)
                {
                    path = Path.GetDirectoryName(sfd1.FileName);//guarda ruta
                    filename = Path.GetFileName(sfd1.FileName);//guarda nombre del archivo
                    fullpath = path + @"\" + filename;

                    //label1.Text = path;
                    //label2.Text = filename;

                    /*var file = File.CreateText(fullpath);
                    file.Close();

                    StreamWriter sw1 = new StreamWriter(fullpath);
                    sw1.WriteLine(richTextBox1.Text);
                    sw1.Close();*/

                    richTextBox1.SaveFile(fullpath, RichTextBoxStreamType.RichText);
                }
            }
            else
            {
                richTextBox1.SaveFile(fullpath, RichTextBoxStreamType.RichText);
                /*var file = File.CreateText(fullpath);
                file.Close();

                StreamWriter sw1 = new StreamWriter(fullpath);
                sw1.WriteLine(richTextBox1.Text);
                sw1.Close();*/
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            save(1);//guardar
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            save(2);//guardar como

        }

        private void Form2_Load(object sender, EventArgs e)// metodo es una funcion que va adentro de una clase
        {
            if(Form1.oper == "OPEN")
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    fullpath = ofd1.FileName;
                    richTextBox1.LoadFile(fullpath, RichTextBoxStreamType.RichText);
                    //utilizar foreach

                   /* List<string> lines = File.ReadAllLines(fullpath).ToList();
                    foreach(string element in lines)
                    {
                       richrichTextBox1.Text += element;
                       richrichTextBox1.Text += Environment.NewLine;
                    }*/

                    
                    //StreamReader sr1 = new StreamReader(fullpath);
                    /*while(!sr1.EndOfStream)
                    {
                        richTextBox1.Text = sr1.ReadLine();
                       //richrichTextBox1.Text += sr1.ReadLine();
                       //richrichTextBox1.Text += Environment.NewLine;
                    }
                    sr1.Close();*/
                }
                else
                {
                    close = true;//cancelar el cuadro de dialogos 
                    //MessageBox.Show("SELECT FILE");
                    //this.Close();
                }
            }

        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            //se ejecuta despues de que termina el constructor
            if(close == true)
            {
                this.Close();
            }
        }

        internal void button3_Click(object sender, EventArgs e)//bold
        {
            int s1 = richTextBox1.SelectionStart;
            int s2 = richTextBox1.SelectionLength;

            if (richTextBox1.SelectionFont.Bold == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Regular);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
            else
            {

                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Bold);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
        }

        internal void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            { 
            richTextBox1.SelectionFont = fontDialog1.Font;
            }
            
                
        }

        internal void button5_Click(object sender, EventArgs e)//italic
        {
            int s1 = richTextBox1.SelectionStart;
            int s2 = richTextBox1.SelectionLength;

            if (richTextBox1.SelectionFont.Italic == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Regular);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
            else
            {

                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Italic);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        internal void button6_Click(object sender, EventArgs e)//underline
        {
            int s1 = richTextBox1.SelectionStart;
            int s2 = richTextBox1.SelectionLength;

            if (richTextBox1.SelectionFont.Underline == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Regular);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
            else
            {
                
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Underline);

                richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectionFont = richTextBox1.Font;
                richTextBox1.Select(s1, s2);
            }
        }

        private void comb(int c)
        {
            
            System.Drawing.FontStyle fontRam = FontStyle.Regular;

            if (richTextBox1.SelectionFont.Bold == true)
            {
                fontRam = FontStyle.Bold;
            }

            if (richTextBox1.SelectionFont.Italic == true)
            {
                fontRam = FontStyle.Italic;
            }

            if (richTextBox1.SelectionFont.Underline == true)
            {
                fontRam = FontStyle.Underline;
            }

           if(c > 7)
           {
               MessageBox.Show("si entra al if");
               richTextBox1.SelectionFont = new Font(richTextBox1.Text, c,fontRam);
               fon = true;
           }
            if(fon == true)
            {
                MessageBox.Show("si entra al if");
                mañ();
                fon = false;
            }
        }
        private void mañ()
        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Bold);
            }

            if (richTextBox1.SelectionFont.Italic == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Italic);
            }

            if (richTextBox1.SelectionFont.Underline == true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Text, ta, FontStyle.Underline);
            }
        }
        internal void button7_Click(object sender, EventArgs e)
        {
            if(comboBox1.Visible == false)
            {
                comboBox1.Visible = true;
            }
            else
            { 
                comboBox1.Visible = false;
            }
        }

        private  void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = comboBox1.SelectedIndex;
            switch (si)
            {
                case 0:
                    ta = 8;
                    comb(8);
                    break;
                case 1:
                    ta = 9;
                    comb(9);
                    break;
                case 2:
                    ta = 10;
                    comb(10);
                    break;
                case 3:
                    ta = 11;
                    comb(11);
                    break;
                case 4:
                    ta = 12;
                    comb(12);
                    break;
                case 5:
                    ta = 14;
                    comb(14);
                    break;
                case 6:
                    ta = 16;
                    comb(16);
                    break;
                case 7:
                    ta = 18;
                    comb(18);
                    break;
                case 8:
                    ta = 20;
                    comb(20);
                    break;
                case 9:
                    ta = 22;
                    comb(22);
                    break;
                case 10:
                    ta = 24;
                    comb(24);
                    break;
                case 11:
                    ta = 26;
                    comb(26);
                    break;
                case 12:
                    ta = 28;
                    comb(28);
                    break;
                case 13:
                    ta = 36;
                    comb(36);
                    break;
                case 14:
                    ta = 48;
                    comb(48);
                    break;
                case 15:
                    ta = 72;
                    comb(72);
                    break;
            }
        }
    }
}
