using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ISET_2018_Decouverte
{
    public partial class FicBD1 : Form
    {
        private string sChConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Bac2\P.Alexandre\DB\perso.mdb";
        public FicBD1()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            lbContenu.Items.Clear();
            OleDbConnection conn = new OleDbConnection(sChConn);
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT PRE,NOM FROM Client ORDER BY NOM";
            OleDbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
                lbContenu.Items.Add(dr["PRE"].ToString() + " " + dr["NOM"]);
            dr.Close();
            conn.Close();
        }

        private void btnCompter_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(sChConn);
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT COUNT(NOM) FROM Client ";
            int nb = (int)comm.ExecuteScalar();
            MessageBox.Show(nb.ToString() + "enregistrement");
            conn.Close();
        }

        private void btnSauver_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(sChConn);
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO Client(NOM,PRE) VALUES('" + tbNom.Text + "','" + tbPrenom.Text + "') ";
            int nb = (int)comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + "enregistrement(s) effectue(s)");
            conn.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(sChConn);
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "DELETE FROM Client WHERE PRE='" + tbSupp.Text + "'";
            int nb = (int)comm.ExecuteNonQuery();
            MessageBox.Show(nb.ToString() + "Suppression(s) effectue(s)");
            conn.Close();
        }
    }
}
