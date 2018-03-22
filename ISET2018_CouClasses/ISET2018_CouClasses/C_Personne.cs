#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace ISET2018_CouClasses
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_Personne
 {
  #region Données membres
  private int _ID;
  private string _NOM;
  private string _PRE;
  private DateTime? _NAI;
  #endregion
  #region Constructeurs
  public C_Personne()
  { }
  public C_Personne(string NOM_, string PRE_, DateTime? NAI_)
  {
   NOM = NOM_;
   PRE = PRE_;
   NAI = NAI_;
  }
  public C_Personne(int ID_, string NOM_, string PRE_, DateTime? NAI_)
   : this(NOM_, PRE_, NAI_)
  {
   ID = ID_;
  }
  #endregion
  #region Accesseurs
  public int ID
  {
   get { return _ID; }
   set { _ID = value; }
  }
  public string NOM
  {
   get { return _NOM; }
   set { _NOM = value; }
  }
  public string PRE
  {
   get { return _PRE; }
   set { _PRE = value; }
  }
  public DateTime? NAI
  {
   get { return _NAI; }
   set { _NAI = value; }
  }
  #endregion
 }
}
