DROP TABLE Teacher;

CREATE TABLE Teacher(
    T_ID INT IDENTITY(1,1) PRIMARY KEY,
    T_Name VARCHAR(40),
    T_Address VARCHAR(30),
    T_Phone VARCHAR(15)  -- Store phone as string
);