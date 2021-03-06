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
 public class G_t_interimeur : G_Base
 {
  #region Constructeurs
  public G_t_interimeur()
   : base()
  { }
  public G_t_interimeur(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_inte, string prenom_inte, string specialisation, double bonus_sal,DateTime date_naissance)
  { return new A_t_interimeur(ChaineConnexion).Ajouter(nom_inte, prenom_inte, specialisation, bonus_sal,date_naissance); }
  public int Modifier(int id_inte, string nom_inte, string prenom_inte, string specialisation, double bonus_sal,DateTime date_naissance)
  { return new A_t_interimeur(ChaineConnexion).Modifier(id_inte, nom_inte, prenom_inte, specialisation, bonus_sal,date_naissance); }
  public List<C_t_interimeur> Lire(string Index)
  { return new A_t_interimeur(ChaineConnexion).Lire(Index); }
  public C_t_interimeur Lire_ID(int id_inte)
  { return new A_t_interimeur(ChaineConnexion).Lire_ID(id_inte); }
  public int Supprimer(int id_inte)
  { return new A_t_interimeur(ChaineConnexion).Supprimer(id_inte); }
 }
}
