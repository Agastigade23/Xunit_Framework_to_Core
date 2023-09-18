using System.ComponentModel.DataAnnotations;

namespace WebApp_Xunit.Models
{
    public class CityInfo
    {
        [Key]
        public string City { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }
    }
}
