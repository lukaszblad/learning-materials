-- a. Create a new database called "Edited_AdventureWorks"
-- (we are creating another database so we don't overwrite or change the AdventureWorks database).
-- Then write a USE statement to connect to the new database.
CREATE DATABASE Edited_AdventureWorks;

-- b. Using the following tables - sys.check_constraints, sys.tables, 
-- and sys.columns to write a query that will give you TableName, ColumnName, 
-- CheckConstraintName, and CheckConstraintDefinition
SELECT
    t.name AS TableName,
    c.name AS ColumnName,
    cc.name AS CheckConstraintName,
    cc.definition AS CheckConstraintDefinition
FROM AdventureWorks2019.sys.check_constraints cc
JOIN AdventureWorks2019.sys.tables t 
    ON cc.parent_object_id = t.object_id
LEFT JOIN AdventureWorks2019.sys.columns c 
    ON cc.parent_column_id = c.column_id AND cc.parent_object_id = c.object_id;

-- c. Create a table named "tbl_CheckConstraint" in the "Edited_AdventureWorks"
-- database with the following  columns and data types:
-- TableName varchar(100),ColumnName varchar(100), CheckConsraint varchar(250),
-- Definition varchar(500), ConstraintLevel varchar(100)
CREATE TABLE tbl_CheckConstraint (
    TableName VARCHAR(100),
    ColumnName VARCHAR(100),
    CheckConsraint VARCHAR(250),
    [Definition] VARCHAR(500),
    ConstraintLevel VARCHAR(100)
);

SELECT * FROM tbl_CheckConstraint;

-- d. Using the query in part b insert the data into "tbl_CheckConstraint" 
INSERT INTO tbl_CheckConstraint (
    TableName,
    ColumnName,
    CheckConsraint,
    [Definition],
    ConstraintLevel
)
SELECT
    t.name AS TableName,
    c.name AS ColumnName,
    cc.name AS CheckConstraintName,
    cc.definition AS CheckConstraintDefinition,
    NULL AS ConstraintLevel
FROM AdventureWorks2019.sys.check_constraints cc
JOIN AdventureWorks2019.sys.tables t 
    ON cc.parent_object_id = t.object_id
LEFT JOIN AdventureWorks2019.sys.columns c 
    ON cc.parent_column_id = c.column_id AND cc.parent_object_id = c.object_id;

-- e. Using a case statement write an update statement (update ConstraintLevel)
-- that will specify whether the constraint is assigned to the column or the table.
UPDATE tbl_CheckConstraint
SET ConstraintLevel = 
    CASE WHEN ColumnName IS NULL
        THEN 'TableLevel'
        ELSE 'ColumnLevel'
        END

SELECT * FROM tbl_CheckConstraint;

-- g. Once you're done interpreting the results drop the tbl_CheckConstraint table
DROP TABLE tbl_CheckConstraint;
