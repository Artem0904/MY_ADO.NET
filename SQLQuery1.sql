use master
go

create database Sales
go

--Таблиця Покупці. Стовпці: ідентифікатор, ім'я, прізвище;
--Таблиця Продавці. Стовпці: ідентифікатор, ім'я, прізвище;
--Таблиця Продажі. Стовпці: ідентифікатор продажі, ідентифікатор покупця,
--ідентифікатор продавця, сума продажі, дата продажі.

select * from Customers
select * from Sellers
select * from Sales

create table Customers
(
	Id int not null primary key identity,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)
go

create table Sellers
(
	Id int not null primary key identity,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null
)
go

create table Sales
(
	Id int not null primary key identity,
	CustomerId int not null references Customers(Id),
	SellerId int not null references Sellers(Id),
	SumSale money not null,
	DateSale date not null
)
go

-- Insert 10 values in to Customers table
INSERT INTO Customers (Name, Surname)
VALUES
    ('John', 'Doe'),
    ('Jane', 'Smith'),
    ('Michael', 'Johnson'),
    ('Emily', 'Brown'),
    ('David', 'Davis'),
    ('Sarah', 'Miller'),
    ('Daniel', 'Wilson'),
    ('Olivia', 'Anderson'),
    ('William', 'Clark'),
    ('Sophia', 'Lee')
go

-- Insert 10 values into Sellers table
INSERT INTO Sellers (Name, Surname)
VALUES
    ('Robert', 'Taylor'),
    ('Emma', 'Thomas'),
    ('Joseph', 'White'),
    ('Mia', 'Hall'),
    ('James', 'Moore'),
    ('Abigail', 'Martin'),
    ('Benjamin', 'Thompson'),
    ('Grace', 'Walker'),
    ('Ethan', 'Allen'),
    ('Elizabeth', 'Baker')
go

-- Insert 10 values into Sales table
INSERT INTO Sales (CustomerId, SellerId, SumSale, DateSale)
VALUES
    (1, 1, 100.00, '2023-01-01'),
    (2, 2, 200.00, '2023-01-02'),
    (3, 3, 300.00, '2023-01-03'),
    (4, 4, 400.00, '2023-01-04'),
    (5, 5, 500.00, '2023-01-05'),
    (6, 6, 600.00, '2023-01-06'),
    (7, 7, 700.00, '2023-01-07'),
    (8, 8, 800.00, '2023-01-08'),
    (9, 9, 900.00, '2023-01-09'),
    (10, 10, 1000.00, '2023-01-10')
go
