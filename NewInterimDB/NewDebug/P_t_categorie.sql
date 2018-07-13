CREATE PROCEDURE Ajoutert_categorie
 @id_categ int OUTPUT,
 @nom_categ nvarchar(50),
 @sal_categ float
AS
 INSERT INTO t_categorie(nom_categ,sal_categ)
  VALUES(@nom_categ,@sal_categ)
 SET @id_categ=@@IDENTITY
RETURN
GO
CREATE PROCEDURE Modifiert_categorie
 @id_categ int,
 @nom_categ nvarchar(50),
 @sal_categ float
AS
 IF(@id_categ IS NULL OR @id_categ=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE t_categorie
        SET nom_categ=@nom_categ,sal_categ=@sal_categ
        WHERE id_categ=@id_categ
RETURN
GO
CREATE PROCEDURE Selectionnert_categorie
 @Index VARCHAR(10)
AS
 IF(@Index='nom_categ') SELECT * FROM t_categorie ORDER BY nom_categ
 ELSE IF(@Index='sal_categ') SELECT * FROM t_categorie ORDER BY sal_categ
 ELSE SELECT * FROM t_categorie ORDER BY id_categ
RETURN
GO
CREATE PROCEDURE Selectionnert_categorie_ID
 @id_categ int
AS
 IF(@id_categ IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT id_categ,nom_categ,sal_categ
  FROM t_categorie
  WHERE @id_categ=id_categ
RETURN
GO
CREATE PROCEDURE Supprimert_categorie
 @id_categ int
AS
 IF(@id_categ IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM t_categorie WHERE @id_categ=id_categ
RETURN
GO
