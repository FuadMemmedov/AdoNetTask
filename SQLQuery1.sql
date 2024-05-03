create database ProductDb

use ProductDb

Create table Categories(
Id int primary key identity,
Name nvarchar(50)

)

Create table Products(
Id int primary key identity,
Name nvarchar(50),
Price decimal(18,2),
CategoryId int foreign key references Categories(Id)




)


Select * from Categories
Select * from Products
