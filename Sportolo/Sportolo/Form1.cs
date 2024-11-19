using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportolo
{
    public partial class Form1 : Form
    {
        List<Jatekos> lista = new List<Jatekos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnhozad_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("no name","üzenet",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if(txeletkor.TextLength == 0)
            {
                MessageBox.Show("nincs age", "üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txeletkor.Focus();
            }
            else if(Convert.ToInt16(txeletkor.Text)<=6 || Convert.ToInt16(txeletkor.Text) >= 40)
            {
                MessageBox.Show("nem jó eletkor", "üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txeletkor.Clear();
                txeletkor.Focus();
            }
            else
            {
                Jatekos j = new Jatekos();
                j.nev = txnev.Text;
                j.kor = Convert.ToInt16(txeletkor.Text);
                lista.Add(j);
                rtb.Text = rtb.Text+txnev.Text+": "+txeletkor.Text+" éves\n";
                txeletkor.Clear();
                txnev.Clear();
                txnev.Focus();

            }
        }

        private void btnatlagkor_Click(object sender, EventArgs e)
        {
            double atlag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                atlag += lista[i].kor;
            }
            atlag =Math.Round((atlag/lista.Count),2);
            MessageBox.Show("Az átlag életkor "+atlag.ToString());
        }

        private void btnszaksportmen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("sportolok.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0;i < lista.Count; i++)
            {
                sw.WriteLine(lista[i].nev + ";" + lista[i].kor);
            }
            sw.Close();
            fs.Close();
        }

        private void btnletszam_Click(object sender, EventArgs e)
        {
            int gycsap = 0;
            for(int i = 0;i<lista.Count ; i++)
            {
                if (lista[i].kor >=10 && lista[i].kor <= 12)
                {
                    gycsap++;
                }
            }
            MessageBox.Show(gycsap + " darab gyermek van","üzenet",MessageBoxButtons.OK);
        }

        private void btnminage_Click(object sender, EventArgs e)
        {
            var min = lista.Min(j => j.kor);
            MessageBox.Show("legfiatalabb " + min);
        }
       

        private void btnmaxage_Click_1(object sender, EventArgs e)
        {
            var max = lista.Max(j => j.kor);
            MessageBox.Show("legidősebb " + max);
        }
    }
}
