CREATE PROCEDURE Ajoutert_travail
 @Id_travail int OUTPUT,
 @nom_travail nvarchar(50),
 @prix_travail float,
 @date_debut datetime,
 @date_fin datetime,
 @id_categ int,
 @id_fact int
AS
 INSERT INTO t_travail(nom_travail,prix_travail,date_debut,date_fin,id_categ,id_fact)
  VALUES(@nom_travail,@prix_travail,@date_debut,@date_fin,@id_categ,@id_fact)
 SET @Id_travail=@@IDENTITY
RETURN
GO
CREATE PROCEDURE Modifiert_travail
 @Id_travail int,
 @nom_travail nvarchar(50),
 @prix_travail float,
 @date_debut datetime,
 @date_fin datetime,
 @id_categ int,
 @id_fact int
AS
 IF(@Id_travail IS NULL OR @Id_travail=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE t_travail
        SET nom_travail=@nom_travail,prix_travail=@prix_travail,date_debut=@date_debut,date_fin=@date_fin,id_categ=@id_categ,id_fact=@id_fact
        WHERE Id_travail=@Id_travail
RETURN
GO
CREATE PROCEDURE Selectionnert_travail
 @Index VARCHAR(10)
AS
 IF(@Index='nom_travail') SELECT * FROM t_travail ORDER BY nom_travail
 ELSE IF(@Index='prix_travail') SELECT * FROM t_travail ORDER BY prix_travail
 ELSE IF(@Index='date_debut') SELECT * FROM t_travail ORDER BY date_debut
 ELSE IF(@Index='date_fin') SELECT * FROM t_travail ORDER BY date_fin
 ELSE IF(@Index='id_categ') SELECT * FROM t_travail ORDER BY id_categ
 ELSE IF(@Index='id_fact') SELECT * FROM t_travail ORDER BY id_fact
 ELSE SELECT * FROM t_travail ORDER BY Id_travail
RETURN
GO
CREATE PROCEDURE Selectionnert_travail_ID
 @Id_travail int
AS
 IF(@Id_travail IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT Id_travail,nom_travail,prix_travail,date_debut,date_fin,id_categ,id_fact
  FROM t_travail
  WHERE @Id_travail=Id_travail
RETURN
GO
CREATE PROCEDURE Supprimert_travail
 @Id_travail int
AS
 IF(@Id_travail IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM t_travail WHERE @Id_travail=Id_travail
RETURN
GO
