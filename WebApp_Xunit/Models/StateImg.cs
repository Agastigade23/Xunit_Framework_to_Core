using System.ComponentModel.DataAnnotations;

namespace WebApp_Xunit.Models
{
    public class StateImg
    {
        [Key]
        public string State { get; set; }

        public string Photo { get; set; }
    }
}
