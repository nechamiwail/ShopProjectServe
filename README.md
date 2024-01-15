Clone the repository from git clone https://github.com/nechamiwail/ShopProjectServer.git

Open the sln in VS

I am sharing here the code I put in SQL:


CREATE DATABASE SHOP

GO

USE SHOP

GO


CREATE TABLE Orders(

 Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
 
 FullName nvarchar(50) NOT NULL,
 
 Email nvarchar(max) NOT NULL,
 
 Address nvarchar(max) NOT NULL,
 
 Product nvarchar(max) NULL,

 Orders uniqueidentifier DEFAULT NEWID() NOT NULL

)

GO


INSERT INTO Orders (FullName, Email, Address, Product)

VALUES ('Israel Israeli', 'm@m.com', 'Ramot', 'suger');

GO
