using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _15_ModelDataAnnotations.Models
{
    public class WebUser
    {
        [Display(Name = "Adınız: ")]
        public string FirsName { get; set; }

    }
}
