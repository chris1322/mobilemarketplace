select * from Users;
select * from Phones;

CREATE TABLE Phones (
    PhoneId INT PRIMARY KEY IDENTITY(1,1),
    PhoneModel NVARCHAR(100) NOT NULL,
    Brand NVARCHAR(50) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Condition NVARCHAR(20) NOT NULL,
    Description NVARCHAR(MAX),
    SellerContact NVARCHAR(100) NOT NULL,
    Available BIT NOT NULL DEFAULT 1,
    DateListed DATETIME NOT NULL DEFAULT GETDATE()
);

INSERT INTO Phones (PhoneModel, Brand, Price, Condition, Description, SellerContact, Available)
VALUES ('iPhone 12', 'Apple', 799.99, 'Like New', 'iPhone 12, minimal usage.', 'contact@apple.com', 1);

INSERT INTO Phones (PhoneModel, Brand, Price, Condition, Description, SellerContact, Available)
VALUES ('Galaxy S21', 'Samsung', 699.99, 'Used', 'Galaxy S21 with minor scratches.', 'contact@samsung.com', 1);

ALTER TABLE Users
ADD FirstName NVARCHAR(50),
    LastName NVARCHAR(50);

    select * from Users;
select * from Phones;

UPDATE Users
SET FirstName = 'Test', LastName = 'User'
WHERE UserId = 1;

UPDATE Users
SET FirstName = 'Kyle', LastName = 'Turnbull'
WHERE UserId = 2;