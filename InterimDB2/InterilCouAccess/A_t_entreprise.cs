#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_INTERIMDB.Classes;
#endregion

namespace Projet_INTERIMDB.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_t_entreprise : ADBase
 {
  #region Constructeurs
  public A_t_entreprise(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_entre)
  {
   CreerCommande("Ajoutert_entreprise");
   int res = 0;
   Commande.Parameters.Add("id_entre", SqlDbType.Int);
   Direction("id_entre", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nom_entre", nom_entre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("id_entre"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int id_entre, string nom_entre)
  {
   CreerCommande("Modifiert_entreprise");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_entre", id_entre);
   Commande.Parameters.AddWithValue("@nom_entre", nom_entre);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_entreprise> Lire(string Index)
  {
   CreerCommande("Selectionnert_entreprise");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_entreprise> res = new List<C_t_entreprise>();
   while (dr.Read())
   {
    C_t_entreprise tmp = new C_t_entreprise();
    tmp.id_entre = int.Parse(dr["id_entre"].ToString());
    tmp.nom_entre = dr["nom_entre"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_entreprise Lire_ID(int id_entre)
  {
   CreerCommande("Selectionnert_entreprise_ID");
   Commande.Parameters.AddWithValue("@id_entre", id_entre);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_entreprise res = new C_t_entreprise();
   while (dr.Read())
   {
    res.id_entre = int.Parse(dr["id_entre"].ToString());
    res.nom_entre = dr["nom_entre"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int id_entre)
  {
   CreerCommande("Supprimert_entreprise");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_entre", id_entre);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
