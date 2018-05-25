#region Ressources extérieures

using System;
using System.Collections.Generic;
using InterimCouAccess;
using InterimCouClasses;

#endregion

namespace InterimCouGestions
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_t_travail : G_Base
 {
  #region Constructeurs
  public G_t_travail()
   : base()
  { }
  public G_t_travail(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_travail, double prix_travail, DateTime date_debut, DateTime date_fin, int id_categ, int id_fact)
  { return new A_t_travail(ChaineConnexion).Ajouter(nom_travail, prix_travail, date_debut, date_fin, id_categ, id_fact); }
  public int Modifier(int Id_travail, string nom_travail, double prix_travail, DateTime date_debut, DateTime date_fin, int id_categ, int id_fact)
  { return new A_t_travail(ChaineConnexion).Modifier(Id_travail, nom_travail, prix_travail, date_debut, date_fin, id_categ, id_fact); }
  public List<C_t_travail> Lire(string Index)
  { return new A_t_travail(ChaineConnexion).Lire(Index); }
  public C_t_travail Lire_ID(int Id_travail)
  { return new A_t_travail(ChaineConnexion).Lire_ID(Id_travail); }
  public int Supprimer(int Id_travail)
  { return new A_t_travail(ChaineConnexion).Supprimer(Id_travail); }
 }
}
