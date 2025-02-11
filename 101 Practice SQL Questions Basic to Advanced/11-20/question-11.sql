-- a. How many employees exist in the Database?
SELECT
    COUNT(*) AS EmployeeCNT,
    COUNT(DISTINCT(BusinessEntityID)) AS BusinessEntityIDCNT,
    COUNT(DISTINCT(NationalIDNumber)) AS NationalIDNumberCNT
FROM HumanResources.Employee;

-- b. How many of these employees are active employees?
SELECT
    COUNT(*) AS EmployeeCount
FROM HumanResources.Employee
WHERE CurrentFlag = 1;

-- c. How many Job Titles equal the 'SP' Person type?
SELECT
    COUNT(DISTINCT(E.JobTitle)) AS Cnt
FROM HumanResources.Employee E
JOIN Person.Person P ON E.BusinessEntityID = P.BusinessEntityID
WHERE P.PersonType = 'SP';

-- d. How many of these employees are sales people?
SELECT
    COUNT(SP.BusinessEntityID) AS SalesPeopleCNT
FROM HumanResources.Employee E
JOIN Person.Person P ON E.BusinessEntityID = P.BusinessEntityID
JOIN Sales.SalesPerson SP ON E.BusinessEntityID = SP.BusinessEntityID
WHERE P.PersonType = 'SP';
