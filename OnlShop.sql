CREATE DATABASE OnlineShop
--ACCOUNT
--User
CREATE TABLE Users(
UserID INT PRIMARY KEY,
Username VARCHAR(50),
Password TEXT,
Fname NVARCHAR(50),
Lname NVARCHAR(20),
Email VARCHAR(50),
Phone VARCHAR(12),
Address NVARCHAR(100)
/*VerificationCode Varchar(20)*/
)
--Admin
CREATE TABLE AdminUsers(
UserID INT PRIMARY KEY,
Username VARCHAR(50),
Password TEXT,
Fname NVARCHAR(50),
Lname NVARCHAR(20),
Email VARCHAR(50),
Phone VARCHAR(12),
TypeID INT FOREIGN KEY REFERENCES AdminTypes(TypeID)
)
CREATE TABLE AdminTypes(
TypeID INT PRIMARY KEY,
TypeName VARCHAR(10) NOT NULL,
Permission VARCHAR(10)
)
--PRODUCT
CREATE TABLE Categories(
CategoryID INT PRIMARY KEY,
CategoryName NVARCHAR(100),
CategoryThumb VARCHAR(100),
CategoryDescription NVARCHAR(MAX),
)
CREATE TABLE Discounts(
DiscountID INT PRIMARY KEY,
DiscountName NVARCHAR(50),
DiscountPercent DECIMAL(3,2) NOT NULL CHECK (DiscountPercent > 0 AND DiscountPercent < 1),
)
CREATE TABLE Products(
ProductID INT PRIMARY KEY,
ProductName NVARCHAR(100) NOT NULL,
ProductPrice DECIMAL(100,2) NOT NULL CHECK(ProductPrice > 0),
ProductCartDesc NVARCHAR(250),--mô tả trong giỏ
ProductShortDesc NVARCHAR(1000),-- mô tả chi tiết khi ấn vào giỏ hàng và đã thu gọn
ProductLongDesc TEXT,-- mô tả chi tiết khi ấn mở rộng chi tiết
ProductThumb VARCHAR(100) NOT NULL,--ảnh nền sản phẩm
ProductImg VARCHAR(100),--ảnh mô tả sản phẩm
ProductStock FLOAT,--tồn kho
CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
DiscountID INT FOREIGN KEY REFERENCES Discounts(DiscountID)
)
	
--Bảng hàng đặt
CREATE TABLE Orders(
OrderID INT PRIMARY KEY,
OrderAmount FLOAT,--số lượng đặt hàng
OrderShipped TINYINT,--kiểm tra nhận hàng
OrderDate TIMESTAMP,--ngày gửi dự kiến
OrderShipAddress NVARCHAR(100),--địa chỉ giao hàng, nếu null thì lấy địa chỉ người dùng
PaymentID INT FOREIGN KEY REFERENCES Payments(PaymentID),
OrderUserID INT FOREIGN KEY REFERENCES Users(UserID)--người đặt
--OrderTrackingNum VARCHAR(12),--mã theo dõi in trên gói hàng
)
-- Bảng chi tiết hàng đặt lưu những mặt hàng đã đặt
CREATE TABLE OrderDetails(
DetailID INT PRIMARY KEY,
DetailOrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
DetailProductID INT FOREIGN KEY REFERENCES Products(ProDuctID)
)
--Payment
CREATE TABLE Payments(
PaymentID INT PRIMARY KEY,
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
Ammount INT,
PaymentStatus NVARCHAR(20)-- trạng thái thanh toán
)
/*
--Session xem tổng giỏ hàng
CREATE TABLE Session(
SessionID INT,
UserID INT FOREIGN KEY REFERENCES User(UserID),
Total DECIMAL(100,2)
)
--Phản hồi
/*CREATE TABLE Contacts(
ContactID PRIMARY KEY
UserID FOREIGN KEY REFERENCES
ContactName
ContactTitle
ContactContent
)*/