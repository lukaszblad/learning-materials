-- a. Use this table to get a count of each data type in the
-- AdventureWorks Database (include the view tables).
-- Which data type is used the most?
SELECT
    DATA_TYPE,
    COUNT(*) AS DataType
FROM INFORMATION_SCHEMA.COLUMNS
GROUP BY DATA_TYPE
ORDER BY 2 DESC;

/*
b. Using a case statement create a data type grouping that summarizes each data type 
as one of the following Groups:
- Character
- Numeric
- Date
- Null
Use the following columns to create these groups:
- Character_Maximum_Length
- Numeric_Precision
- DateTime_Precision
For example, when the Character_Maximum_Length is not null then the data type
group is "Character." If a row is    null in all three columns then put it in the "Null" group.
Then give a count of data types in each grouping. The final output will only 
have two columns - "DataTypeGroup" and "DataTypeCNT." Lastly, order by count desc
*/
SELECT
    CASE
        WHEN CHARACTER_MAXIMUM_LENGTH IS NOT NULL THEN 'Character'
        WHEN NUMERIC_PRECISION IS NOT NULL THEN 'Numeric'
        WHEN DATETIME_PRECISION IS NOT NULL THEN 'Date'
        ELSE Null
    END AS 'DataTypeGroup',
    COUNT(*) AS DataType
FROM INFORMATION_SCHEMA.COLUMNS
GROUP BY 
    CASE
        WHEN CHARACTER_MAXIMUM_LENGTH IS NOT NULL THEN 'Character'
        WHEN NUMERIC_PRECISION IS NOT NULL THEN 'Numeric'
        WHEN DATETIME_PRECISION IS NOT NULL THEN 'Date'
        ELSE Null
    END
ORDER BY 2 DESC;

-- c. What data types are in the "Null" group
SELECT
    DISTINCT(DATA_TYPE)
FROM INFORMATION_SCHEMA.COLUMNS
WHERE CHARACTER_MAXIMUM_LENGTH IS NULL
    AND NUMERIC_PRECISION IS NULL
    AND DATETIME_PRECISION IS NULL
