#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace InterimCouClasse
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_travail
 {
  #region Données membres
  private int _Id_travail;
  private string _nom_travail;
  private double _prix_travail;
  private DateTime _date_debut;
  private DateTime _date_fin;
  private int _id_categ;
  private int _id_fact;
  #endregion
  #region Constructeurs
  public C_t_travail()
  { }
  public C_t_travail(string nom_travail_, double prix_travail_, DateTime date_debut_, DateTime date_fin_, int id_categ_, int id_fact_)
  {
   nom_travail = nom_travail_;
   prix_travail = prix_travail_;
   date_debut = date_debut_;
   date_fin = date_fin_;
   id_categ = id_categ_;
   id_fact = id_fact_;
  }
  public C_t_travail(int Id_travail_, string nom_travail_, double prix_travail_, DateTime date_debut_, DateTime date_fin_, int id_categ_, int id_fact_)
   : this(nom_travail_, prix_travail_, date_debut_, date_fin_, id_categ_, id_fact_)
  {
   Id_travail = Id_travail_;
  }
  #endregion
  #region Accesseurs
  public int Id_travail
  {
   get { return _Id_travail; }
   set { _Id_travail = value; }
  }
  public string nom_travail
  {
   get { return _nom_travail; }
   set { _nom_travail = value; }
  }
  public double prix_travail
  {
   get { return _prix_travail; }
   set { _prix_travail = value; }
  }
  public DateTime date_debut
  {
   get { return _date_debut; }
   set { _date_debut = value; }
  }
  public DateTime date_fin
  {
   get { return _date_fin; }
   set { _date_fin = value; }
  }
  public int id_categ
  {
   get { return _id_categ; }
   set { _id_categ = value; }
  }
  public int id_fact
  {
   get { return _id_fact; }
   set { _id_fact = value; }
  }
  #endregion
 }
}
