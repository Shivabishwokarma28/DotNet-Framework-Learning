CREATE TRIGGER TriClass
ON Class
AFTER INSERT
AS
BEGIN
print('Something happend to Class table')
END