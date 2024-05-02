﻿use WUNI
CREATE TABLE WorkerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	WorkerID varchar(10)
);

  
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
	Mail varchar(50),
	PhoneNumber varchar(12),
	PricePerHour float,
	FieldID varchar(5),                
	Description nvarchar(2000),
	Rating float,                      -- khoong dien
	ProfileImage varchar(100)
);

drop table Worker
delete from Worker
INSERT INTO Worker (WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage) VALUES
    ('1', 'CIT001', N'John Doe', '1990-05-15', 'Male', N'123 Main Street', 'john.doe@example.com', '1234567890', 15.0, '1', N'Construction worker', 4.5, ''),
    ('2', 'CIT002', N'Jane Smith', '1988-10-20', 'Female', N'456 Elm Street', 'jane.smith@example.com', '2345678901', 20.0, '2', N'Plumber', 4.8, ''),
    ('3', 'CIT003', N'Michael Johnson', '1995-03-08', 'Male', N'789 Oak Street', 'michael.johnson@example.com', '3456789012', 18.0, '3', N'Electrician', 4.3, ''),
    ('4', 'CIT004', N'Susan Williams', '1992-07-12', 'Female', N'1011 Pine Street', 'susan.williams@example.com', '4567890123', 22.0, '4', N'Painter', 4.9, ''),
    ('5', 'CIT005', N'David Brown', '1987-12-28', 'Male', N'1213 Cedar Street', 'david.brown@example.com', '5678901234', 16.0, '5', N'Carpenter', 4.6, ''),
    ('6', 'CIT006', N'Amanda Wilson', '1993-09-05', 'Female', N'1415 Maple Street', 'amanda.wilson@example.com', '6789012345', 25.0, '6', N'Landscaper', 4.7, ''),
    ('7', 'CIT007', N'Christopher Lee', '1989-04-18', 'Male', N'1617 Walnut Street', 'christopher.lee@example.com', '7890123456', 20.0, '7', N'HVAC technician', 4.4, ''),
    ('8', 'CIT008', N'Jessica Martinez', '1991-11-10', 'Female', N'1819 Birch Street', 'jessica.martinez@example.com', '8901234567', 21.0, '8', N'Roofer', 4.8, ''),
    ('9', 'CIT009', N'James Taylor', '1994-06-25', 'Male', N'2021 Spruce Street', 'james.taylor@example.com', '9012345678', 19.0, '9', N'Plasterer', 4.5, ''),
    ('10', 'CIT010', N'Emily Anderson', '1986-01-30', 'Female', N'2223 Oakwood Street', 'emily.anderson@example.com', '0123456789', 23.0, '10', N'Flooring specialist', 4.9, ''),
    ('11', 'CIT011', N'Ryan Garcia', '1996-08-14', 'Male', N'2425 Cherry Street', 'ryan.garcia@example.com', '1234567890', 17.0, '11', N'Plumber', 4.7, ''),
    ('12', 'CIT012', N'Sarah Clark', '1990-02-19', 'Female', N'2627 Elmwood Street', 'sarah.clark@example.com', '2345678901', 24.0, '12', N'Tile installer', 4.6, ''),
    ('13', 'CIT013', N'Daniel Rodriguez', '1988-07-23', 'Male', N'2829 Cedarwood Street', 'daniel.rodriguez@example.com', '3456789012', 18.0, '13', N'Electrician', 4.5, ''),
    ('14', 'CIT014', N'Olivia Hall', '1993-12-07', 'Female', N'3031 Pinecrest Street', 'olivia.hall@example.com', '4567890123', 20.0, '14', N'Painter', 4.8, ''),
    ('15', 'CIT015', N'William Hernandez', '1985-09-29', 'Male', N'3233 Oakridge Street', 'william.hernandez@example.com', '5678901234', 16.0, '15', N'Carpenter', 4.9, ''),
    ('16', 'CIT016', N'Sophia Young', '1997-04-03', 'Female', N'3435 Maplewood Street', 'sophia.young@example.com', '6789012345', 22.0, '1', N'Landscaper', 4.7, ''),
    ('17', 'CIT017', N'Alexander King', '1989-10-17', 'Male', N'3637 Walnutwood Street', 'alexander.king@example.com', '7890123456', 19.0, '1', N'HVAC technician', 4.8, '');

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



CREATE TABLE Field(
	FieldID varchar(5) primary key,
	Field varchar(50)
);

INSERT INTO Field (FieldID, Field) VALUES
('1', 'Điện gia dụng'),
('2', 'Điện tử'),
('3', 'Điện lạnh'),
('4', 'Giữ trẻ'),
('5', 'Vận chuyển'),
('6', 'Thú cưng'),
('7', 'Vệ sinh'),
('8', 'Làm đẹp'),
('9', 'Xây dựng'),
('10', 'Nội thất'),
('11', 'Sửa chữa xe'),
('12', 'Sửa chữa nước'),
('13', 'Sữa chữa máy móc'),
('14', 'Làm vườn'),
('15', 'Giúp việc')

Create table Liked(
    WorkerID varchar(10),
    CustomerID varchar(10),
    primary key (WorkerID, CustomerID)
)



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
--(select * from Worker 
--inner join Worked
--on Worker.wokerID = Worked.WorkerID)
-- as  AVGsalary


delete from Review
select * from worker