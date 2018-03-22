using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace ISET_2018_Decouverte
{
    public partial class EcranList : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        private const int LB_Lire = 0x0199;
        private const int LB_Ecrire = 0x019A;

        private string nomFichier = "";

        public string NomFichier{ get;set;}

        public EcranList()
        {
            InitializeComponent();
        }
        private void Activer(bool lDetail)
        {
            lbPresonnes.Enabled = !lDetail;
            btnOuvrir.Enabled = btnEnregistre.Enabled = btnAjouter.Enabled = btnSuprimer.Enabled = !lDetail;
            gbDetail.Enabled = lDetail;
            if (lDetail)
            {
                cbQualite.SelectedIndex = 0;
                tbNom.Text = "";
                cbQualite.Focus();
            }
            else lbPresonnes.Focus();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
           int n = lbPresonnes.Items.Add(tbNom.Text + "(" + cbQualite.Text + ")");
            SendMessage(lbPresonnes.Handle, LB_Ecrire, n , lbPresonnes.Items.Count);
            Activer(false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        { Activer(false); }

        private void btnAjouter_Click(object sender, EventArgs e)
        { Activer(true); }

        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            int nItem = lbPresonnes.SelectedIndex;
            if (nItem >= 0)
            {
                int n = SendMessage(lbPresonnes.Handle, LB_Lire, nItem, 0);
                lbPresonnes.Items.RemoveAt(nItem);
                for(int i =0 ; i<lbPresonnes.Items.Count ; i++)
                {
                    int current_item = SendMessage(lbPresonnes.Handle, LB_Lire, i, 0);
                    if (current_item > n) SendMessage(lbPresonnes.Handle, LB_Ecrire, i, current_item-1);
                }

            } 
            else MessageBox.Show("Aucune presonne sélectionée");
            
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            if (dlgEnregistre.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgEnregistre.FileName);
                NomFichier = dlgEnregistre.FileName;
                for (int i=0;i<lbPresonnes.Items.Count; i++)
                {
                    int n =  SendMessage(lbPresonnes.Handle, LB_Lire, i, 0);
                    sw.WriteLine(lbPresonnes.Items[i] + "#" + n);
                } 
                sw.Close();
                lblFichier.Text = NomFichier.Substring(1+nomFichier.LastIndexOf(@"\"));
            }
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if(nomFichier!=" ") dlgOuvrir.FileName = nomFichier;
            //dlgOuvrir.Filter= "Fichiers texte|*.txt |Touts fichiers|*.*";
            dlgOuvrir.Filter = "Touts fichiers|*.*";
            if (dlgOuvrir.ShowDialog() == DialogResult.OK)
            {
                lbPresonnes.Items.Clear();
                nomFichier = dlgOuvrir.FileName;
                StreamReader sr = new StreamReader(nomFichier);
                string lecture;
                while ((lecture = sr.ReadLine()) != null)
                {
                    string[] items = lecture.Split('#');
                    int n = lbPresonnes.Items.Add(items[0]);
                    SendMessage(lbPresonnes.Handle, LB_Ecrire, n, int.Parse(items[1]));
                }
                sr.Close();
                lblFichier.Text = nomFichier.Substring(1+nomFichier.LastIndexOf(@"\"));
            }
        }

        private void lbPresonnes_DoubleClick(object sender, EventArgs e)
        {
            int n = 1 + SendMessage(lbPresonnes.Handle, LB_Lire, lbPresonnes.SelectedIndex, 0);
            if (lbPresonnes.SelectedIndex >= 0) MessageBox.Show(lbPresonnes.Text + "en posistion" + (1 + lbPresonnes.SelectedIndex) + "(tri)," + n + "(encodage)");
        }
    }
}
