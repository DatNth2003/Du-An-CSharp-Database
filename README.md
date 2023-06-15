# Du-An-CSharp-Database
##Tables:
    
1.Users: Lưu thông tin về người dùng.
    UserID (Primary Key)
    Username
    Password
    Email
    RoleID (Foreign Key)    

2.Roles: Lưu thông tin về vai trò của người dùng.
    RoleID (Primary Key)    
    RoleName 

3.Admins: Lưu thông tin về quản trị viên.
    AdminID (Primary Key)
    UserID (Foreign Key)

4.Products: Lưu thông tin về sản phẩm.
    ProductID (Primary Key)
    ProductName
    Price
    Description
5.Orders: Lưu thông tin về đơn hàng.
    OrderID (Primary Key)
    UserID (Foreign Key)
    ProductID (Foreign Key)
    Quantity
    OrderDate

6.Carts: Lưu thông tin về giỏ hàng người mua.
    CartID (Primary Key)
    UserID (Foreign Key)
    ProductID (Foreign Key)
    Quantity

Mối quan hệ
    Mỗi người dùng (Users) có một vai trò (Roles) thông qua khóa ngoại RoleID.
    Mỗi quản trị viên (Admins) có một người dùng (Users) thông qua khóa ngoại UserID.
    Mỗi đơn hàng (Orders) thuộc về một người dùng (Users) thông qua khóa ngoại UserID.
    Mỗi đơn hàng (Orders) có một sản phẩm (Products) thông qua khóa ngoại ProductID.
    Mỗi giỏ hàng (Carts) thuộc về một người dùng (Users) thông qua khóa ngoại UserID.
    Mỗi giỏ hàng (Carts) có một sản phẩm (Products) thông qua khóa ngoại ProductID.
