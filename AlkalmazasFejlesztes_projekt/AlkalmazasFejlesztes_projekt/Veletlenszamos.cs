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
        private Random rnd = new Random();
        private List<int> randomNumbers = new List<int>();
        private List<int> nyeroSzamok = new List<int>();
        private decimal egyenleg = 0;
        

        public VeletlenSzamosOldal()
        {
            InitializeComponent();
            fillNumbers();
            richTextBox1.Hide();
            NyeroSzamGeneralas();

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
            label1.Text = $"Egyenleg: \n{egyenleg} Ft";
        }
        
        private void button1_Click_1(object sender, EventArgs e) // vissza gomb
        {
            MainOldal mainOldal = new MainOldal();
            mainOldal.Show();
            this.Hide();

            mainOldal.FormClosed += (s, args) => this.Close();
        }



        private void Veletlengeneralas(object sender, EventArgs e)

        {

            randomNumbers.Clear();
            foreach (Control control in lottoryTable.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.PeachPuff;
                }
            }
          
           
            //véletlen számok generálása
            while(randomNumbers.Count!=5)
            {
                int randomSzam = rnd.Next(1, 91); // 1-től 90-ig generál véletlen számot

                if (!randomNumbers.Contains(randomSzam))
                {
                    randomNumbers.Add(randomSzam);
                }
                    

            }

            //Színek változtatása a táblában a random számokból
            foreach (Control control in lottoryTable.Controls)
            {
                if (control is Label label1 && label1.Text == randomNumbers[0].ToString())
                {
                    label1.BackColor = Color.Red;
                }
                if (control is Label label2 && label2.Text == randomNumbers[1].ToString())
                {
                    label2.BackColor = Color.Red;
                }
                if (control is Label label3 && label3.Text == randomNumbers[2].ToString())
                {
                    label3.BackColor = Color.Red;
                }
                if (control is Label label4 && label4.Text == randomNumbers[3].ToString())
                {
                    label4.BackColor = Color.Red;
                }
                if (control is Label label5 && label5.Text == randomNumbers[4].ToString())
                {
                    label5.BackColor = Color.Red;
                }

            }









        }



       

        private void SorsolasButton_Click(object sender, EventArgs e)
        {

            if (nyeroSzamok.Count() != 0)
            {
                nyeroSzamok.Clear();
            }

            if (randomNumbers.Count() == 0)
                {
                    MessageBox.Show($"Kattintson a Random számok kérése gombra !");
                    randomSzamok.Show();
                }
            
            

            else
            {
                int talalatok = 0;
                int nyeremeny = 0;

                foreach (int szam in randomNumbers)
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
                randomNumbers.Sort();

                string nyeroSzamokString = string.Join("   ", nyeroSzamok);
                string kivalasztottSzamokString = string.Join("   ", randomNumbers);
                if (randomNumbers.Count == 5)
                {
                    randomSzamok.Hide();
                    richTextBox1.Show();
                }

                SorsolasButton.Hide();

                richTextBox1.Text = $"Találatok száma: {talalatok}\n\n" +
                    $"A nyerő számok: \n{nyeroSzamokString}\n\n" +
                    $"A megtett számok: \n{kivalasztottSzamokString}\n\n" +
                    $"Az Ön nyereménye: \n{nyeremeny.ToString("C0")}";

                label1.Text = $"Egyenleg: \n{egyenleg.ToString("C0")}";


            }
            
        }
    }
}



