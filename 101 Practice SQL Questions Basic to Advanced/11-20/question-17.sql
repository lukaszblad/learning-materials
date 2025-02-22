-- a. Sum the LineTotal in SalesOrderDetail. Format as currency
SELECT
    FORMAT(SUM(LineTotal), 'C') AS SalesSum
FROM Sales.SalesOrderDetail;

-- b. Sum the LineTotal in SalesOrderDetail by the MakeFlag in the product table.
-- Use a case statement to specify manufactured vs. purchased. Format as currency.
SELECT
    FORMAT(SUM(sod.LineTotal), 'C') AS SalesSum,
    CASE
        WHEN p.MakeFlag = 0 THEN 'purchased'
        ELSE 'manufactured'
    END AS Make
FROM Sales.SalesOrderDetail sod
JOIN Production.Product p
    ON sod.ProductID = p.ProductID
GROUP BY p.MakeFlag

-- c. Add a count of distinct SalesOrderIDs
SELECT
    FORMAT(SUM(sod.LineTotal), 'C') AS SalesSum,
    CASE
        WHEN p.MakeFlag = 0 THEN 'purchased'
        ELSE 'manufactured'
    END AS Make,
    FORMAT(COUNT(DISTINCT(sod.SalesOrderID)), '#,#') AS SalesOrderIDCNT
FROM Sales.SalesOrderDetail sod
JOIN Production.Product p
    ON sod.ProductID = p.ProductID
GROUP BY p.MakeFlag


-- d. What is the average LineTotal per SalesOrderID?
SELECT
    FORMAT(SUM(sod.LineTotal), 'C') AS SalesSum,
    CASE
        WHEN p.MakeFlag = 0 THEN 'purchased'
        ELSE 'manufactured'
    END AS Make,
    FORMAT(COUNT(DISTINCT(sod.SalesOrderID)), '#,#') AS SalesOrderIDCNT,
    FORMAT(SUM(sod.LineTotal) / COUNT(DISTINCT(sod.SalesOrderID)), 'C0') AS LineTotalAVG
FROM Sales.SalesOrderDetail sod
JOIN Production.Product p
    ON sod.ProductID = p.ProductID
GROUP BY p.MakeFlag
