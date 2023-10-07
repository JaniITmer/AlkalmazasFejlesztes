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
        private List<int> nyeroSzamok = new List<int>();
        private Random rnd = new Random();
        private decimal egyenleg = 0;
        public SajatSzamosOldal()
        {
            InitializeComponent();
            fillNumbers();
            richTextBox1.Hide();
            resetButton.Hide();
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
                    label.MouseEnter += Label_MouseEnter;
                    label.MouseLeave += Label_MouseLeave;
                    lottoryTable.Controls.Add(label, column, row);
                    counter++;
                }
            }
            label1.Text = $"Egyenleg: \n{egyenleg} Ft";
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
            else if (!kivalasztottSzamok.Contains(szam) && kivalasztottSzamok.Count == 5)
            {
                MessageBox.Show("Csak 5 számot választhat ki!");
            }
            else 
            {
                kivalasztottSzamok.Remove(szam);
                label.BackColor = Color.PeachPuff;
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int szam = int.Parse(label.Text);

            if (!kivalasztottSzamok.Contains(szam))
            {
                label.BackColor = Color.Yellow;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            int szam = int.Parse(label.Text);

            if (!kivalasztottSzamok.Contains(szam))
            {
                label.BackColor = Color.PeachPuff;
            }
        }

        private void NyeroSzamGeneralas()
        {
            while (nyeroSzamok.Count < 5)
            {
                int szam = rnd.Next(1, 91);

                if (!nyeroSzamok.Contains(szam))
                {
                    nyeroSzamok.Add(szam);
                }
            }
        }

        private void sorsolasButton_Click(object sender, EventArgs e)
        {
            if (nyeroSzamok.Count() != 0)
            {
                nyeroSzamok.Clear();
            }
            NyeroSzamGeneralas();

            if (kivalasztottSzamok.Count() != 5)
            {
                MessageBox.Show($"Válasszon ki még {5 - kivalasztottSzamok.Count()} számot!");
            }
            else
            {
                int talalatok = 0;
                int nyeremeny = 0;

                foreach (int szam in kivalasztottSzamok)
                {
                    if (nyeroSzamok.Contains(szam))
                    {
                        talalatok++;
                    }
                }

                switch (talalatok)
                {
                    case 1:
                        nyeremeny += 0;
                        break;
                    case 2:
                        nyeremeny += 2855;
                        break;
                    case 3:
                        nyeremeny += 21895;
                        break;
                    case 4:
                        nyeremeny += 1576810;
                        break;
                    case 5:
                        nyeremeny += 1785282580;
                        break;
                    default:
                        break;
                }

                egyenleg += nyeremeny;

                nyeroSzamok.Sort();
                kivalasztottSzamok.Sort();

                string nyeroSzamokString = string.Join("   ", nyeroSzamok);
                string kivalasztottSzamokString = string.Join("   ", kivalasztottSzamok);
 
                richTextBox1.Show();
                resetButton.Show();
                sorsolasButton.Hide();

                richTextBox1.Text = $"Találatok száma: {talalatok}\n\n" +
                    $"A nyerő számok: \n{nyeroSzamokString}\n\n" +
                    $"A megtett számok: \n{kivalasztottSzamokString}\n\n" +
                    $"Az Ön nyereménye: \n{nyeremeny.ToString("C0")}";

                label1.Text = $"Egyenleg: \n{egyenleg.ToString("C0")}";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            kivalasztottSzamok.Clear();

            foreach (Control control in lottoryTable.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.PeachPuff;
                }
            }

            richTextBox1.Text = string.Empty;
            richTextBox1.Hide();
            resetButton.Hide();
            sorsolasButton.Show();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
