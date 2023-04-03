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
	avatar image,
	userName varchar(30) not null,
	FOREIGN KEY (userName) REFERENCES Account(userName)
)

insert into Staff values 
('002', N'Khuong Thuy Sau', '2019-09-09', N'47 HVN', '0973310235', '079202034222', '', 'sau'),
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

insert into Customer values ('001', 'Nguyen Anh Vu', 'anhvu@gmail.com', '', '', '0933411234', '079202034551', 235, '0933411234')
insert into Customer values ('002', 'Nguyen Bay Kha', 'Kha7@gmail.com', '', '', '0933411568', '079202039683', 120, '0933411568')

create table ThanhVien (
	idRankingAcc varchar(20) not null primary key,
	points int not null,
	rankingTitle nvarchar(20) not null,
	idCustomer varchar(20) not null,
	FOREIGN KEY (idCustomer) REFERENCES Customer(id),
)

insert into ThanhVien values ('0933411234', 235, N'Thường', '001')
insert into ThanhVien values ('0933411568', 120, N'Thường', '002')

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
	isClean bit not null,
	isOccupied bit not null,	
	idRateByType varchar(20) not null,
	area smallint not null,
	FOREIGN KEY (idRateByType) REFERENCES RoomPrice(idRateByType)
)

insert into Room values 
(101, 'Phong Deluxe Double' , '', 1, 'Deluxe/Twin', 1, 0, 'DLX', 36),
(201, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44),
(102, 'Phong Deluxe Double' , '', 1, 'Deluxe/Twin', 1, 0, 'DLX', 36),
(103, 'Phong Deluxe Double' , '', 1, 'Deluxe/Twin', 1, 0, 'DLX', 36),
(202, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44),
(203, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44),
(301, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52),
(302, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52),
(303, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52)

select * from RoomPrice

create table RoomPrice (
	idRateByType varchar(20) not null primary key,
	baseForHour int null,
	rateForHour int null,
	baseForNight int null,
	baseForDay int null,
	rateForDay int null,
)

insert into RoomPrice values 
('DLX', 100000, 40000, 220000, 330000, 140000),
('SUPER', 140000, 50000, 280000, 360000, 180000)
insert into RoomPrice values 
('SUT', 200000, 120000, 460000, 630000, 340000)

create table RoomExtra (
	idService varchar(20) not null primary key,
	nameService nvarchar(60) not null,
	priceService int not null,
)

insert into RoomExtra values 
('massage-01', N'Massage thư giãn, chỉnh đốt sống', 200000),
('massage-02', N'Massage thư giãn, chỉnh đốt sống, đắp than', 280000),
('BF-01', N'Bữa sáng tại giường SET 1', 80000),
('BF-02', N'Bữa sáng tại giường SET 2', 180000),
('BF-03', N'Bữa sáng tại giường SET 3', 260000)

select * from RoomExtra

create table RoomExtraByRoom (
	idServiceIm varchar(20) not null primary key,
	idService varchar(20) not null,
	roomNum smallint not null,
	idReservation varchar(20) not null,
	FOREIGN KEY (idService) REFERENCES RoomExtra(idService),
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idReservation) REFERENCES Reservation(idReservation)
)
insert into RoomExtraByRoom values 
('Ser-001', 'massage-01', 101, 'Res-001')
insert into RoomExtraByRoom values 
('Ser-002', 'massage-01', 201, 'Res-002')
insert into RoomExtraByRoom values 
('Ser-003', 'BF-01', 201, 'Res-002')

select * from RoomExtraByRoom

--RoomFacility
create table RoomFacility (
	idFacility int not null, 
	nameFacility nvarchar(60) not null,
	roomNum smallint not null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum) 
)

insert into RoomFacility values (1, N'Bồn tắm', 201)
insert into RoomFacility values (2, N'Bồn tắm', 202)
insert into RoomFacility values (3, N'Bồn tắm', 203)
insert into RoomFacility values (4, N'Két sắt nhỏ', 101)
insert into RoomFacility values (5, N'Két sắt nhỏ', 102)
insert into RoomFacility values (6, N'Két sắt nhỏ', 103)
insert into RoomFacility values (7, N'Ban công', 301)
insert into RoomFacility values (8, N'Ban công', 302)
insert into RoomFacility values (9, N'Ban công', 303)
insert into RoomFacility values (10, N'Két sắt vừa', 201)
insert into RoomFacility values (11, N'Két sắt vừa', 202)
insert into RoomFacility values (12, N'Két sắt vừa', 203)
insert into RoomFacility values (13, N'Két sắt vừa', 301)
insert into RoomFacility values (14, N'Két sắt vừa', 302)
insert into RoomFacility values (15, N'Két sắt vừa', 303)
insert into RoomFacility values (16, N'Bồn tắm Massage', 301)
insert into RoomFacility values (17, N'Bồn tắm Massage', 302)
insert into RoomFacility values (18, N'Bồn tắm Massage', 303)


create table RoomCleanByJanitor(
	idCleaning varchar(20) not null primary key,
	idJanitor varchar(20) not null,
	roomNum smallint not null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idJanitor) REFERENCES Janitor(idJanitor)
)

create table Reservation (
	idReservation varchar(20) not null primary key,
	roomNum smallint not null,
	--Service co numRoom de cong tien,
	accomodationType smallint not null,
	--1 = hour, 2=night, 3=day
	checkinDate datetime not null,
	checkoutDate datetime null,
	idCustomer varchar(20) not null,
	idStaff varchar(20) not null,
	totalPrice decimal(18,0) not null,
	paymentStatus bit not null,
	-- 0= processing, 1=complete
	paymentInfo varchar(20) null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idCustomer) REFERENCES Customer(id),
	FOREIGN KEY (idStaff) REFERENCES Staff(id),
)

insert into Reservation values 
('Res-001', 101, 1, '2023-03-24 09:00:00', '2023-03-24 14:00:00', '001', '001', DBO.CalculateTotalByHour(101, '2023-03-24 09:00:00', '2023-03-24 14:00:00'), 1, ''),
('Res-002', 201, 2, '2023-03-24 22:00:00', '2023-03-25 12:00:00', '001', '001', DBO.CalculateTotalByHour(201, '2023-03-24 22:00:00', '2023-03-25 12:00:00'), 1, '')
insert into Reservation values 
('Res-003', 301, 2, '2023-03-24 22:30:00', null, '001', '001', 930000, 0, '')
insert into Reservation values('Res-004', 302, 2, '2023-03-26 22:30:00', null, '001', '001', 930000, 0, '')

drop table Reservation
select * from Reservation
------------------------------FUNCTION------------------------------
--chua hoan thien
create or alter function DBO.CalculateTotalByHour(@roomNum smallint, @checkinDate datetime, @checkoutDate datetime)
Returns decimal(18,3)
as
begin
	DECLARE @IDRate VARCHAR(20), @total decimal(18,3)
	select @IDRate = (select idRateByType from Room where roomNum = @roomNum)
	Select @total = (select (RoomPrice.baseForHour + RoomPrice.rateForHour*(DATEDIFF(hh, @checkinDate, @checkoutDate)-1)) 
							from RoomPrice where idRateByType = @IDRate)
	return @total
end
go

--1. idReceipt 
CREATE OR ALTER FUNCTION DBO.AUTO_idReservation(@createdAt DATETIME)
RETURNS varchar(20)
AS
BEGIN
	DECLARE @CUSTOM_ID VARCHAR(20), @CUSTOM_ID_TIME VARCHAR(20), @COUNT SmallINT
	SELECT @COUNT = (SELECT COUNT(*) FROM Reservation WHERE checkinDate = @createdAt)
	SET @CUSTOM_ID = REPLACE(CONVERT(VARCHAR(20), @createdAt, 103), '/', '')
	SET @CUSTOM_ID_TIME = REPLACE(CONVERT(VARCHAR(20), @createdAt, 108), ':', '')
	RETURN CONCAT(@CUSTOM_ID, @CUSTOM_ID_TIME) + '#' + REPLICATE('0', 2) + CAST(@COUNT + 1 AS VARCHAR(5))
END


--2. idStaff
CREATE OR ALTER FUNCTION DBO.AUTO_idStaff(@dob DATE)
RETURNS varchar(20)
AS
BEGIN
	DECLARE @CUSTOM_ID VARCHAR(20), @COUNT SmallINT
	SELECT @COUNT = (SELECT COUNT(*) FROM Staff WHERE dob = @dob)
	SET @CUSTOM_ID = REPLACE(CONVERT(VARCHAR(20), @dob, 103), '/', '')
	RETURN CONCAT('NV.', @CUSTOM_ID) + '#' + REPLICATE('0', 2) + CAST(@COUNT + 1 AS VARCHAR(5))
END

--3. idCustomer
CREATE OR ALTER FUNCTION DBO.AUTO_idCustomer(@phone varchar(12))
RETURNS varchar(20)
AS
BEGIN
	DECLARE @CUSTOM_ID VARCHAR(20), @COUNT SmallINT
	SELECT @COUNT = (SELECT COUNT(*) FROM Reservation, Customer WHERE Reservation.idCustomer = Customer.id and customer.phone = @phone)
	RETURN CONCAT('KH.', @phone) + '#' + REPLICATE('0', 2) + CAST(@COUNT + 1 AS VARCHAR(5))
END

--4. idRooomService
CREATE OR ALTER FUNCTION DBO.AUTO_idRooomService(@roomNum smallint)
RETURNS varchar(20)
AS
BEGIN
	DECLARE @CUSTOM_ID VARCHAR(20), @COUNT SmallINT
	SELECT @COUNT = (SELECT COUNT(*) FROM Reservation WHERE roomNum = @roomNum)
	SET @CUSTOM_ID = REPLACE(CONVERT(VARCHAR(20), @roomNum, 103), '/', '')
	RETURN CONCAT('SV', @CUSTOM_ID) + '#' + REPLACE(CONVERT(VARCHAR(20), GETDATE(), 103), '/', '') + '.' + REPLICATE('0', 2) + CAST(@COUNT + 1 AS VARCHAR(5))
END

print DBO.AUTO_idRooomService(203)

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
	if @attempts >= 1
		UPDATE Account SET isLocked = 0 where userName = @username
go

-- PROC lock acc on purpose
create or alter PROC USP_LockWantedAccount
	@username varchar(30)
as
		UPDATE Account SET isLocked = 1 where userName = @username
		UPDATE Account SET attempts = 0 where userName = @username
go

--1 PROC List Staff
create or alter proc USP_GetStaff
as
	select *, Account.isLocked from Staff, Account where Staff.userName = Account.userName
go

select * from staff
--1. PROC Them NV
CREATE or alter proc USP_InsertStaff 
	@fullname nvarchar(60),
	@dob date,
	@address nvarchar(100),
	@phone varchar(12),
	@cmnd varchar(20)
AS
	insert into Account values (@cmnd, 'NhanVien', '123', 2, 0, 3)
	insert into Staff values (DBO.AUTO_idStaff(@dob), @fullname, @dob, @address, @phone, @cmnd, '', @cmnd)
go

--2. PROC Tim kiem NV
CREATE proc USP_SearchStaff 
	@name nvarchar(60)
as
	select * from staff where fullname = @name
go

--3. PROC Load Room
CREATE or alter proc USP_GetRoom
as
	select * from room
go

--4. PROC Lay doanhthu theo ngay
CREATE or alter proc USP_GetReportRevenueByDate
	@fromDate date,
	@toDate date
as
	select * from Reservation where checkinDate > @fromDate and checkinDate < @toDate and paymentStatus = 1
go

--5. PROC lay 3 bang service
create or alter proc USP_GetRoomExtraPriceByReservation
	@idReservation varchar(20)
as
	select * from RoomExtraByRoom rB, RoomExtra ex where rB.idReservation = @idReservation and rB.idService = ex.idService
go

select * from Account
select * from Staff
select * from Reservation
exec USP_GetReportRevenueByDate '2023-03-24', '2023-03-25'



------------------------------END PROC------------------------------
