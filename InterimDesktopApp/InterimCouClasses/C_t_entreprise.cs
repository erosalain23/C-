#region Ressources extérieures

#endregion

namespace InterimCouClasses
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_entreprise
 {
  #region Données membres
  private int _id_entre;
  private string _nom_entre;
  #endregion
  #region Constructeurs
  public C_t_entreprise()
  { }
  public C_t_entreprise(string nom_entre_)
  {
   nom_entre = nom_entre_;
  }
  public C_t_entreprise(int id_entre_, string nom_entre_)
   : this(nom_entre_)
  {
   id_entre = id_entre_;
  }
  #endregion
  #region Accesseurs
  public int id_entre
  {
   get { return _id_entre; }
   set { _id_entre = value; }
  }
  public string nom_entre
  {
   get { return _nom_entre; }
   set { _nom_entre = value; }
  }
  #endregion
 }
}
