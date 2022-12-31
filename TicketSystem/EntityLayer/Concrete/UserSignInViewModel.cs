using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage="Lütfen Kullanıcı Adını Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string password { get; set; }

    }
}
