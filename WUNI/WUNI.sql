
CREATE TABLE WorkerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	WorkerID varchar(10)
);

Insert into WorkerAccount(UserName,Passwords,WorkerID)
values ('Quang1','123456','1');


CREATE TABLE CustomerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	CustomerID varchar(10)
);

CREATE TABLE Worker(
	WorkerID varchar(10) primary key, --Auto 
	CitizenID varchar(50),
	Name nvarchar(255),
	Birth Date,
	Gender varchar(10),
	Address nvarchar(255),
	Mail varchar(50) unique,
	PhoneNumber varchar(10),
	PricePerHour float,
	FieldID varchar(5),                
	Description nvarchar(2000),
	Rating float,                      -- khoong dien
	ProfileImage varchar(100)
);

CREATE TABLE Customer(
	CustomerID varchar(10) primary Key,
	CitizenID varchar(50),
	Name nvarchar(255),
	Birth Date,
	Gender varchar(10),
	Address nvarchar(255),
	Mail varchar(50) unique,
	PhoneNumber varchar(10),
	Description nvarchar(2000),
	ProfileImage varchar(100)
);

insert into Customer(CustomerID,CitizenID,Name,Birth,Gender,Address,Mail,PhoneNumber,Description,ProfileImage)
values ('1','1234567899','Nguyễn Minh Quang','2004-03-12','Nam','Hoang Dieu2','Quang@gmail.com','0935601729','OKEEEEE','\Logo\WUNI.jpg');


CREATE TABLE Field(
	FieldID varchar(5) primary key,
	Field nvarchar(50)
);


INSERT INTO Field (FieldID, Field) VALUES
('DV001', 'Điện gia dụng'),
('DV002', 'Điện tử'),
('DV003', 'Điện lạnh'),
('DV004', 'Giữ trẻ'),
('DV005', 'Vận chuyển'),
('DV006', 'Thú cưng'),
('DV007', 'Vệ sinh'),
('DV008', 'Làm đẹp'),
('DV009', 'Xây dựng'),
('DV010', 'Nội thất'),
('DV011', 'Sửa chữa xe'),
('DV012', 'Sửa chữa nước'),
('DV013', 'Sữa chữa máy móc'),
('DV014', 'Làm vườn'),
('DV015', 'Giúp việc')

--SELECT MAX(WorkerID) FROM Worker;
--SELECT MAX(FieldID) FROM Field


--INSERT INTO Worker (Passwords, WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage)
--VALUES ('password123', 'WKR0001', '123456789', 'John Doe', '1990-01-01', 'Male', '123 Main St, City', 'john.doe@example.com', '1234567890', 15.50, 'FIELD1', 'Experienced worker', NULL, 'profile_image.jpg');





CREATE TABLE [dbo].[Order] (
    OrderID VARCHAR(10) PRIMARY KEY,
    FieldID VARCHAR(10),
    CustomerID VARCHAR(10),
    IsWorked bit,
    Description NVARCHAR(2000),
    IssueImage VARCHAR(50),
    IssueDate DATE,
    isQueue bit,
	WorkerID varchar(10) 
);
select * from [dbo].[Order];

Update [dbo].[Order] Set IsWorked = 1 Where OrderID = '1'


insert into [dbo].[Order](OrderID,FieldID,CustomerID,IsWorked,Description,IssueImage,IssueDate,isQueue,WorkerID)
values ('1','DV001','1',0,'Sửa laptop','\Logo\WUNI.jpg','2024-03-12',0,'1');

delete from [dbo].[Order];

CREATE TABLE Worked (
    OrderID VARCHAR(10),
    WorkerID VARCHAR(10),

);


CREATE TABLE BusyDate (
    WorkerID VARCHAR(10),
    CustomerID VARCHAR(10),
    BusyDate DATE
);

CREATE TABLE Queuee(
	WorkerID varchar(10),
	OrderID varchar(10)
);

Create table Review(
	ReviewID varchar(10) primary key,
	CustomerID varchar(10),	
	WorkerID varchar(10),
	Comment nvarchar(2000),
	ReviewImage varchar(100), 
	StarNumber int
);