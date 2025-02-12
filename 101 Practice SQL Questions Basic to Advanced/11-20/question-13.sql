-- a. What is the job title for John Evans
SELECT
    CONCAT(p.FirstName, ' ', p.LastName) AS EmployeeName,
    e.JobTitle
FROM Person.Person p
JOIN HumanResources.Employee e
    ON p.BusinessEntityID = e.BusinessEntityID
WHERE p.FirstName = 'John' AND p.LastName = 'Evans';

-- b. What department does John Evans work in?
SELECT
    CONCAT(p.FirstName, ' ', p.LastName),
    e.JobTitle,
    d.Name
FROM Person.Person p
JOIN HumanResources.Employee e
    ON p.BusinessEntityID = e.BusinessEntityID
JOIN HumanResources.EmployeeDepartmentHistory edh
    ON e.BusinessEntityID = edh.BusinessEntityID
JOIN HumanResources.Department d
    ON edh.DepartmentID = d.DepartmentID
WHERE p.FirstName = 'John' AND p.LastName = 'Evans';

