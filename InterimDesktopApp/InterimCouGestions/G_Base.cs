#region Ressources extérieures

#endregion

namespace InterimCouGestions
{
 public class G_Base
  {
  #region Données membres
  string _ChaineConnexion;
  #endregion
  #region Constructeurs
  public G_Base()
  { ChaineConnexion = ""; }
  public G_Base(string sChaineConnexion)
  { ChaineConnexion = sChaineConnexion; }
  #endregion
  #region Accesseur
  public string ChaineConnexion
  {
   get {	return _ChaineConnexion;	}
   set	{	_ChaineConnexion = value;	}
  }
  #endregion
 }
}
