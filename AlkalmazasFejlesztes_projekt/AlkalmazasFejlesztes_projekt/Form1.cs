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
    public partial class MainOldal : Form
    {
        public MainOldal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Main page véletlenszerű gomb
        {
            
            VeletlenSzamosOldal veletlenSzamos = new VeletlenSzamosOldal();
            veletlenSzamos.Show();
            this.Hide();

            
            veletlenSzamos.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Main page sajatszámos gomb
        {
            
            SajatSzamosOldal sajatSzamos = new SajatSzamosOldal();
            sajatSzamos.Show();
            this.Hide();
            
            sajatSzamos.FormClosed += (s, args) => this.Close();

        }

        private void button3_Click(object sender, EventArgs e) //Main page kilépő gomb
        {
            
            Kilepo kilepo = new Kilepo();
            kilepo.Show();
            this.Hide();
            
            kilepo.FormClosed += (s, args) => this.Close();
        }
    }
}
