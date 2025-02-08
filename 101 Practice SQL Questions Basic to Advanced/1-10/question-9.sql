-- Write a script that will show you each view name and the number of tables used to create the view.
SELECT
    VIEW_NAME,
    COUNT(DISTINCT(TABLE_NAME)) AS TableCNT
FROM INFORMATION_SCHEMA.VIEW_COLUMN_USAGE
GROUP BY VIEW_NAME
ORDER BY 2 DESC;

