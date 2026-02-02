CREATE TABLE Class (
    Class_ID INT IDENTITY(1,1) PRIMARY KEY,
    Class_Name VARCHAR(20) NOT NULL,
    Section VARCHAR(5),
    Class_Teacher_ID INT,
);