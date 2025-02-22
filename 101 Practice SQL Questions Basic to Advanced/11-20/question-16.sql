-- a. How many products are sold by AdventureWorks?
SELECT
    COUNT(DISTINCT(Name)) AS ProductsCount
FROM Production.Product
WHERE FinishedGoodsFlag = 1;

-- b. How many of these products are actively being sold by AdventureWorks?
SELECT 
    COUNT(*) AS ActiveProducts
FROM Production.Product
WHERE SellEndDate IS NULL AND FinishedGoodsFlag = 1;

-- c. How many of these active products are made in house vs. purchased?
SELECT 
    COUNT(*) AS ActiveProducts,
    CASE
        WHEN MakeFlag = 0 THEN 'Purchased'
        ELSE 'Manufactured'
    END AS Make
FROM Production.Product
WHERE SellEndDate IS NULL AND FinishedGoodsFlag = 1
GROUP BY MakeFlag;
