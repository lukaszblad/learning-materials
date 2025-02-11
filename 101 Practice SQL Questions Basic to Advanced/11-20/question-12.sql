-- a. What is the name of the CEO? Concatenate first and last name.

SELECT TOP 1
    CONCAT(P.FirstName, ' ', P.LastName) AS FullName,
    E.JobTitle
FROM Person.Person P
JOIN  HumanResources.Employee E ON E.BusinessEntityID = P.BusinessEntityID 
ORDER BY OrganizationLevel ASC;

-- b. When did this person start working for AdventureWorks
SELECT TOP 1
    CONCAT(P.FirstName, ' ', P.LastName) AS EmployeeNAme,
    E.JobTitle,
    E.HireDate
FROM Person.Person P
JOIN  HumanResources.Employee E ON E.BusinessEntityID = P.BusinessEntityID 
ORDER BY OrganizationLevel ASC;

-- c. Who reports to the CEO? Includes their names and title
SELECT
    CONCAT(P.FirstName, ' ', P.LastName) AS EmployeeNAme,
    E.JobTitle
FROM Person.Person P
JOIN  HumanResources.Employee E ON E.BusinessEntityID = P.BusinessEntityID
WHERE OrganizationLevel = 1;
