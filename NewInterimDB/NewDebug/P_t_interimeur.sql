CREATE PROCEDURE Ajoutert_interimeur
 @id_inte int OUTPUT,
 @nom_inte nvarchar(50),
 @prenom_inte nvarchar(50),
 @specialisation nvarchar(50),
 @bonus_sal float
AS
 INSERT INTO t_interimeur(nom_inte,prenom_inte,specialisation,bonus_sal)
  VALUES(@nom_inte,@prenom_inte,@specialisation,@bonus_sal)
 SET @id_inte=@@IDENTITY
RETURN
GO
CREATE PROCEDURE Modifiert_interimeur
 @id_inte int,
 @nom_inte nvarchar(50),
 @prenom_inte nvarchar(50),
 @specialisation nvarchar(50),
 @bonus_sal float
AS
 IF(@id_inte IS NULL OR @id_inte=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE t_interimeur
        SET nom_inte=@nom_inte,prenom_inte=@prenom_inte,specialisation=@specialisation,bonus_sal=@bonus_sal
        WHERE id_inte=@id_inte
RETURN
GO
CREATE PROCEDURE Selectionnert_interimeur
 @Index VARCHAR(10)
AS
 IF(@Index='nom_inte') SELECT * FROM t_interimeur ORDER BY nom_inte
 ELSE IF(@Index='prenom_inte') SELECT * FROM t_interimeur ORDER BY prenom_inte
 ELSE IF(@Index='specialisation') SELECT * FROM t_interimeur ORDER BY specialisation
 ELSE IF(@Index='bonus_sal') SELECT * FROM t_interimeur ORDER BY bonus_sal
 ELSE SELECT * FROM t_interimeur ORDER BY id_inte
RETURN
GO
CREATE PROCEDURE Selectionnert_interimeur_ID
 @id_inte int
AS
 IF(@id_inte IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT id_inte,nom_inte,prenom_inte,specialisation,bonus_sal
  FROM t_interimeur
  WHERE @id_inte=id_inte
RETURN
GO
CREATE PROCEDURE Supprimert_interimeur
 @id_inte int
AS
 IF(@id_inte IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM t_interimeur WHERE @id_inte=id_inte
RETURN
GO
