
use mastergo
go

create database Users
go

use Users
go

create table Users
(
	Id int not null primary key identity,
	Login nvarchar(100) not null unique,
	Password nvarchar(max) not null,
	Adress nvarchar(200) not null,
	Phone nvarchar(16) not null unique,
	Role nvarchar(100) not null
)
go	


INSERT INTO Users (Login, Password, Adress, Phone, Role) VALUES
    ('john_doe', 'password123', '123 Main St, Anytown', '+1235567890', 'administrator'),
    ('jane_smith', 'p@ssw0rd', '456 Elm St, Sometown', '+0987454321', 'user'),
    ('michael_johnson', 'secure_password', '789 Oak St, Othertown', '+11120263334', 'user'),
    ('alice_williams', 'strongpassword', '321 Pine St, Another Town', '+4405556667', 'moderator'),
    ('robert_brown', 'mypassword123', '987 Maple St, Different Town', '+7778887990', 'user'),
    ('emily_davis', 'pass123', '654 Birch St, New Town', '+3334445456', 'administrator'),
    ('william_taylor', 'password!123', '753 Cedar St, Old Town', '+2233834445', 'user'),
    ('sophia_miller', '1234567890', '852 Spruce St, Ancient Town', '+6627778889', 'user'),
    ('david_anderson', 'secure123', '159 Fir St, Historic Town', '+1121223334', 'user'),
    ('olivia_wilson', 'password', '456 Oak St, Vintage Town', '+4445557667', 'moderator');
go