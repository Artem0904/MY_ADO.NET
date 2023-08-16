use master
go

create database Library
go

use Library

create table Countries
(
	Id int not null primary key identity,
	Name nvarchar(100) not null unique
)
go

create table Authors
(
	Id int not null primary key identity,
	Name nvarchar(100) not null,
	Surname nvarchar(100) not null,
	CountryId int references Countries(Id)
)
go

create table Books
(
	Id int not null primary key identity,
	Name nvarchar(100) not null unique,
	CountPages int not null check(CountPages > 0),
	AuthorId int references Authors(Id)
)
go



-- Insert values into Countries table
INSERT INTO Countries (Name)
VALUES
    ('United States'),
    ('United Kingdom'),
    ('Canada'),
    ('Australia'),
    ('Germany'),
    ('France'),
    ('Japan'),
    ('China'),
    ('India'),
    ('Brazil');
go

-- Insert values into Authors table
INSERT INTO Authors (Name, Surname, CountryId)
VALUES
    ('John', 'Smith', 1),
    ('Emily', 'Johnson', 2),
    ('Michael', 'Williams', 3),
    ('Emma', 'Brown', 4),
    ('David', 'Jones', 5),
    ('Sophia', 'Garcia', 6),
    ('Daniel', 'Martinez', 7),
    ('Olivia', 'Lopez', 8),
    ('Matthew', 'Hernandez', 9),
    ('Ava', 'Gonzalez', 10);
go

-- Insert values into Books table
INSERT INTO Books (Name, CountPages, AuthorId)
VALUES
    ('The Great Gatsby', 180, 1),
    ('Pride and Prejudice', 279, 2),
    ('To Kill a Mockingbird', 336, 3),
    ('1984', 328, 4),
    ('The Catcher in the Rye', 224, 5),
    ('Harry Potter and the Sorcerer''s Stone', 320, 6),
    ('The Hobbit', 310, 7),
    ('The Da Vinci Code', 454, 8),
    ('The Alchemist', 197, 9),
    ('The Little Prince', 96, 10);
go
