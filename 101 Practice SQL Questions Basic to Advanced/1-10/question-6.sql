-- In Question 1 we learned that the AdventureWorks Database has 152 Default Constraints.
-- What tables and columns are these constraints on? And what are the default values?
SELECT 
    dc.name AS DefaultConstraintName,
    dc.definition AS DefaultValue,
    t.name AS TableName,
    c.name AS ColumnName,
    s.name AS SchemaName
FROM sys.default_constraints dc
JOIN sys.tables t ON dc.parent_object_id = t.object_id
JOIN sys.columns c ON dc.parent_object_id = c.object_id AND dc.parent_column_id = c.column_id
JOIN sys.schemas s ON dc.schema_id = s.schema_id;
