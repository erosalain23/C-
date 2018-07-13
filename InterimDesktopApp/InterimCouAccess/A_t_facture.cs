#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using InterimCouClasse;
#endregion

namespace InterimCouAccess
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_facture : ADBase
 {
  #region Constructeurs
  public A_t_facture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime date_fact, int id_inte, int id_entre)
  {
   CreerCommande("Ajoutert_facture");
   int res = 0;
   Commande.Parameters.Add("id_fact", SqlDbType.Int);
   Direction("id_fact", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@date_fact", date_fact);
   Commande.Parameters.AddWithValue("@id_inte", id_inte);
   Commande.Parameters.AddWithValue("@id_entre", id_entre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("id_fact"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int id_fact, DateTime date_fact, int id_inte, int id_entre)
  {
   CreerCommande("Modifiert_facture");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_fact", id_fact);
   Commande.Parameters.AddWithValue("@date_fact", date_fact);
   Commande.Parameters.AddWithValue("@id_inte", id_inte);
   Commande.Parameters.AddWithValue("@id_entre", id_entre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_facture> Lire(string Index)
  {
   CreerCommande("Selectionnert_facture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_facture> res = new List<C_t_facture>();
   while (dr.Read())
   {
    C_t_facture tmp = new C_t_facture();
    tmp.id_fact = int.Parse(dr["id_fact"].ToString());
    tmp.date_fact = DateTime.Parse(dr["date_fact"].ToString());
    tmp.id_inte = int.Parse(dr["id_inte"].ToString());
    tmp.id_entre = int.Parse(dr["id_entre"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_facture Lire_ID(int id_fact)
  {
   CreerCommande("Selectionnert_facture_ID");
   Commande.Parameters.AddWithValue("@id_fact", id_fact);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_facture res = new C_t_facture();
   while (dr.Read())
   {
    res.id_fact = int.Parse(dr["id_fact"].ToString());
    res.date_fact = DateTime.Parse(dr["date_fact"].ToString());
    res.id_inte = int.Parse(dr["id_inte"].ToString());
    res.id_entre = int.Parse(dr["id_entre"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int id_fact)
  {
   CreerCommande("Supprimert_facture");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_fact", id_fact);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
