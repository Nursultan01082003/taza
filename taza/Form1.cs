using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace taza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\USER\Desktop\nur3.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet as Excel.Worksheet;
            Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            Qaraqalpaq = new string[rowCount];
            english= new string[rowCount];
            
                for (int i = 1; i < rowCount; i++)
                {
                    Qaraqalpaq[i] = Convert.ToString(xlRange.Cells[i, 1].Value);
                    english[i] = Convert.ToString(xlRange.Cells[i, 2].Value);
                }
            
        }
        string[] Qaraqalpaq;
        string[] english;

        int sum = 0,duris=0;
        Random rnd = new Random();
        private void ozgertiw()
        {
            timer1.Start();
            baslawToolStripMenuItem.Enabled = false;
            duris = 0;
            sekund = 60;
            label1.Text = "01:00";
        }
        private void QR_manis()
        {
            sum = rnd.Next(1,Qaraqalpaq.Length);
            joqari.Text = Qaraqalpaq[sum];
            jaziw.Text = "";
        }
        private void EN_manis()
        {
            sum = rnd.Next(1,Qaraqalpaq.Length);
            joqari.Text = english[sum];
            jaziw.Text = "";
        }
        private void baslawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QR_manis();
            timer1.Start();
            baslawToolStripMenuItem.Enabled = false;
            duris = 0;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tekseriw();
           
        }
        private void tekseriw()
        {
                if (jaziw.Text == english[sum]&&jaziw.Text!=joqari.Text)
                {
                duris++;
                   QR_manis();
                }
                if (jaziw.Text == Qaraqalpaq[sum] && jaziw.Text != joqari.Text)
                {
                duris++;
                    EN_manis();
                }
        }
        private void sdfToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            QR_manis();
           ozgertiw();

        }
        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EN_manis();
            ozgertiw();

        }
        int sekund=60,minut=3;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (minut < 0)
            {
                panel1.Visible = false;
                timer2.Stop();
                minut = 3;
                joqari.Text = "";
                jaziw.Text = "";
                label1.Text = "01:00";
                sekund = 60;
                baslawToolStripMenuItem.Enabled = true;

            }
            else
            {
                minut--;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sekund > 0)
            {
                sekund--;
                if (sekund < 10)
                    label1.Text = "00:0" + sekund;
                else
                    label1.Text = "00:" + sekund;
            }
            else
            {
                timer1.Stop();
                panel1.Visible = true;
                label2.Text = "Oyin juwmaqlandi\n Siz " + duris+" so'zdi duris taptin'iz";
                timer2.Start();

            }


        }
    }
}
