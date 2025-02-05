-- From question 2
SELECT 
    s.name AS SchemaName,
    t.name AS TableName,
    c.name AS ColumnName
FROM sys.tables t
JOIN sys.columns c ON t.object_id = c.object_id
JOIN sys.schemas s ON t.schema_id = s.schema_id;

-- From question 4
SELECT
    O.name AS ForeignKeyName,
    S1.name AS SchemaName,
    T1.name AS TableName,
    C1.name AS ColumnName,
    S2.name AS ReferencedSchema,
    T2.name AS ReferencedTable,
    C2.name AS ReferencedColumn
FROM sys.foreign_key_columns FKC
JOIN sys.objects O ON FKC.constraint_object_id = O.object_id
JOIN sys.tables T1 ON FKC.parent_object_id = T1.object_id
JOIN sys.tables T2 ON FKC.referenced_object_id = T2.object_id
JOIN sys.columns C1 ON FKC.parent_column_id = C1.column_id
    AND C1.object_id = T1.object_id
JOIN sys.columns C2 ON FKC.referenced_column_id = C2.column_id
    AND C2.object_id = T2.object_id
JOIN sys.schemas S1 ON T1.schema_id = S1.schema_id
JOIN sys.schemas S2 ON T2.schema_id = S2.schema_id;

-- From question 5
USE Edited_AdventureWorks;
SELECT * FROM Table_Relationships;
