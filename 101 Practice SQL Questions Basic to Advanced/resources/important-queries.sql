SELECT 
    s.name AS SchemaName,
    t.name AS TableName,
    c.name AS ColumnName
FROM sys.tables t
JOIN sys.columns c ON t.object_id = c.object_id
JOIN sys.schemas s ON t.schema_id = s.schema_id;
