using System.ComponentModel.DataAnnotations;

namespace Du_An_CSharp_Database.Module
{
    public class UsersModule
    {
        //Định nghĩa khóa chính
        [Key]
        public int UserID { get; set; }
        //Yêu cầu ràng buộc bắt buộc phải nhập
        [Required]
        [MaxLength(50)]//Tạo giới hạn độ dài kí tự
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        public string Email { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(13)]
        public string CCCD { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
    }
}
