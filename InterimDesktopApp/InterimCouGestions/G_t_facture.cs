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
 public class G_t_facture : G_Base
 {
  #region Constructeurs
  public G_t_facture()
   : base()
  { }
  public G_t_facture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime date_fact, int id_inte, int id_entre)
  { return new A_t_facture(ChaineConnexion).Ajouter(date_fact, id_inte, id_entre); }
  public int Modifier(int id_fact, DateTime date_fact, int id_inte, int id_entre)
  { return new A_t_facture(ChaineConnexion).Modifier(id_fact, date_fact, id_inte, id_entre); }
  public List<C_t_facture> Lire(string Index)
  { return new A_t_facture(ChaineConnexion).Lire(Index); }
  public C_t_facture Lire_ID(int id_fact)
  { return new A_t_facture(ChaineConnexion).Lire_ID(id_fact); }
  public int Supprimer(int id_fact)
  { return new A_t_facture(ChaineConnexion).Supprimer(id_fact); }
 }
}
