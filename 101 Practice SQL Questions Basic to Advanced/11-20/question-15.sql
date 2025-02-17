-- Assume today is August 15, 2014.
-- a. Calculate the age for every current employee. What is the age of the oldest employee?
SELECT
    CONCAT(p.FirstName, ' ', p.LastName),
    DATEDIFF(year, e.BirthDate, '2014-08-15') AS Age
FROM HumanResources.Employee e
JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID
ORDER BY 2 DESC;

-- b. What is the average age by Organization level? Show answer with a single decimal
SELECT
    e.OrganizationLevel,
    FORMAT((AVG(CAST(DATEDIFF(year, e.BirthDate, '2014-04-15') AS DECIMAL))), 'N1') AS AvgAge
FROM HumanResources.Employee e
JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID
GROUP BY e.OrganizationLevel;

-- c. Use the ceiling function to round up
SELECT
    e.OrganizationLevel,
    CEILING((AVG(CAST(DATEDIFF(year, e.BirthDate, '2014-04-15') AS DECIMAL)))) AS AvgAge
FROM HumanResources.Employee e
JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID
GROUP BY e.OrganizationLevel;

-- d. Use the floor function to round down
SELECT
    e.OrganizationLevel,
    FLOOR((AVG(CAST(DATEDIFF(year, e.BirthDate, '2014-04-15') AS DECIMAL)))) AS AvgAge
FROM HumanResources.Employee e
JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID
GROUP BY e.OrganizationLevel;
