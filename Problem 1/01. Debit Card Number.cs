using System.ComponentModel.DataAnnotations;

namespace TrainSystem.Models
{
    public class Trip
    {

        [Required]
        public string Origin { get; set; }       

        [Required]
        public string Origin { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public int Business { get; set; }

        [Required]
        public int Economy { get; set; }
//Please don't use so many classes ,it's confusing!

    }
}