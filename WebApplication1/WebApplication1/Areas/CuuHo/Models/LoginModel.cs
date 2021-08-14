using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Areas.CuuHo.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }

        }
    }
