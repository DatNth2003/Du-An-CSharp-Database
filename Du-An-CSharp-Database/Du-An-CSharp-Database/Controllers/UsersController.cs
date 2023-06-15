using Du_An_CSharp_Database.Data;
using Du_An_CSharp_Database.Module;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Du_An_CSharp_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Dịch chuyển đến đối tượng trong map
        /// </summary>
        /// <param name="obj">Đối tượng cần dịch chuyển tới</param>
        private readonly MyDbContext _context;
        public UsersController(MyDbContext context)
        {
            _context = context;
        }
        public static List<Users> users = new List<Users>();
        [HttpGet]
        public IActionResult getAccount()
        {
            var khackhangs = _context.Users.ToList();
            return Ok(khackhangs);
        }
        [HttpGet("{ID}")]
        public IActionResult getAccountByID(int ID)
        {
            try
            {
                var _khacHang = _context.Users.SingleOrDefault(kh => kh.UserID == ID);
                if (_khacHang == null)
                {
                    return NotFound();
                }
                return Ok(_khacHang);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult createAccount(UsersModule khach)
        {
            try
            {
                var _khach = new Users
                {

                    Name = khach.Name,
                    FirstName = khach.FirstName,
                    Username = khach.Username,
                    Password = khach.Password,
                    Email = khach.Email,
                    Phone = khach.Phone,
                    CCCD = khach.CCCD,
                    Adress = khach.Adress
                };
                _context.Add(_khach);
                _context.SaveChanges();
                return Ok(_khach);
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpPut("{ID}")]
        public IActionResult updateAccount(int ID, UsersModule khach)
        {
            try
            {
                var _khacHang = _context.Users.SingleOrDefault(kh => kh.UserID == ID);
                if (_khacHang == null)
                {
                    return NotFound();
                }
                if (ID != _khacHang.UserID)
                {
                    return BadRequest();
                }
                _khacHang.Name = khach.Name;
                _khacHang.FirstName = khach.FirstName;
                _khacHang.Password = khach.Password;
                _khacHang.Email = khach.Email;
                _khacHang.Phone = khach.Phone;
                _khacHang.CCCD = khach.CCCD;
                _khacHang.Adress = khach.Adress;
                _context.SaveChanges();
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{ID}")]
        public IActionResult deleteAccount(int ID)
        {
            try
            {
                var _khacHang = _context.Users.SingleOrDefault(kh => kh.UserID == ID);
                if (_khacHang == null)
                {
                    return NotFound();
                }
                _context.Remove(_khacHang);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
