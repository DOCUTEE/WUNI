use WUNI
CREATE TABLE WorkerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	WorkerID varchar(10)
);
-- Thêm 20 đối tượng vào bảng với ID từ 1 đến 20
delete from WorkerAccount
INSERT INTO WorkerAccount (UserName, Passwords, WorkerID) VALUES
    ('user1', 'password1', '1'),
    ('user2', 'password2', '2'),
    ('user3', 'password3', '3'),
    ('user4', 'password4', '4'),
    ('user5', 'password5', '5'),
    ('user6', 'password6', '6'),
    ('user7', 'password7', '7'),
    ('user8', 'password8', '8'),
    ('user9', 'password9', '9'),
    ('user10', 'password10', '10'),
    ('user11', 'password11', '11'),
    ('user12', 'password12', '12'),
    ('user13', 'password13', '13'),
    ('user14', 'password14', '14'),
    ('user15', 'password15', '15'),
    ('user16', 'password16', '16'),
    ('user17', 'password17', '17');
  
  
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
	PhoneNumber varchar(10),
	PricePerHour float,
	FieldID varchar(5),                
	Description nvarchar(2000),
	Rating float,                      -- khoong dien
	ProfileImage varchar(100)
);

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

drop table Field

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
INSERT INTO Field (FieldID, Field) VALUES
('16', 'VeSinh')

--SELECT MAX(WorkerID) FROM Worker;
--SELECT MAX(FieldID) FROM Field


--INSERT INTO Worker (Passwords, WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage)
--VALUES ('password123', 'WKR0001', '123456789', 'John Doe', '1990-01-01', 'Male', '123 Main St, City', 'john.doe@example.com', '1234567890', 15.50, 'FIELD1', 'Experienced worker', NULL, 'profile_image.jpg');

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
select * from [dbo].[Order];
delete from [dbo].[Order]
Update [dbo].[Order] Set IsWorked = 1 Where OrderID = '1'


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
insert into Queuee(WorkerID, OrderID)
values ('12','6')

Create table Review(
	ReviewID varchar(10) primary key,
	CustomerID varchar(10),	
	WorkerID varchar(10),
	Comment nvarchar(2000),
	ReviewImage varchar(100), 
	StarNumber int
);
Insert into review
values ('1','1','1','Thợ nhiệt tình lắm','\\Review\\1.png',3)

INSERT INTO [dbo].[Order] (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID)
VALUES ('1', '1', '1', 0, N'Description 1', '\\IssueImage\\1.png', '2024-04-26',1, '12'),
       ('2', '2', '1', 0, N'Description 2', '\\IssueImage\\2.png', '2024-04-27', 0, '12'),
       ('3', '3', '1', 0, N'Description 3', '\\IssueImage\\3.png', '2024-04-28', 0, '12'),
       ('4', '4', '1', 0, N'Description 4', '\\IssueImage\\4.png', '2024-04-29', 0, '12'),
       ('5', '5', '1', 0, N'Description 5', '\\IssueImage\\5.png', '2024-04-30', 0, '12');

    INSERT INTO [dbo].[Order] (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID)
VALUES ('6', '1', '1', 0, N'Description 1', '\\IssueImage\\6.png', '2024-04-26',1, '12')

select * from Liked
select * from [dbo].[Order]
select * from Review