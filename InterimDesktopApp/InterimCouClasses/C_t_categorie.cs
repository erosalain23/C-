#region Ressources extérieures

#endregion

namespace InterimCouClasses
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_categorie
 {
  #region Données membres
  private int _id_categ;
  private string _nom_categ;
  private double _sal_categ;
  #endregion
  #region Constructeurs
  public C_t_categorie()
  { }
  public C_t_categorie(string nom_categ_, double sal_categ_)
  {
   nom_categ = nom_categ_;
   sal_categ = sal_categ_;
  }
  public C_t_categorie(int id_categ_, string nom_categ_, double sal_categ_)
   : this(nom_categ_, sal_categ_)
  {
   id_categ = id_categ_;
  }
  #endregion
  #region Accesseurs
  public int id_categ
  {
   get { return _id_categ; }
   set { _id_categ = value; }
  }
  public string nom_categ
  {
   get { return _nom_categ; }
   set { _nom_categ = value; }
  }
  public double sal_categ
  {
   get { return _sal_categ; }
   set { _sal_categ = value; }
  }
  #endregion
 }
}
