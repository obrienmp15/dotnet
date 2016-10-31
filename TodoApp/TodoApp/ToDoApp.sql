use master;

CREATE database ItemsDB
go

use ItemsDB;
go

CREATE schema Items;
go

CREATE TABLE Items.Items
(
    ItemId int not null identity(1,1) primary key
    ,ItemName nvarchar(250) not null
    ,Complete bit not null
    ,Active bit not null
);









