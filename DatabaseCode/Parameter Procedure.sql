CREATE PROCEDURE spGetst
@id int
AS
BEGIN 
SELECT * FROM Student WHERE Id=@id;
END;
GO
EXEC spGetst 4;