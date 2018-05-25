using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ISET_2018_Decouverte
{
    public partial class EcranExpresssionRegulieres : Form
    {
        public EcranExpresssionRegulieres()
        {
            InitializeComponent();
        }
        private void cbIsRespectCasse_CheckedChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtATraiter);
        }
        private void cbRemplacer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemplacer.Checked)
                MessageBox.Show(RemplacerOccurrence(tbExpressionRegulieres.Text, rtATraiter.Text, tbRemplacement.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase));
            cbRemplacer.Checked = false;
        }
        private void cbSeparer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeparer.Checked)
            {
                string[] tTmp = DecouperOccurrence(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                foreach (string s in tTmp)
                    MessageBox.Show(s);
            }
            else
                MessageBox.Show("Renseigner une expression avant de decouper");
            cbSeparer.Checked = false;
        }
        private void EcranExpresssionRegulieres_Load(object sender, EventArgs e)
        {
            tbExpressionRegulieres_TextChanged(null, null);
        }
        private void tbExpressionRegulieres_TextChanged(object sender, EventArgs e)
        {
            if (cbIsValide.Checked = Validite(tbExpressionRegulieres.Text))
            {
                cbIsCorrespondance.Checked = Correspondance(tbExpressionRegulieres.Text,rtATraiter.Text,cbIsRespectCasse.Checked?RegexOptions.None:RegexOptions.IgnoreCase);
                MettreEnEvidence(TrouverOccurrences(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtATraiter);

            }
        }
        private void rtATraiter_TextChanged(object sender, EventArgs e)
        {
            cbIsCorrespondance.Checked = Correspondance(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(tbExpressionRegulieres.Text, rtATraiter.Text, cbIsRespectCasse.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), rtATraiter);

        }
        private bool Validite(string sExpressionReguliere)
        {
            try
            {
                Regex reg = new Regex(sExpressionReguliere);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Correspondance(string sExpressionReguliere,string sAVerifier,RegexOptions roParametres) 
        {
            try
            {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.IsMatch(sAVerifier);
            }
            catch
            {
                return false;
            }
        }
        private MatchCollection TrouverOccurrences(string sExpressionReguliere,string sAVerifier,RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Matches(sAVerifier);
        }
        private void MettreEnEvidence(MatchCollection Occurences, RichTextBox Controle)
        {
            Controle.Select(0, Controle.Text.Length);
            Controle.SelectionBackColor = Color.Transparent;
            foreach (Match Occurence in Occurences)
            {
                Controle.Select(Occurence.Index, Occurence.Length);
                Controle.SelectionBackColor = Color.Silver;
            }
        }
        private string RemplacerOccurrence(string sExpressionReguliere,string sTexteDepart,string sRemplacement,RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Replace(sTexteDepart, sRemplacement);
        }
        public string[] DecouperOccurrence(string sExpressionReguliere,string sATraiter,RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Split(sATraiter);
        }
    }
}
