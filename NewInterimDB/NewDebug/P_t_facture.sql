CREATE PROCEDURE Ajoutert_facture
 @id_fact int OUTPUT,
 @date_fact datetime,
 @id_inte int,
 @id_entre int
AS
 INSERT INTO t_facture(date_fact,id_inte,id_entre)
  VALUES(@date_fact,@id_inte,@id_entre)
 SET @id_fact=@@IDENTITY
RETURN
GO
CREATE PROCEDURE Modifiert_facture
 @id_fact int,
 @date_fact datetime,
 @id_inte int,
 @id_entre int
AS
 IF(@id_fact IS NULL OR @id_fact=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE t_facture
        SET date_fact=@date_fact,id_inte=@id_inte,id_entre=@id_entre
        WHERE id_fact=@id_fact
RETURN
GO
CREATE PROCEDURE Selectionnert_facture
 @Index VARCHAR(10)
AS
 IF(@Index='date_fact') SELECT * FROM t_facture ORDER BY date_fact
 ELSE IF(@Index='id_inte') SELECT * FROM t_facture ORDER BY id_inte
 ELSE IF(@Index='id_entre') SELECT * FROM t_facture ORDER BY id_entre
 ELSE SELECT * FROM t_facture ORDER BY id_fact
RETURN
GO
CREATE PROCEDURE Selectionnert_facture_ID
 @id_fact int
AS
 IF(@id_fact IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT id_fact,date_fact,id_inte,id_entre
  FROM t_facture
  WHERE @id_fact=id_fact
RETURN
GO
CREATE PROCEDURE Supprimert_facture
 @id_fact int
AS
 IF(@id_fact IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM t_facture WHERE @id_fact=id_fact
RETURN
GO
