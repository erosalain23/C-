#region Ressources extérieures

using System;

#endregion

namespace InterimCouClasses
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_facture
 {
  #region Données membres
  private int _id_fact;
  private DateTime _date_fact;
  private int _id_inte;
  private int _id_entre;
  #endregion
  #region Constructeurs
  public C_t_facture()
  { }
  public C_t_facture(DateTime date_fact_, int id_inte_, int id_entre_)
  {
   date_fact = date_fact_;
   id_inte = id_inte_;
   id_entre = id_entre_;
  }
  public C_t_facture(int id_fact_, DateTime date_fact_, int id_inte_, int id_entre_)
   : this(date_fact_, id_inte_, id_entre_)
  {
   id_fact = id_fact_;
  }
  #endregion
  #region Accesseurs
  public int id_fact
  {
   get { return _id_fact; }
   set { _id_fact = value; }
  }
  public DateTime date_fact
  {
   get { return _date_fact; }
   set { _date_fact = value; }
  }
  public int id_inte
  {
   get { return _id_inte; }
   set { _id_inte = value; }
  }
  public int id_entre
  {
   get { return _id_entre; }
   set { _id_entre = value; }
  }
  #endregion
 }
}
