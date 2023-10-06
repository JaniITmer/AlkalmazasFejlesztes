using AlkalmazasFejlesztes_projekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlkalmazasFejlesztes_projekt
{
    public partial class VeletlenSzamosOldal : Form
    {
        Random rnd=new Random();
        public VeletlenSzamosOldal()
        {
            InitializeComponent();
            fillNumbers();
            
        }
        private void fillNumbers()
        {
            int counter = 1;

            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Label label = new Label();
                    label.Text = counter.ToString();
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lottoryTable.Controls.Add(label, column, row);
                    counter++;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // vissza gomb
        {
            MainOldal mainOldal = new MainOldal();
            mainOldal.Show();
            this.Hide();
            
            mainOldal.FormClosed += (s, args) => this.Close();
        }
        private int[] veletlenszamok = new int[5];
        private void Veletlengeneralas(object sender, EventArgs e)
          
        {
            for(int i=0; i < 5; i++)
            {
               veletlenszamok.Append(rnd.Next(1, 90));
            }
        }
    }
}



