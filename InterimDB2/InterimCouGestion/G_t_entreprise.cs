#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_INTERIMDB.Classes;
using Projet_INTERIMDB.Acces;
#endregion

namespace Projet_INTERIMDB.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_t_entreprise : G_Base
 {
  #region Constructeurs
  public G_t_entreprise()
   : base()
  { }
  public G_t_entreprise(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nom_entre)
  { return new A_t_entreprise(ChaineConnexion).Ajouter(nom_entre); }
  public int Modifier(int id_entre, string nom_entre)
  { return new A_t_entreprise(ChaineConnexion).Modifier(id_entre, nom_entre); }
  public List<C_t_entreprise> Lire(string Index)
  { return new A_t_entreprise(ChaineConnexion).Lire(Index); }
  public C_t_entreprise Lire_ID(int id_entre)
  { return new A_t_entreprise(ChaineConnexion).Lire_ID(id_entre); }
  public int Supprimer(int id_entre)
  { return new A_t_entreprise(ChaineConnexion).Supprimer(id_entre); }
 }
}
