-- a. Write a script that will give you the TableName, ColumnName and each value (definition) where class = 1
SELECT
    t.name AS TableName,
    c.name AS ColumnName,
    ep.[value] AS ExtendedPropertiesValue
FROM sys.extended_properties ep
JOIN sys.tables t ON ep.major_id = t.object_id
JOIN sys.columns c ON ep.minor_id = c.column_id
    AND ep.major_id = c.object_id
WHERE ep.class = 1;

-- b. Find the value (definition) for every Column in the Person table
SELECT
    t.name AS TableName,
    c.name AS ColumnName,
    ep.[value] AS ExtendedPropertiesValue
FROM sys.extended_properties ep
JOIN sys.tables t ON ep.major_id = t.object_id
JOIN sys.columns c ON ep.minor_id = c.column_id
    AND ep.major_id = c.object_id
WHERE t.name = 'Person';
