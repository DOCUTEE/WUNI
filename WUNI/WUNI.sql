use WUNI
CREATE TABLE WorkerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	WorkerID varchar(10)
);

INSERT INTO WorkerAccount (UserName, Passwords, WorkerID)
VALUES 
('user1', '1111', '1'),
('user2', '1111', '2'),
('user3', '1111', '3'),
('user4', '1111', '4'),
('user5', '1111', '5'),
('user6', '1111', '6'),
('user7', '1111', '7'),
('user8', '1111', '8'),
('user9', '1111', '9'),
('user10', '1111', '10'),
('user11', '1111', '11'),
('user12', '1111', '12'),
('user13', '1111', '13'),
('user14', '1111', '14'),
('user15', '1111', '15'),
('user16', '1111', '16'),
('user17', '1111', '17'),
('user18', '1111', '18'),
('user19', '1111', '19'),
('user20', '1111', '20');

INSERT INTO WorkerAccount (UserName, Passwords, WorkerID)
VALUES 
('user21', '1111', '21'),
('user22', '1111', '22'),
('user23', '1111', '23'),
('user24', '1111', '24'),
('user25', '1111', '25'),
('user26', '1111', '26'),
('user27', '1111', '27'),
('user28', '1111', '28'),
('user29', '1111', '29'),
('user30', '1111', '30'),
('user31', '1111', '31'),
('user32', '1111', '32'),
('user33', '1111', '33'),
('user34', '1111', '34'),
('user35', '1111', '35'),
('user36', '1111', '36'),
('user37', '1111', '37'),
('user38', '1111', '38'),
('user39', '1111', '39'),
('user40', '1111', '40');

  
CREATE TABLE Worker(
	WorkerID varchar(10) primary key,
	CitizenID varchar(50),
	Name nvarchar(255),
	Birth Date,
	Gender nvarchar(10),
	Address nvarchar(255),
	Mail varchar(50),
	PhoneNumber varchar(12),
	PricePerHour float,
	FieldID varchar(5),                
	Description nvarchar(2000),
	Rating float,                      
	ProfileImage varchar(100)
);

INSERT INTO Worker (WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage) 
VALUES 
('1', '000000001', N'Nguyễn Văn A', '1990-01-01', N'Nam', N'Hà Nội', 'nguyenvana@example.com', '023-2342-234', 50.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp với hơn 5 năm kinh nghiệm.', 0, 'WorkerImage\\1.png'),
('2', '000000002', N'Trần Văn B', '1992-05-10', N'Nam', N'Hồ Chí Minh', 'tranthib@example.com', '023-2342-235', 55.0, '1', N'Tôi là thợ sửa điện gia dụng có khả năng làm việc độc lập và trách nhiệm cao.', 0, 'WorkerImage\\2.png'),
('3', '000000003', N'Lê Văn C', '1985-11-15', N'Nam', N'Hải Phòng', 'levanc@example.com', '023-2342-236', 60.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp, luôn đặt uy tín và chất lượng lên hàng đầu.', 0, 'WorkerImage\\3.png'),
('4', '000000004', N'Phạm Quốc D', '1988-03-20', N'Nam', N'Đà Nẵng', 'phamthid@example.com', '023-2342-237', 48.0, '1', N'Tôi là thợ sửa điện gia dụng có kỹ thuật tốt và sẵn lòng hỗ trợ khách hàng mọi lúc.', 0, 'WorkerImage\\4.png'),
('5', '000000005', N'Hồ Văn E', '1993-07-25', N'Nam', N'Bình Dương', 'hovane@example.com', '023-2342-238', 65.0, '1', N'Tôi là thợ sửa điện gia dụng có kiến thức rộng và kinh nghiệm thực tiễn.', 0, 'WorkerImage\\5.png'),
('6', '000000006', N'Nguyễn Thị F', '1991-09-30', N'Nữ', N'Cần Thơ', 'nguyenthif@example.com', '023-2342-239', 58.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp, luôn đảm bảo công việc hoàn thành đúng tiến độ.', 0, 'WorkerImage\\6.png'),
('7', '000000007', N'Trần Ngọc G', '1987-02-05', N'Nữ', N'Vũng Tàu', 'tranvang@example.com', '023-2342-240', 52.0, '1', N'Tôi là thợ sửa điện gia dụng với tư duy linh hoạt và khả năng xử lý tình huống tốt.', 0, 'WorkerImage\\7.png'),
('8', '000000008', N'Lê Thị H', '1990-04-10', N'Nữ', N'Hải Dương', 'lethih@example.com', '023-2342-241', 47.0, '1', N'Tôi là thợ sửa điện gia dụng lắp đặt chuyên nghiệp, luôn đảm bảo an toàn và hiệu quả cho công việc.', 0, 'WorkerImage\\8.png'),
('9', '000000009', N'Hoàng Ánh I', '1989-06-15', N'Nữ', N'Bắc Ninh', 'hoangvani@example.com', '023-2342-242', 53.0, '1', N'Tôi là thợ sửa điện gia dụng thông minh, sáng tạo và nhanh nhẹn trong việc tìm giải pháp.', 0, 'WorkerImage\\9.png'),
('10', '000000010', N'Phan Thị K', '1995-08-20', N'Nữ', N'Hà Nam', 'phanthik@example.com', '023-2342-243', 49.0, '1', N'Tôi là thợ sửa điện gia dụng với kỹ năng tinh tế và sự chăm sóc tỉ mỉ đến từng chi tiết.', 0, 'WorkerImage\\10.png'),
('11', '000000011', N'Vũ Mỹ L', '1986-10-25', N'Nữ', N'Hưng Yên', 'vuvanl@example.com', '023-2342-244', 54.0, '1', N'Tôi là thợ sửa điện gia dụng uy tín, có khả năng làm việc nhóm tốt và linh hoạt trong công việc.', 0, 'WorkerImage\\11.png'),
('12', '000000012', N'Lương Thị M', '1994-12-30', N'Nữ', N'Hải Dương', 'luongthim@example.com', '023-2342-245', 56.0, '1', N'Tôi là thợ sửa điện gia dụng có tư duy sáng tạo và khả năng giải quyết vấn đề tốt.', 0, 'WorkerImage\\12.png'),
('13', '000000013', N'Nguyễn Văn N', '1988-02-28', N'Nam', N'Hà Nội', 'nguyenvann@example.com', '023-2342-246', 51.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp, luôn đảm bảo công trình hoàn thành đúng tiến độ và chất lượng.', 0, 'WorkerImage\\13.png'),
('14', '000000014', N'Trần Ân O', '1993-04-05', N'Nam', N'Hồ Chí Minh', 'tranthio@example.com', '023-2342-247', 52.0, '1', N'Tôi là thợ sửa điện gia dụng với kỹ năng sắc bén và kinh nghiệm phong phú.', 0, 'WorkerImage\\14.png'),
('15', '000000015', N'Lê Văn P', '1991-06-10', N'Nam', N'Hải Phòng', 'levanp@example.com', '023-2342-248', 57.0, '1', N'Tôi là thợ sửa điện gia dụng có tinh thần trách nhiệm và kiên nhẫn trong công việc.', 0, 'WorkerImage\\15.png'),
('16', '000000016', N'Hoàng Đức Q', '1989-08-15', N'Nam', N'Bình Dương', 'hoangthiq@example.com', '023-2342-249', 63.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp, luôn đặt sự hài lòng của khách hàng lên hàng đầu.', 0, 'WorkerImage\\16.png'),
('17', '000000017', N'Phan Văn R', '1987-10-20', N'Nữ', N'Cần Thơ', 'phanvanr@example.com', '023-2342-250', 59.0, '1', N'Tôi là thợ sửa điện gia dụng có khả năng làm việc độc lập và hiệu quả.', 0, 'WorkerImage\\17.png'),
('18', '000000018', N'Trương Nguyễn Uyên M', '1994-12-25', N'Nữ', N'Vũng Tàu', 'truongthis@example.com', '023-2342-251', 64.0, '1', N'Tôi là thợ sửa điện gia dụng chuyên nghiệp, luôn đảm bảo độ bền và đẹp mắt cho công trình.', 0, 'WorkerImage\\18.png'),
('19', '000000019', N'Nguyễn Hoàng Nhất T', '1988-02-28', N'Nữ', N'Hải Dương', 'nguyenvant@example.com', '023-2342-252', 61.0, '1', N'Tôi là thợ sửa điện gia dụng có kỹ năng linh hoạt và trách nhiệm cao.', 0, 'WorkerImage\\19.png'),
('20', '000000020', N'Lê Ninh U', '1995-04-01', N'Nữ', N'Bắc Ninh', 'lethiu@example.com', '023-2342-253', 50.0, '1', N'Tôi là thợ sửa điện gia dụng có kỹ thuật tốt và sự chăm chỉ trong công việc.', 0, 'WorkerImage\\20.png');



INSERT INTO Worker (WorkerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, PricePerHour, FieldID, Description, Rating, ProfileImage) 
VALUES 
('21', '000000021', N'Võ Thị A', '1990-01-01', N'Nữ', N'Hà Nội', 'vothia@example.com', '023-2342-254', 50.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp với kinh nghiệm trong lĩnh vực làm đẹp.', 0, 'WorkerImage\\21.png'),
('22', '000000022', N'Đỗ Thị B', '1992-05-10', N'Nữ', N'Hồ Chí Minh', 'dothib@example.com', '023-2342-255', 55.0, '2', N'Tôi là thợ làm đẹp có kiến thức vững vàng về các kỹ thuật làm đẹp.', 0, 'WorkerImage\\22.png'),
('23', '000000023', N'Nguyễn Gia C', '1985-11-15', N'Nữ', N'Hải Phòng', 'nguyenvanc@example.com', '023-2342-256', 60.0, '2', N'Tôi là thợ làm đẹp có khả năng phục vụ khách hàng một cách chuyên nghiệp và tận tình.', 0, 'WorkerImage\\23.png'),
('24', '000000024', N'Lê Thị D', '1988-03-20', N'Nữ', N'Đà Nẵng', 'lethid@example.com', '023-2342-257', 48.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp với kỹ năng phối hợp và làm việc nhóm tốt.', 0, 'WorkerImage\\24.png'),
('25', '000000025', N'Hồ Hoàng Ngọc E', '1993-07-25', N'Nữ', N'Bình Dương', 'hovane@example.com', '023-2342-258', 65.0, '2', N'Tôi là thợ làm đẹp có kiến thức rộng và kỹ năng thẩm mỹ tốt.', 0, 'WorkerImage\\25.png'),
('26', '000000026', N'Nguyễn Thị F', '1991-09-30', N'Nữ', N'Cần Thơ', 'nguyenthif@example.com', '023-2342-259', 58.0, '2', N'Tôi là thợ làm đẹp với tư duy sáng tạo và khả năng tư vấn cho khách hàng.', 0, 'WorkerImage\\26.png'),
('27', '000000027', N'Trần Diễm G', '1987-02-05', N'Nữ', N'Vũng Tàu', 'tranvang@example.com', '023-2342-260', 52.0, '2', N'Tôi là thợ làm đẹp có khả năng làm việc độc lập và đảm bảo chất lượng công việc.', 0, 'WorkerImage\\27.png'),
('28', '000000028', N'Lê Thị H', '1990-04-10', N'Nữ', N'Hải Dương', 'lethih@example.com', '023-2342-261', 47.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp, luôn đảm bảo an toàn và hiệu quả cho công việc.', 0, 'WorkerImage\\28.png'),
('29', '000000029', N'Hoàng THị I', '1989-06-15', N'Nữ', N'Bắc Ninh', 'hoangvani@example.com', '023-2342-262', 53.0, '2', N'Tôi là thợ làm đẹp thông minh, sáng tạo và nhanh nhẹn trong việc tìm giải pháp.', 0, 'WorkerImage\\29.png'),
('30', '000000030', N'Phan Thị K', '1995-08-20', N'Nữ', N'Hà Nam', 'phanthik@example.com', '023-2342-263', 49.0, '2', N'Tôi là thợ làm đẹp với kỹ năng tinh tế và sự chăm sóc tỉ mỉ đến từng chi tiết.', 0, 'WorkerImage\\30.png'),
('31', '000000031', N'Vũ Hoàng Ngọc L', '1986-10-25', N'Nữ', N'Hưng Yên', 'vuvanl@example.com', '023-2342-264', 54.0, '2', N'Tôi là thợ làm đẹp uy tín, có khả năng làm việc nhóm tốt và linh hoạt trong công việc.', 0, 'WorkerImage\\31.png'),
('32', '000000032', N'Lương Thị M', '1994-12-30', N'Nữ', N'Hải Dương', 'luongthim@example.com', '023-2342-265', 56.0, '2', N'Tôi là thợ làm đẹp có tư duy sáng tạo và khả năng giải quyết vấn đề tốt.', 0, 'WorkerImage\\32.png'),
('33', '000000033', N'Nguyễn NGọc N', '1988-02-28', N'Nữ', N'Hà Nội', 'nguyenvann@example.com', '023-2342-266', 51.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp, luôn đảm bảo công trình hoàn thành đúng tiến độ và chất lượng.', 0, 'WorkerImage\\33.png'),
('34', '000000034', N'Trần Thị O', '1993-04-05', N'Nữ', N'Hồ Chí Minh', 'tranthio@example.com', '023-2342-267', 52.0, '2', N'Tôi là thợ làm đẹp với kỹ năng sắc bén và kinh nghiệm phong phú.', 0, 'WorkerImage\\34.png'),
('35', '000000035', N'Lê Phạm Kỳ P', '1991-06-10', N'Nữ', N'Hải Phòng', 'levanp@example.com', '023-2342-268', 57.0, '2', N'Tôi là thợ làm đẹp có tinh thần trách nhiệm và kiên nhẫn trong công việc.', 0, 'WorkerImage\\35.png'),
('36', '000000036', N'Hoàng Thị Q', '1989-08-15', N'Nữ', N'Bình Dương', 'hoangthiq@example.com', '023-2342-269', 63.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp, luôn đặt sự hài lòng của khách hàng lên hàng đầu.', 0, 'WorkerImage\\36.png'),
('37', '000000037', N'Phan Yên R', '1987-10-20', N'Nữ', N'Cần Thơ', 'phanvanr@example.com', '023-2342-270', 59.0, '2', N'Tôi là thợ làm đẹp có khả năng làm việc độc lập và hiệu quả.', 0, 'WorkerImage\\37.png'),
('38', '000000038', N'Trương Thị S', '1994-12-25', N'Nữ', N'Vũng Tàu', 'truongthis@example.com', '023-2342-271', 64.0, '2', N'Tôi là thợ làm đẹp chuyên nghiệp, luôn đảm bảo độ bền và đẹp mắt cho công trình.', 0, 'WorkerImage\\38.png'),
('39', '000000039', N'Nguyễn Trần Thảo T', '1988-02-28', N'Nữ', N'Hải Dương', 'nguyenvant@example.com', '023-2342-272', 61.0, '2', N'Tôi là thợ làm đẹp có kỹ năng linh hoạt và trách nhiệm cao.', 0, 'WorkerImage\\39.png'),
('40', '000000040', N'Lê Thị Mỹ', '1995-04-01', N'Nữ', N'Bắc Ninh', 'lethiu@example.com', '023-2342-273', 50.0, '2', N'Tôi là thợ làm đẹp có kỹ thuật tốt và sự chăm chỉ trong công việc.', 0, 'WorkerImage\\40.png');


CREATE TABLE CustomerAccount(
	UserName varchar(50) unique,
	Passwords varchar(50),
	CustomerID varchar(10)
);

INSERT INTO CustomerAccount (UserName, Passwords, CustomerID)
VALUES 
('cus1', '1111', '1'),
('cus2', '1111', '2'),
('cus3', '1111', '3');

CREATE TABLE Customer(
	CustomerID varchar(10) primary Key,
	CitizenID varchar(50),
	Name nvarchar(255),
	Birth Date,
	Gender varchar(10),
	Address nvarchar(255),
	Mail varchar(50) unique,
	PhoneNumber varchar(12),
	Description nvarchar(2000),
	ProfileImage varchar(100)
);

INSERT INTO Customer (CustomerID, CitizenID, Name, Birth, Gender, Address, Mail, PhoneNumber, Description, ProfileImage) 
VALUES 
('1', '000000001', N'Nguyễn Văn A', '1990-01-01', N'Nam', N'Hà Nội', 'nguyenvana@example.com', '023-2342-001', N'Hello', 'CustomerImage\\1.png'), 
('2', '000000002', N'Trần Thị B', '1992-05-10', N'Nữ', N'Hồ Chí Minh', 'tranthib@example.com', '023-2342-002', N'Chào', 'CustomerImage\\2.png'),
('3', '000000003', N'Lê Văn C', '1985-11-15', N'Nam', N'Hải Phòng', 'levanc@example.com', '023-2342-003', N'I purple you!!', 'CustomerImage\\3.png');

CREATE TABLE Field(
	FieldID varchar(5) primary key,
	Field nvarchar(50)
);

INSERT INTO Field (FieldID, Field) VALUES
('1', N'Điện gia dụng'),
('2', N'Làm đẹp'),
('3', N'Điện lạnh'),
('4', N'Giữ trẻ'),
('5', N'Vận chuyển'),
('6', N'Thú cưng'),
('7', N'Vệ sinh'),
('8', N'Bảo vệ'),
('9', N'Xây dựng'),
('10', N'Nội thất'),
('11', N'Sửa chữa xe'),
('12', N'Sửa nước'),
('13', N'Tài xế'),
('14', N'Làm vườn'),
('15', N'Giúp việc')

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
delete [dbo].[Order]


INSERT INTO [dbo].[Order] (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID)
VALUES 
    ('1', '1', '1', 0, N'Mô tả 1', 'IssueImage\\1.png', '2024-05-08', 0, '0'),
    ('2', '1', '1', 0, N'Mô tả 2', 'IssueImage\\2.png', '2024-05-08', 0, '0'),
    ('3', '1', '1', 0, N'Mô tả 3', 'IssueImage\\3.png', '2024-05-05', 0, '0'),
    ('4', '2', '1', 0, N'Mô tả 4', 'IssueImage\\4.png', '2024-05-05', 0, '0'),
    ('5', '2', '2', 0, N'Mô tả 5', 'IssueImage\\5.png', '2024-05-09', 0, '0'),
    ('6', '3', '2', 0, N'Mô tả 6', 'IssueImage\\6.png', '2024-05-04', 0, '0'),
    ('7', '3', '2', 0, N'Mô tả 7', 'IssueImage\\7.png', '2024-05-04', 0, '0'),
    ('8', '4', '3', 0, N'Mô tả 8', 'IssueImage\\8.png', '2024-05-04', 0, '0'),
    ('9', '4', '3', 0, N'Mô tả 9', 'IssueImage\\9.png', '2024-05-09', 0, '0'),
    ('10', '5', '3', 0, N'Mô tả 10', 'IssueImage\\10.png', '2024-05-09', 0, '0');


INSERT INTO [dbo].[Order] (OrderID, FieldID, CustomerID, IsWorked, Description, IssueImage, IssueDate, isQueue, WorkerID)
VALUES 
    ('11', '1', '1', 0, N'Mô tả 11', 'IssueImage\\11.png', '2024-05-09', 1, '1'),
    ('12', '1', '2', 0, N'Mô tả 12', 'IssueImage\\12.png', '2024-05-09', 1, '1'),
    ('13', '1', '3', 0, N'Mô tả 13', 'IssueImage\\13.png', '2024-05-09', 1, '1'),
    ('14', '1', '1', 0, N'Mô tả 14', 'IssueImage\\14.png', '2024-05-09', 1, '1'),
    ('15', '1', '2', 0, N'Mô tả 15', 'IssueImage\\15.png', '2024-05-10', 1, '2'),
    ('16', '2', '3', 0, N'Mô tả 16', 'IssueImage\\16.png', '2024-05-11', 1, '21'),
    ('17', '2', '1', 0, N'Mô tả 17', 'IssueImage\\17.png', '2024-05-10', 1, '21'),
    ('18', '2', '2', 0, N'Mô tả 18', 'IssueImage\\18.png', '2024-05-10', 1, '21'),
    ('19', '2', '3', 0, N'Mô tả 19', 'IssueImage\\19.png', '2024-05-11', 1, '21'),
    ('20', '2', '3', 0, N'Mô tả 20', 'IssueImage\\20.png', '2024-05-09', 1, '21');


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

INSERT INTO Queuee (WorkerID, OrderID)
VALUES 
    ('1', '11'),
    ('1', '12'),
    ('1', '13'),
    ('1', '14'),
    ('2', '15'),
    ('21', '16'),
    ('21', '17'),
    ('21', '18'),
    ('21', '19'),
    ('21', '20');

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


