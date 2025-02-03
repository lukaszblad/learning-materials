-- Write a SQL Statement that will give you a count of each object type in 
-- the AdventureWorks database. Order by count descending.

SELECT 
    type_desc,
    COUNT(*)
FROM sys.all_objects
GROUP BY type_desc
ORDER BY COUNT(*) DESC;
