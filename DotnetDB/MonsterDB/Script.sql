CREATE schema Monster;
go

CREATE TABLE Monster.Monster
(
    MonsterId int not null identity(1,1)
    ,GenderId int null 
    ,TitleId int null
    ,TypeId int not null
    ,Name nvarchar(250) not null
    ,PicturePath nvarchar(256) null 
    ,Active bit not null
);
go
CREATE TABLE Monster.MonsterType
(
    MonsterTypeId int not null identity(1,1) primary key 
    ,TypeName nvarchar(250) not null
    ,Active bit not null 
);
go
CREATE TABLE Monster.Gender
(
    GenderId int not null identity(1,1) primary key
    ,GenderName nvarchar(250) not null
    ,Active bit not null
);
go
CREATE TABLE Monster.Title
(
    TitleId int not null identity(1,1) primary key
    ,TitleName nvarchar(250) not null
    ,Active bit not null
);
go

ALTER TABLE Monster.Monster
    add constraint pk_monster_monsterid primary key clustered (MonsterId);
go
ALTER TABLE Monster.Monster
    add constraint fk_monster_genderid foreign key (GenderId) references Monster.Gender (GenderId);
go
ALTER TABLE Monster.Monster
    add constraint fk_monster_titleid foreign key (TitleId) references Monster.Title (TitleId);
go
ALTER TABLE Monster.Monster
    add constraint fk_monster_typeid foreign key (TypeId) references Monster.MonsterType (MonsterTypeId);
go

