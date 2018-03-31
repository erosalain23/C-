#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using ISET2018_CouClasses;
#endregion

namespace ISET2018_CouAcces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_Personne : ADBase
 {
  #region Constructeurs
  public A_Personne(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NOM, string PRE, DateTime? NAI)
  {
   CreerCommande("AjouterPersonne");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@NOM", NOM);
   if(PRE == null) Commande.Parameters.AddWithValue("@PRE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRE", PRE);
   if(NAI == null) Commande.Parameters.AddWithValue("@NAI", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NAI", NAI);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string NOM, string PRE, DateTime? NAI)
  {
   CreerCommande("ModifierPersonne");
   int res = 0;
            Commande.Parameters.AddWithValue("ID", ID);//replaced this SqlDbType.Int with ID
            Commande.Parameters.AddWithValue("@NOM", NOM);
   if(PRE == null) Commande.Parameters.AddWithValue("@PRE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRE", PRE);
   if(NAI == null) Commande.Parameters.AddWithValue("@NAI", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@NAI", NAI);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Personne> Lire(string Index)
  {
   CreerCommande("SelectionnerPersonne");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Personne> res = new List<C_Personne>();
   while (dr.Read())
   {
    C_Personne tmp = new C_Personne();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.NOM = dr["NOM"].ToString();
    tmp.PRE = dr["PRE"].ToString();
   if(dr["NAI"] != DBNull.Value) tmp.NAI = DateTime.Parse(dr["NAI"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Personne Lire_ID(int ID)
  {
   CreerCommande("SelectionnerPersonne_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Personne res = new C_Personne();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.NOM = dr["NOM"].ToString();
    res.PRE = dr["PRE"].ToString();
   if(dr["NAI"] != DBNull.Value) res.NAI = DateTime.Parse(dr["NAI"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerPersonne");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
