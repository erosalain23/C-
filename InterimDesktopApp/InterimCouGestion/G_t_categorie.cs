#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using InterimCouAccess;
using InterimCouClasse;
#endregion

namespace InterimCouGestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_t_categorie : G_Base
 {
  #region Constructeurs
  public G_t_categorie()
   : base()
  { }
  public G_t_categorie(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_categ, double sal_categ)
  { return new A_t_categorie(ChaineConnexion).Ajouter(nom_categ, sal_categ); }
  public int Modifier(int id_categ, string nom_categ, double sal_categ)
  { return new A_t_categorie(ChaineConnexion).Modifier(id_categ, nom_categ, sal_categ); }
  public List<C_t_categorie> Lire(string Index)
  { return new A_t_categorie(ChaineConnexion).Lire(Index); }
  public C_t_categorie Lire_ID(int id_categ)
  { return new A_t_categorie(ChaineConnexion).Lire_ID(id_categ); }
  public int Supprimer(int id_categ)
  { return new A_t_categorie(ChaineConnexion).Supprimer(id_categ); }
 }
}
