CREATE PROCEDURE Ajoutert_entreprise
 @id_entre int OUTPUT,
 @nom_entre nvarchar(50)
AS
 INSERT INTO t_entreprise(nom_entre)
  VALUES(@nom_entre)
 SET @id_entre=@@IDENTITY
RETURN
GO
CREATE PROCEDURE Modifiert_entreprise
 @id_entre int,
 @nom_entre nvarchar(50)
AS
 IF(@id_entre IS NULL OR @id_entre=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE t_entreprise
        SET nom_entre=@nom_entre
        WHERE id_entre=@id_entre
RETURN
GO
CREATE PROCEDURE Selectionnert_entreprise
 @Index VARCHAR(10)
AS
 IF(@Index='nom_entre') SELECT * FROM t_entreprise ORDER BY nom_entre
 ELSE SELECT * FROM t_entreprise ORDER BY id_entre
RETURN
GO
CREATE PROCEDURE Selectionnert_entreprise_ID
 @id_entre int
AS
 IF(@id_entre IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT id_entre,nom_entre
  FROM t_entreprise
  WHERE @id_entre=id_entre
RETURN
GO
CREATE PROCEDURE Supprimert_entreprise
 @id_entre int
AS
 IF(@id_entre IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM t_entreprise WHERE @id_entre=id_entre
RETURN
GO
