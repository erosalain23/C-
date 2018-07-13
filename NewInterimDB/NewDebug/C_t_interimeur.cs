#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_NewInterimDB.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_interimeur
 {
  #region Données membres
  private int _id_inte;
  private string _nom_inte;
  private string _prenom_inte;
  private string _specialisation;
  private double _bonus_sal;
  #endregion
  #region Constructeurs
  public C_t_interimeur()
  { }
  public C_t_interimeur(string nom_inte_, string prenom_inte_, string specialisation_, double bonus_sal_)
  {
   nom_inte = nom_inte_;
   prenom_inte = prenom_inte_;
   specialisation = specialisation_;
   bonus_sal = bonus_sal_;
  }
  public C_t_interimeur(int id_inte_, string nom_inte_, string prenom_inte_, string specialisation_, double bonus_sal_)
   : this(nom_inte_, prenom_inte_, specialisation_, bonus_sal_)
  {
   id_inte = id_inte_;
  }
  #endregion
  #region Accesseurs
  public int id_inte
  {
   get { return _id_inte; }
   set { _id_inte = value; }
  }
  public string nom_inte
  {
   get { return _nom_inte; }
   set { _nom_inte = value; }
  }
  public string prenom_inte
  {
   get { return _prenom_inte; }
   set { _prenom_inte = value; }
  }
  public string specialisation
  {
   get { return _specialisation; }
   set { _specialisation = value; }
  }
  public double bonus_sal
  {
   get { return _bonus_sal; }
   set { _bonus_sal = value; }
  }
  #endregion
 }
}
