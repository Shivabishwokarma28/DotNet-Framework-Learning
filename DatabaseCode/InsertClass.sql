CREATE PROCEDURE Classpc
AS
BEGIN
INSERT INTO Class (Class_Name, Section, Class_Teacher_ID)
VALUES
('Grade 1', 'A', 1),
('Grade 1', 'B', 2),
('Grade 2', 'A', 3),
('Grade 2', 'B', 4),
('Grade 3', 'A', 5),
('Grade 3', 'B', 6),
('Grade 4', 'A', 7),
('Grade 4', 'B', 8);

END
EXEC Classpc