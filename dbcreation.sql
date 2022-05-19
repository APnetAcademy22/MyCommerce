use mycommerce
--CREATE TABLE Products(
--	C8				char(8)		NOT NULL PRIMARY KEY,
--	Title			varchar(128) NOT NULL,
--	Description		varchar(1024),
--	ImageUrl		varchar(2048)
--	);

--CREATE TABLE PriceLists(
--	C8	char(8) NOT NULL REFERENCES Products,
--	Country varchar(10) NOT NULL,
--	Currency varchar(10) NOT NULL,
--	Price	decimal(12,2) NOT NULL,
--	PRIMARY KEY (C8, Country, Currency) );

--CREATE TABLE Customers(
--	IDCustomer		int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	Email	varchar(100) NOT NULL UNIQUE,
--	Name	varchar(100) NOT NULL,
--	Surname varchar(100) NOT NULL,
--	BirthDate date NOT NULL )

--CREATE TABLE Orders(
--	IDOrder		int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	IDCustomer	int NOT NULL REFERENCES Customers,
--	C8			char(8) NOT NULL REFERENCES Products,
--	Date		DATETIME NOT NULL,
--	Price		decimal(12,2) NOT NULL );
select*from customers;
select*from Products;
select*from orders;
select*from pricelists;
