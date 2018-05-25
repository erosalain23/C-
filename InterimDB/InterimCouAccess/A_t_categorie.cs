#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using InterimCouClasses;
#endregion

namespace InterimCouAccess
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_categorie : ADBase
 {
  #region Constructeurs
  public A_t_categorie(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_categ, double sal_categ)
  {
   CreerCommande("Ajoutert_categorie");
   int res = 0;
   Commande.Parameters.Add("id_categ", SqlDbType.Int);
   Direction("id_categ", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nom_categ", nom_categ);
   Commande.Parameters.AddWithValue("@sal_categ", sal_categ);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("id_categ"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int id_categ, string nom_categ, double sal_categ)
  {
   CreerCommande("Modifiert_categorie");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_categ", id_categ);
   Commande.Parameters.AddWithValue("@nom_categ", nom_categ);
   Commande.Parameters.AddWithValue("@sal_categ", sal_categ);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_categorie> Lire(string Index)
  {
   CreerCommande("Selectionnert_categorie");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_categorie> res = new List<C_t_categorie>();
   while (dr.Read())
   {
    C_t_categorie tmp = new C_t_categorie();
    tmp.id_categ = int.Parse(dr["id_categ"].ToString());
    tmp.nom_categ = dr["nom_categ"].ToString();
    tmp.sal_categ = double.Parse(dr["sal_categ"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_categorie Lire_ID(int id_categ)
  {
   CreerCommande("Selectionnert_categorie_ID");
   Commande.Parameters.AddWithValue("@id_categ", id_categ);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_categorie res = new C_t_categorie();
   while (dr.Read())
   {
    res.id_categ = int.Parse(dr["id_categ"].ToString());
    res.nom_categ = dr["nom_categ"].ToString();
    res.sal_categ = double.Parse(dr["sal_categ"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int id_categ)
  {
   CreerCommande("Supprimert_categorie");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_categ", id_categ);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
