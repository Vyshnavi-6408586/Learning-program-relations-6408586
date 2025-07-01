CREATE TABLE Headsets (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Brand VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
INSERT INTO Headsets (ProductID, ProductName, Brand, Category, Price) VALUES
(1, 'boAt Rockerz 550', 'boAt', 'Wireless Headphones', 1999.00),
(2, 'boAt Nirvana 751 ANC', 'boAt', 'Wireless Headphones', 3999.00),
(3, 'boAt Immortal 1300', 'boAt', 'Gaming Headphones', 3499.00),
(4, 'boAt Rockerz 450 Pro', 'boAt', 'Wireless Headphones', 2499.00),
(5, 'Noise One', 'Noise', 'Wireless Headphones', 2499.00),
(6, 'Noise Defy', 'Noise', 'Wireless Headphones', 3499.00),
(7, 'Noise Two', 'Noise', 'Wireless Headphones', 2999.00),
(8, 'Noise Combat', 'Noise', 'Gaming Headphones', 3799.00),
(9, 'Boult Audio ProBass', 'Boult', 'Wireless Headphones', 1899.00),
(10, 'Boult Curve ANC', 'Boult', 'Wireless Headphones', 2699.00),
(11, 'Boult Anchor', 'Boult', 'Wireless Headphones', 3199.00),
(12, 'Boult BassBuds X1', 'Boult', 'Wired Headphones', 999.00);
SELECT 
    ProductID,
    ProductName,
    Brand,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Headsets;
SELECT 
    ProductID,
    ProductName,
    Brand,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankByPrice,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankByPrice
FROM Headsets
ORDER BY Category, Price DESC;
SELECT 
    ProductID,
    ProductName,
    Brand,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankInCategory,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankInCategory
FROM Headsets
ORDER BY Category, RankInCategory;