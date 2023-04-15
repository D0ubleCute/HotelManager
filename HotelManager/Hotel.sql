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

insert into Customer values ('', 'NaN', 'NaN', '', '', '', 'NaN', 0, 'NaN')
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


create table VatTu(
	idVatTu varchar(20) not null primary key,
	nameVatTu nvarchar(60) not null,
	qtyVatTu int not null,
	statusVatTu smallint --1 normal, 2 sap het, 0 la het
)

insert into VatTu values('VT-01', N'Gối đầu', 300, 1)
insert into VatTu values('VT-02', N'Chăn', 300, 1)
insert into VatTu values('VT-03', N'Drap Giường Nhỏ', 100, 1)
insert into VatTu values('VT-04', N'Drap Giường Vừa', 100, 1)
insert into VatTu values('VT-05', N'Drap Giường Lớn', 100, 1)
insert into VatTu values('VT-06', N'Khăn tắm', 300, 1)
insert into VatTu values('VT-07', N'Bàn chải', 300, 1)
insert into VatTu values('VT-08', N'Thảm', 300, 1)
insert into VatTu values('VT-09', N'Máy sấy', 63, 1)
insert into VatTu values('VT-10', N'Giấy cuộn', 240, 1)


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
(201, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44)
insert into Room values
(102, 'Phong Deluxe Double' , '', 1, 'Deluxe/Twin', 1, 0, 'DLX', 36),
(103, 'Phong Deluxe Double' , '', 1, 'Deluxe/Twin', 1, 0, 'DLX', 36),
(202, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44),
(203, 'Phong Superior Double' , '', 2, 'Superior', 1, 0, 'SUPER', 44),
(301, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52),
(302, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52),
(303, 'Phong Suite King', '', 3, 'Suite', 1, 0, 'SUT', 52)
insert into Room values
(401, 'Phong Suite King & Queen', '', 4, 'Suite/Double', 1, 0, 'SUT', 60),
(402, 'Phong Suite King & Queen', '', 4, 'Suite/Double', 1, 0, 'SUT', 60),
(403, 'Phong Suite King & Queen', '', 4, 'Suite/Double', 1, 0, 'SUT', 60)


create table RoomThings (
	id int not null primary key identity(1,1), 
	roomNum smallint not null,
	idVatTu varchar(20) not null,
	qtyVatTuByRoom smallint not null
	FOREIGN KEY (idVatTu) REFERENCES VatTu(idVatTu),
)

insert into RoomThings values(101, 'VT-01', 3)
insert into RoomThings values(102, 'VT-01', 3)
insert into RoomThings values(103, 'VT-01', 3)

insert into RoomThings values(101, 'VT-07', 2)
insert into RoomThings values(102, 'VT-07', 2)
insert into RoomThings values(103, 'VT-07', 2)

insert into RoomThings values(101, 'VT-10', 2)
insert into RoomThings values(102, 'VT-10', 2)
insert into RoomThings values(103, 'VT-10', 2)

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

select * from RoomPrice


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
insert into RoomExtra values('YEAH-1', N'Trang trí theo chủ đề SET 1', 300000)
insert into RoomExtra values('YEAH-2', N'Trang trí theo chủ đề SET 2', 460000)
insert into RoomExtra values('BAR', N'Bartender phục vụ', 810000)


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
	idFacility int not null primary key identity(1,1), 
	nameFacility nvarchar(60) not null,
	roomNum smallint not null,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum) 
)

insert into RoomFacility values (N'Bồn tắm', 201)
insert into RoomFacility values (N'Bồn tắm', 202)
insert into RoomFacility values (N'Bồn tắm', 203)
insert into RoomFacility values (N'Két sắt nhỏ', 101)
insert into RoomFacility values (N'Két sắt nhỏ', 102)
insert into RoomFacility values (N'Két sắt nhỏ', 103)
insert into RoomFacility values (N'Ban công', 301)
insert into RoomFacility values (N'Ban công', 302)
insert into RoomFacility values (N'Ban công', 303)
insert into RoomFacility values (N'Két sắt vừa', 201)
insert into RoomFacility values (N'Két sắt vừa', 202)
insert into RoomFacility values (N'Két sắt vừa', 203)
insert into RoomFacility values (N'Két sắt vừa', 301)
insert into RoomFacility values (N'Két sắt vừa', 302)
insert into RoomFacility values (N'Két sắt vừa', 303)
insert into RoomFacility values (N'Bồn tắm Massage', 301)
insert into RoomFacility values (N'Bồn tắm Massage', 302)
insert into RoomFacility values (N'Bồn tắm Massage', 303)
insert into RoomFacility values (N'TV', 101)
insert into RoomFacility values (N'TV', 102)
insert into RoomFacility values (N'TV', 103)
insert into RoomFacility values (N'TV', 201)
insert into RoomFacility values (N'TV', 202)
insert into RoomFacility values (N'TV', 203)
insert into RoomFacility values (N'TV', 301)
insert into RoomFacility values (N'TV', 302)
insert into RoomFacility values (N'TV', 303)


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
	idCustomer varchar(20) null,
	idStaff varchar(20) not null,
	totalPrice decimal(18,0) not null,
	paymentStatus bit not null,
	-- 0= processing, 1=complete
	paymentInfo varchar(20) null,
	checkoutDateInit datetime,
	FOREIGN KEY (roomNum) REFERENCES Room(roomNum),
	FOREIGN KEY (idCustomer) REFERENCES Customer(id),
	FOREIGN KEY (idStaff) REFERENCES Staff(id),
)

insert into Reservation values 
('Res-001', 101, 1, '2023-03-24 09:00:00', '2023-03-24 14:00:00', '001', '001', DBO.CalculateTotalByHour(101, '2023-03-24 09:00:00', '2023-03-24 14:00:00'), 1, ''),
('Res-002', 201, 2, '2023-03-24 22:00:00', '2023-03-25 12:00:00', '001', '001', DBO.CalculateTotalByHour(201, '2023-03-24 22:00:00', '2023-03-25 12:00:00'), 1, '')

insert into Reservation values ('Res-003', 301, 2, '2023-03-24 22:30:00', null, '001', '001', 930000, 0, '')
insert into Reservation values('Res-004', 302, 2, '2023-03-26 22:30:00', null, '001', '001', 930000, 0, '')

insert into Reservation values(DBO.AUTO_idReservation('2023-01-26 10:00:00'), 302, 1, '2023-01-26 10:00:00', '2023-01-26 14:00:00', '001', '001', DBO.CalculateTotalByHour(302, '2023-01-26 10:00:00', '2023-01-26 14:00:00'), 1, 'cash')

insert into Reservation values(DBO.AUTO_idReservation('2022-12-24 22:00:00'), 202, 2, '2022-12-24 22:00:00', '2022-12-25 10:00:00', '001', '001', DBO.CalculateTotalByHour(202, '2022-12-24 22:00:00', '2022-12-25 10:00:00'), 1, 'cash')

insert into Reservation values(DBO.AUTO_idReservation('2022-11-26 10:00:00'), 203, 3, '2023-01-26 14:00:00', '2023-01-29 12:00:00', '001', '001', DBO.CalculateTotalByHour(203, '2023-01-26 14:00:00', '2023-01-29 12:00:00'), 1, 'cash')

insert into Reservation values(DBO.AUTO_idReservation('2023-02-14 19:00:00'), 102, 1, '2023-02-14 19:00:00', '2023-02-14 23:00:00', '001', '001', DBO.CalculateTotalByHour(102, '2023-02-14 19:00:00', '2023-02-14 23:00:00'), 1, 'cash')


select * from Room
drop table Reservation
select * from Reservation

------------------------------FUNCTION------------------------------
--TINH TIEN PHONG GIO
create or alter function DBO.CalculateTotalByHour(@roomNum smallint, @checkinDate datetime, @checkoutDate datetime)
Returns decimal(10,3)
as
begin
	DECLARE @IDRate VARCHAR(20), @total decimal(10,3)
	select @IDRate = (select idRateByType from Room where roomNum = @roomNum)

	if DATEPART(minute, @checkoutDate) >= 5
		select @checkoutDate = Dateadd(hour, 1, @checkoutDate)

	Select @total = (select (RoomPrice.baseForHour + RoomPrice.rateForHour*(DATEDIFF(hh, @checkinDate, @checkoutDate))) 
							from RoomPrice where idRateByType = @IDRate)
	return @total
end
go

print DBO.CalculateTotalByHour(101, '2022-12-24 09:00:00', '2022-12-24 11:32:00')

--TINH TIEN PHONG DEM
create or alter function DBO.CalculateTotalByNight(@roomNum smallint, @checkinDate datetime, @checkoutDate datetime)
Returns decimal(10,3)
as
begin
	DECLARE @IDRate VARCHAR(20), @total decimal(10,3), @initCheckoutDate datetime, @extendHour smallint

	select @initCheckoutDate = dateadd(HOUR, 12, @checkinDate)

	select @IDRate = (select idRateByType from Room where roomNum = @roomNum)

	select @total = (select RoomPrice.baseForNight from RoomPrice where idRateByType = @IDRate)

	if @checkoutDate > @initCheckoutDate
		if DATEPART(minute, @checkoutDate) < 5 
			Select @total = (select (@total + RoomPrice.rateForHour*(DATEDIFF(hh, @initCheckoutDate, @checkoutDate))) 
							from RoomPrice where idRateByType = @IDRate)

		else if DATEPART(minute, @checkoutDate) >= 5 
			Select @total = (select (@total + RoomPrice.rateForHour*(DATEDIFF(hh, @initCheckoutDate, @checkoutDate) + 1)) 
							from RoomPrice where idRateByType = @IDRate)
	return @total
end
go
select * from RoomPrice
print DBO.CalculateTotalByNight(101, '2022-12-24 22:00:00', '2022-12-25 15:10:00')
select * from RoomPrice

declare @num_hours int; 
    set @num_hours = 18; 

select dateadd(HOUR, @num_hours, getdate()) as time_added, 
       getdate() as curr_date 

--TINH TIEN PHONG NGAY --chua hoan thien
create or alter function DBO.CalculateTotalByDay(@roomNum smallint, @checkinDate datetime, @checkoutDate datetime)
Returns decimal(10,3)
as
begin
	DECLARE @IDRate VARCHAR(20), @total decimal(10,3), @initCheckoutDate datetime, @extendHour smallint

	select @initCheckoutDate = dateadd(HOUR, 22, @checkinDate)

	select @IDRate = (select idRateByType from Room where roomNum = @roomNum)

	select @total = (select RoomPrice.baseForDay from RoomPrice where idRateByType = @IDRate)

	if @checkoutDate > @initCheckoutDate
		if DATEPART(minute, @checkoutDate) < 5 
			Select @total = (select (@total + RoomPrice.rateForHour*(DATEDIFF(hh, @initCheckoutDate, @checkoutDate))) 
							from RoomPrice where idRateByType = @IDRate)

		else if DATEPART(minute, @checkoutDate) >= 5 
			Select @total = (select (@total + RoomPrice.rateForHour*(DATEDIFF(hh, @initCheckoutDate, @checkoutDate) + 1)) 
							from RoomPrice where idRateByType = @IDRate)
	return @total
end
go

print DBO.CalculateTotalByDay(103, '2023-01-26 14:00:00', '2023-01-29 12:00:00', '2023-01-29 12:00:00')

--1. idRes 
create or ALTER FUNCTION AUTO_idReservation(@createdAt DATE)
RETURNS varchar(20)
AS
BEGIN
	DECLARE @CUSTOM_ID VARCHAR(20), @CUSTOM_ID_TIME VARCHAR(20), @COUNT SmallINT
	SELECT @COUNT = (SELECT COUNT(*) FROM Reservation WHERE (SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, checkinDate))) = @createdAt)
	SET @CUSTOM_ID = REPLACE(CONVERT(VARCHAR(20), @createdAt, 103), '/', '')
	RETURN @CUSTOM_ID + '#' + REPLICATE('0', 2) + CAST(@COUNT + 1 AS VARCHAR(5))
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

------------------------------BEGIN PROC------------------------------
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

--2. PROC NHANVIEN
--2.1 PROC Tim NV
CREATE proc USP_SearchStaff 
	@name nvarchar(60)
as
	select * from staff where fullname = @name
go

----------------------------------------------------------------------------------
--3. PROC Load Room
CREATE or alter proc USP_GetRoom
as
	select * from room
go

----------------------------------------------------------------------------------
--4. PROC DOANH THU
--4.1 Lay doanhthu theo ngay
CREATE or alter proc USP_GetReportRevenueByDate
	@fromDate date,
	@toDate date
as
	select * from Reservation where checkinDate >= @fromDate and checkinDate <= @toDate and paymentStatus = 1 ORDER BY checkinDate ASC
go

--4.2 Lay doanhthu theo thang
CREATE or alter proc USP_GetReportRevenueByMonth
	@fromDate date,
	@toDate date
as
	select * from Reservation where checkinDate >= (select month(@fromDate), year(@fromDate)) and checkinDate <= (select month(@toDate), year(@fromDate)) and paymentStatus = 1 ORDER BY checkinDate ASC
go
----------------------------------------------------------------------------------
--5. PROC SERVICE
--5.1 lay 3 bang service
create or alter proc USP_GetRoomExtraPriceByReservation
	@idReservation varchar(20)
as
	select rb.idServiceIm, rb.idService, rb.roomNum, rb.idReservation, ex.nameService, ex.priceService 
	from RoomExtraByRoom rB, RoomExtra ex where rB.idReservation = @idReservation and rB.idService = ex.idService
go

--6. PROC RESERVATION
--6.1 THEM Reservation chua co 
CREATE or alter proc USP_InsertReservation 
	@roomNum smallint,
	@accoType smallint,
	@checkIn datetime,
	@checkOutInit datetime,
	@checkOutReal datetime,
	@idCus varchar(20),
	@idStaff varchar(20),
	@totalPrice decimal(10,2),
	@status bit,
	@info varchar(20)
AS
	insert into dbo.Reservation values (DBO.AUTO_idReservation(@checkIn), @roomNum, @accoType, @checkIn, @checkOutInit, @idCus, @idStaff, @totalPrice, 0, '' ,@checkOutReal)
go

------------------------------END PROC------------------------------

------------------------------BEGIN TRIGGER------------------------------
create or alter trigger UTG_CreateReservationAndChangeOccupation
on dbo.Reservation for insert
as
begin
	declare @roomNum smallint

	select @roomNum = roomNum from inserted

	update dbo.Room set isOccupied = 1, isClean = 0 where roomNum = @roomNum
end
go

create or alter trigger UTG_CloseReservationAndChangeOccupation
on dbo.Reservation for update
as
begin
	declare @roomNum smallint

	select @roomNum = roomNum from inserted

	update dbo.Room set isOccupied = 0, isClean = 1 where roomNum = @roomNum
end
go
select * from reservation
create trigger UTG_UpdateRoomServiceInfo
on dbo.RoomExtraByRoom for insert, update
as
begin
	declare @idReservation varchar(20)

	select @idReservation = idReservation from inserted

	declare @roomNum smallint

	select @roomNum = roomNum from dbo.Reservation where idReservation = @idReservation and paymentStatus = 0 

end
go
select * from reservation