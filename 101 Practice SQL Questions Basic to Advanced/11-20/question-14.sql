-- a. Which Purchasing vendors have the highest credit rating?
SELECT
    Name,
    CreditRating
FROM Purchasing.Vendor
WHERE CreditRating = 1
ORDER BY CreditRating ASC;

-- b. Using a case statement replace the 1 and 0 in Vendor.PreferredVendorStatus
-- to "Preferred" vs "Not Preferred." How many vendors are considered Preferred?
SELECT
    CASE
        WHEN PreferredVendorStatus = 1 THEN 'Preferred'
        ELSE 'Not preferred'
    END AS PreferredStatus,
    COUNT(*) VendorsCount
FROM Purchasing.Vendor
GROUP BY
    CASE
        WHEN PreferredVendorStatus = 1 THEN 'Preferred'
        ELSE 'Not preferred'
    END;

-- c. For Active Vendors only, do Preferred vendors have a High or lower average credit rating?
SELECT
    CASE
        WHEN PreferredVendorStatus = 1 THEN 'Preferred'
        ELSE 'Not preferred'
    END AS Status,
    AVG(CAST(CreditRating AS DECIMAL)) AS AvgRating
FROM Purchasing.Vendor
WHERE ActiveFlag = 1
GROUP BY
    CASE
        WHEN PreferredVendorStatus = 1 THEN 'Preferred'
        ELSE 'Not preferred'
    END;

-- d. How many vendors are active and Not Preferred?
SELECT
    COUNT(*) AS ActiveNotPreferredCount
FROM Purchasing.Vendor
WHERE ActiveFlag = 1 AND PreferredVendorStatus = 0;
