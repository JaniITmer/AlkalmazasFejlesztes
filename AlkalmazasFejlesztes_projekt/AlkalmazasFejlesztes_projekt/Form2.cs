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
        public SajatSzamosOldal()
        {
            InitializeComponent();
        }

        private void lottoryTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void randomSzamok_Click(object sender, EventArgs e) //random szamok gomb
        {

        }

        private void button1_Click(object sender, EventArgs e) //vissza gomb
        {
            this.Close();
            MainOldal mainOldal = new MainOldal();
            mainOldal.Show();
        }
    }
}
