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
    public partial class SajatSzamosOldal : Form
    {
        private List<int> kivalasztottSzamok = new List<int>();
        public SajatSzamosOldal()
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
                    label.Click += Label_Click;
                    lottoryTable.Controls.Add(label, column, row);
                    counter++;
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            int szam = int.Parse(label.Text);

            if (!kivalasztottSzamok.Contains(szam) && kivalasztottSzamok.Count < 5)
            {
                kivalasztottSzamok.Add(szam);
                label.BackColor = Color.Orange;
            }
            else
            {
                kivalasztottSzamok.Remove(szam);
                label.BackColor = Color.PeachPuff;
            }
        }

        private void lottoryTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void randomSzamok_Click(object sender, EventArgs e) //random szamok gomb
        {

        }

        private void button1_Click(object sender, EventArgs e) //vissza gomb
        {
            MainOldal mainoldal = new MainOldal();
            mainoldal.Show();
            this.Hide();
            
            mainoldal.FormClosed += (s, args) => this.Close();
        }
    }
}
