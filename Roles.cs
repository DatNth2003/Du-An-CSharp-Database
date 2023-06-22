using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopDemo.Data
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
