create database Hotel
go

use Hotel
go

create table Account (
	userName varchar(30) not null,
	password varchar(max) not null,
	displayName nvarchar(60) not null,
	type smallint not null,
	isLocked bit not null,
	attempts smallint not null,
	primary key(userName)
)

insert into Account values
('kt', '1', N'KienTran', 1, 0, 3),
('bao', '1', N'Bicpeo', 2, 0, 3),
('sau', '1', N'Sau Khuong', 2, 1, 3)

select * from Account

create table Staff (
	id varchar(20) not null primary key,
	fullName nvarchar(60) not null,
	dob date not null,
	address nvarchar(100),
	phone char(12) not null,
	cmnd varchar(20) not null,
	avatar varchar(60),
	userName varchar(30) not null,
	FOREIGN KEY (userName) REFERENCES Account(userName)
)

create table Customer (
	id varchar(20) not null primary key,
	fullName nvarchar(60) not null,
	email varchar(60) not null,
	dob date not null,
	address nvarchar(100),
	phone varchar(12) not null,
	cmnd varchar(20) not null,
	points int not null,
	idRankingAcc varchar(20) not null,
)