-- a. In this question we are going to put the script written in question 4 into a table.
-- To keep the AdventureWorks database clean create a new database called
-- "Edited_AdventureWorks" (if you haven't already)
CREATE DATABASE Edited_AdventureWorks;

-- b. Using a Select Into put the script in question 4 into a table named
-- "Table_Relationships" be sure to put this table in the Edited_AdventureWorks database.
USE Edited_AdventureWorks;
-- CREATE TABLE Table_Relationships(
--     ForeignKeyName VARCHAR(100),
--     SchemaName VARCHAR(100),
--     TableName VARCHAR(100),
--     ColumnName VARCHAR(100),
--     ReferencedSchema VARCHAR(100),
--     ReferencedTable VARCHAR(100),
--     ReferencedColumn VARCHAR(100)
-- ) 

INSERT INTO Table_Relationships (
    ForeignKeyName,
    SchemaName,
    TableName,
    ColumnName,
    ReferencedSchema,
    ReferencedTable,
    ReferencedColumn
)
SELECT
    O.name AS ForeignKeyName,
    S1.name AS SchemaName,
    T1.name AS TableName,
    C1.name AS ColumnName,
    S2.name AS ReferencedSchema,
    T2.name AS ReferencedTable,
    C2.name AS ReferencedColumn
FROM AdventureWorks2019.sys.foreign_key_columns FKC
JOIN AdventureWorks2019.sys.objects O ON FKC.constraint_object_id = O.object_id
JOIN AdventureWorks2019.sys.tables T1 ON FKC.parent_object_id = T1.object_id
JOIN AdventureWorks2019.sys.tables T2 ON FKC.referenced_object_id = T2.object_id
JOIN AdventureWorks2019.sys.columns C1 ON FKC.parent_column_id = C1.column_id
    AND C1.object_id = T1.object_id
JOIN AdventureWorks2019.sys.columns C2 ON FKC.referenced_column_id = C2.column_id
    AND C2.object_id = T2.object_id
JOIN AdventureWorks2019.sys.schemas S1 ON T1.schema_id = S1.schema_id
JOIN AdventureWorks2019.sys.schemas S2 ON T2.schema_id = S2.schema_id;

-- c. Find the Table in Object Explorer
SELECT * FROM Table_Relationships;

-- d. In Question 1 we learned that the AdventureWorks database has 90 foreign key constraints;
-- however, Table_Relationships has 91 rows/relationships. Find the foreign key that has been used twice. 
-- What does this mean?
SELECT
    *
FROM Table_Relationships
WHERE ForeignKeyName = 'FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID';

SELECT 
    ForeignKeyName,
    COUNT(ForeignKeyName)
FROM Table_Relationships
GROUP BY ForeignKeyName
ORDER BY COUNT(ForeignKeyName) DESC;

-- e. How many Distinct Foreign Keys include BusinessEntityID as a column or referenced column?
SELECT 
    COUNT(DISTINCT(ForeignKeyName))
FROM Table_Relationships
WHERE ColumnName = 'BusinessEntityID' OR ReferencedColumn = 'BusinessEntityID';
