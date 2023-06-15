using System.ComponentModel.DataAnnotations;

namespace Du_An_CSharp_Database.Module
{
    public class KhachHangModule
    {
        [Required]
        [MaxLength(50)]
        public string TenKH { get; set; }
        [Required]
        [MaxLength(50)]
        public string HoKH { get; set; }
        [Required]
        [MaxLength(20)]
        public string Usename { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        public string Mail { get; set; }
        [MaxLength(12)]
        public string SDT { get; set; }
        [MaxLength(13)]
        public string CCCD { get; set; }
        [Required]
        [MaxLength(100)]
        public string DiaChi { get; set; }
    }
}
