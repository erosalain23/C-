#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_NewInterimDB.Classes;
#endregion

namespace Projet_NewInterimDB.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_travail : ADBase
 {
  #region Constructeurs
  public A_t_travail(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_travail, double prix_travail, DateTime date_debut, DateTime date_fin, int id_categ, int id_fact)
  {
   CreerCommande("Ajoutert_travail");
   int res = 0;
   Commande.Parameters.Add("Id_travail", SqlDbType.Int);
   Direction("Id_travail", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nom_travail", nom_travail);
   Commande.Parameters.AddWithValue("@prix_travail", prix_travail);
   Commande.Parameters.AddWithValue("@date_debut", date_debut);
   Commande.Parameters.AddWithValue("@date_fin", date_fin);
   Commande.Parameters.AddWithValue("@id_categ", id_categ);
   Commande.Parameters.AddWithValue("@id_fact", id_fact);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Id_travail"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Id_travail, string nom_travail, double prix_travail, DateTime date_debut, DateTime date_fin, int id_categ, int id_fact)
  {
   CreerCommande("Modifiert_travail");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_travail", Id_travail);
   Commande.Parameters.AddWithValue("@nom_travail", nom_travail);
   Commande.Parameters.AddWithValue("@prix_travail", prix_travail);
   Commande.Parameters.AddWithValue("@date_debut", date_debut);
   Commande.Parameters.AddWithValue("@date_fin", date_fin);
   Commande.Parameters.AddWithValue("@id_categ", id_categ);
   Commande.Parameters.AddWithValue("@id_fact", id_fact);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_travail> Lire(string Index)
  {
   CreerCommande("Selectionnert_travail");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_travail> res = new List<C_t_travail>();
   while (dr.Read())
   {
    C_t_travail tmp = new C_t_travail();
    tmp.Id_travail = int.Parse(dr["Id_travail"].ToString());
    tmp.nom_travail = dr["nom_travail"].ToString();
    tmp.prix_travail = double.Parse(dr["prix_travail"].ToString());
    tmp.date_debut = DateTime.Parse(dr["date_debut"].ToString());
    tmp.date_fin = DateTime.Parse(dr["date_fin"].ToString());
    tmp.id_categ = int.Parse(dr["id_categ"].ToString());
    tmp.id_fact = int.Parse(dr["id_fact"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_travail Lire_ID(int Id_travail)
  {
   CreerCommande("Selectionnert_travail_ID");
   Commande.Parameters.AddWithValue("@Id_travail", Id_travail);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_travail res = new C_t_travail();
   while (dr.Read())
   {
    res.Id_travail = int.Parse(dr["Id_travail"].ToString());
    res.nom_travail = dr["nom_travail"].ToString();
    res.prix_travail = double.Parse(dr["prix_travail"].ToString());
    res.date_debut = DateTime.Parse(dr["date_debut"].ToString());
    res.date_fin = DateTime.Parse(dr["date_fin"].ToString());
    res.id_categ = int.Parse(dr["id_categ"].ToString());
    res.id_fact = int.Parse(dr["id_fact"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Id_travail)
  {
   CreerCommande("Supprimert_travail");
   int res = 0;
   Commande.Parameters.AddWithValue("@Id_travail", Id_travail);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
