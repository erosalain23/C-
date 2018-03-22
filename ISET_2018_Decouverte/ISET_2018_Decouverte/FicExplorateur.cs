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

namespace ISET_2018_Decouverte
{
    public partial class EcranExplorateur : Form
    {
        private TreeNode NoeudRacine;
        public EcranExplorateur()
        {
            InitializeComponent();
            slMessage.Text = "";
            LireDisque();
        }

        private string NomFichier(string nf)
        { return nf.Substring(1 + nf.LastIndexOf('\\')); }
        private void tsQuitter_Click(object sender, EventArgs e)
        { Close(); }
        private void tsPetitesIcones_Click(object sender, EventArgs e)
        {lvFichier.View = View.SmallIcon;}
        private void tsGrandesIcones_Click(object sender, EventArgs e)
        { lvFichier.View = View.LargeIcon; }
        private void tsListe_Click(object sender, EventArgs e)
        { lvFichier.View = View.List; }
        private void tsDetail_Click(object sender, EventArgs e)
        { lvFichier.View = View.Details; }
        private void LireDisque()
        {
            Cursor = Cursors.WaitCursor;
            slMessage.Text = "Lecture de l'arborescence";
            NoeudRacine = new TreeNode("Poste de travail", 0, 0);
            tvRepertoire.Nodes.Clear();
            tvRepertoire.Nodes.Add(NoeudRacine);
            string[] Disques=Environment.GetLogicalDrives();
            foreach (string Disque in Disques)
            {
                TreeNode NoeudDisque = new TreeNode(Disque, 1, 1);
                NoeudRacine.Nodes.Add(NoeudDisque);
                LireRepertoires(Disque, NoeudDisque.Nodes);
            }
            slMessage.Text = "";
            Cursor = Cursors.Arrow;
        }
        private void LireRepertoires(string nd, TreeNodeCollection tnc)
        {
            if (Directory.Exists(nd))
            {
                try
                {
                    string[] sReps = Directory.GetDirectories(nd);
                    foreach (string sRep in sReps)
                    {
                        string s1 = "", s2 = "";
                        s1 = NomFichier(sRep);
                        s2 = s1.ToUpper();
                        TreeNode NoeudCourant;
                        if (s2 == "RECYCLED" || s2 == "RECYCLER"||s2=="$RECYCLE.BIN")
                            NoeudCourant = new TreeNode(s1, 4, 4);
                        else
                            NoeudCourant = new TreeNode(s1, 2, 3);
                        tnc.Add(NoeudCourant);
                        //LireRepertoires(sRep, NoeudCourant.Nodes);
                    }
                }
                catch {/* MessageBox.Show("Probleme dans la lecture de repertoires"); */}
            }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode NoeudCourant = e.Node;
            if (NoeudCourant == NoeudRacine)
            {
                string[] sTmp = { "Poste de travail", "", "", "" };
                ListViewItem lvi = new ListViewItem(sTmp, 0);
                lvFichier.Items.Add(lvi);
            }
            else
            {
                string sRep = NoeudCourant.FullPath;
                sRep = sRep.Substring(1 + sRep.IndexOf('\\'));
                try
                {
                    lvFichier.Items.Clear();
                    if (!Directory.Exists(sRep))
                    {
                        string[] sTmp = { "Non Operationnel", "", "", "" };
                        ListViewItem lvi = new ListViewItem(sTmp, 0);
                        lvFichier.Items.Add(lvi);
                        Cursor = Cursors.Arrow;
                        ssMessage.Text = "";
                        tvRepertoire.Focus();
                    }
                    else
                        LireFichiers(sRep);
                }
                catch(IOException Fote)
                {
                    MessageBox.Show("Erreur d'acces a" + sRep + "(" + Fote.Message + ")");
                    Cursor = Cursors.Arrow;
                    ssMessage.Text = "";
                    tvRepertoire.Focus();
                }
            }
        }
        private void LireFichiers(string sRep)
        {
            lvFichier.Items.Clear();
            ssMessage.Text = "Rafraichissement de " + sRep + " en cours ";
            Cursor = Cursors.WaitCursor;
            try
            {
                string[] sFics = Directory.GetFiles(sRep);
                string[] lvCol = new string[4];
                //lvlCol[0]<-Nom du Fichier
                //lvlCol[1]<-Taille du Fichier
                //lvlCol[2]<-Date de creation du fichier
                //lvlCol[3]<-Date de dernier modification du fichier
                ssMessage.Text = "Parcours de " + sRep;
                foreach (string sFic in sFics)
                {
                    if (sFic.ToUpper() != "PAGEFILE.SYS")
                    {
                        FileInfo fi = new FileInfo(sFic);
                        lvCol[0] = NomFichier(sFic);
                        if (fi.Length > 1024 * 1024)
                            lvCol[1] = (fi.Length / (1024 * 1024)).ToString() + "MB";
                        else if (fi.Length > 1024)
                            lvCol[1] = (fi.Length / 1024).ToString() + "KB";
                        else
                            lvCol[1] = fi.Length.ToString(); 
                        lvCol[2] = fi.CreationTime.ToString("dd/mm/yyyy");
                        lvCol[3] = fi.LastWriteTime.ToString("dd/mm/yyyy");
                        ListViewItem lvi = new ListViewItem(lvCol, 0);
                        lvFichier.Items.Add(lvi);
                    }
                }
            }
            catch (IOException Fot)
            {
                MessageBox.Show("Erreur d'acces a " + sRep + "(" + Fot.Message + ")");
            }
            catch { MessageBox.Show("Erreur d'acces a " + sRep); }
            finally
            {
                ssMessage.Text = "";
                Cursor = Cursors.Arrow;
            }
        }
    }
}
