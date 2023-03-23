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

insert into Staff values 
('001', N'Bicpeo', '2002-09-29', N'25 TNV', '0973310071', '079202034567', '', 'bao')

create table Customer (
	id varchar(20) not null primary key,
	fullName nvarchar(60) not null,
	email varchar(60) not null,
	dob date null,
	address nvarchar(100),
	phone varchar(12) not null,
	cmnd varchar(20) not null,
	points int not null,
	idRankingAcc varchar(20) not null,
)

insert into Customer values 
('001', 'Nguyen Anh Vu', 'anhvu@gmail.com', '', '', '0933411234', '079202034551', 235, '0933411234')

create table Janitor (
	idJanitor varchar(20) not null primary key,
	fullName nvarchar(60) not null,
	dob date not null,
	address nvarchar(100),
	phone varchar(12) not null,
	cmnd varchar(20) not null
)

insert into Janitor values 
('001', 'Nguyen trac', '1996-07-08', '19 NHT', '1234567890', '079202034726')

create table Room (
	roomNum smallint not null primary key,
	roomName nvarchar(60) not null,
	roomImage varchar(255) null,
	idType varchar(20) not null,
	typeName nvarchar(60) not null,
	area smallint not null,
	isClean bit not null,
	isOccupied bit not null,	
	idRateByType varchar(20) not null,
	FOREIGN KEY (idRateByType) REFERENCES RoomPrice(idRateByType)
)

insert into Room values 
(101, 'Phong Deluxe Double' , '', 1)

create table RoomPrice (
	idRateByType varchar(20) not null primary key,
	baseForHour int null,
	rateForHour int null,
	baseForNight int null,
	baseForDay int null,
	rateForDay int null,
)

create table RoomExtra (
	idService varchar(20) not null primary key,
	nameService nvarchar(60) not null,
	priceService int not null,
)

create table RoomCleanByJanitor(
	idCleaning varchar(20) not null primary key,
	idJanitor varchar(20) not null,
	roomNum smallint not null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idJanitor) REFERENCES Janitor(idJanitor)
)

create table RoomExtraByRoom (
	idServiceIm varchar(20) not null primary key,
	idService varchar(20) not null,
	roomNum smallint not null,
	FOREIGN KEY (idService) REFERENCES RoomExtra(idService),
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum)
)

create table Reservation (
	idReservation varchar(20) not null primary key,
	roomNum smallint not null,
	idServiceIm varchar(20) not null,
	checkinDate datetime not null,
	checkoutDate datetime not null,
	idCustomer varchar(20) not null,
	idStaff varchar(20) not null,
	totalPrice decimal(18,0) not null,
	paymentInfo varchar(20) null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idServiceIm) REFERENCES RoomExtraByRoom(idServiceIm),
	FOREIGN KEY (idCustomer) REFERENCES Customer(id),
	FOREIGN KEY (idStaff) REFERENCES Staff(id)
)
------------------------------FUNCTION------------------------------



------------------------------END FUNCTION------------------------------

------------------------------PROC------------------------------
-- PROC Giam Attempts va Lock Acc khi nhap sai
create or alter PROC USP_DecreaseAttempsOrLockAccount
	@username varchar(30)
as
	declare @attempts smallint
	set @attempts = (Select attempts from Account where userName = @username)

	if @attempts >= 1
		UPDATE Account SET attempts = attempts - 1 where userName = @username
		set @attempts = (Select attempts from Account where userName = @username)
		if @attempts = 0
				UPDATE Account SET isLocked = 1 where userName = @username
go

-- PROC Reset Attempts khi unlock acc
create or alter PROC USP_ResetAttempsOrUnlockAccount
	@username varchar(30)
as
	declare @attempts smallint
	set @attempts = (Select attempts from Account where userName = @username)

	if @attempts < 1
		UPDATE Account SET isLocked = 0 where userName = @username
		UPDATE Account SET attempts = 3 where userName = @username
go

exec USP_DecreaseAttempsOrLockAccount 'sau'
exec USP_ResetAttempsOrUnlockAccount 'sau'
select * from account

------------------------------END PROC------------------------------
