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
 public class A_t_interimeur : ADBase
 {
  #region Constructeurs
  public A_t_interimeur(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_inte, string prenom_inte, string specialisation, double bonus_sal)
  {
   CreerCommande("Ajoutert_interimeur");
   int res = 0;
   Commande.Parameters.Add("id_inte", SqlDbType.Int);
   Direction("id_inte", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nom_inte", nom_inte);
   Commande.Parameters.AddWithValue("@prenom_inte", prenom_inte);
   Commande.Parameters.AddWithValue("@specialisation", specialisation);
   Commande.Parameters.AddWithValue("@bonus_sal", bonus_sal);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("id_inte"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int id_inte, string nom_inte, string prenom_inte, string specialisation, double bonus_sal)
  {
   CreerCommande("Modifiert_interimeur");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_inte", id_inte);
   Commande.Parameters.AddWithValue("@nom_inte", nom_inte);
   Commande.Parameters.AddWithValue("@prenom_inte", prenom_inte);
   Commande.Parameters.AddWithValue("@specialisation", specialisation);
   Commande.Parameters.AddWithValue("@bonus_sal", bonus_sal);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_t_interimeur> Lire(string Index)
  {
   CreerCommande("Selectionnert_interimeur");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_t_interimeur> res = new List<C_t_interimeur>();
   while (dr.Read())
   {
    C_t_interimeur tmp = new C_t_interimeur();
    tmp.id_inte = int.Parse(dr["id_inte"].ToString());
    tmp.nom_inte = dr["nom_inte"].ToString();
    tmp.prenom_inte = dr["prenom_inte"].ToString();
    tmp.specialisation = dr["specialisation"].ToString();
    tmp.bonus_sal = double.Parse(dr["bonus_sal"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_t_interimeur Lire_ID(int id_inte)
  {
   CreerCommande("Selectionnert_interimeur_ID");
   Commande.Parameters.AddWithValue("@id_inte", id_inte);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_t_interimeur res = new C_t_interimeur();
   while (dr.Read())
   {
    res.id_inte = int.Parse(dr["id_inte"].ToString());
    res.nom_inte = dr["nom_inte"].ToString();
    res.prenom_inte = dr["prenom_inte"].ToString();
    res.specialisation = dr["specialisation"].ToString();
    res.bonus_sal = double.Parse(dr["bonus_sal"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int id_inte)
  {
   CreerCommande("Supprimert_interimeur");
   int res = 0;
   Commande.Parameters.AddWithValue("@id_inte", id_inte);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
