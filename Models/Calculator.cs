
using System.ComponentModel.DataAnnotations;

namespace laba_4.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Please enter a value for Num1.")]
        public int Num1 { get; set; }

        [Range(-100, 100, ErrorMessage = "Please enter a value between -100 and 100 for Num2.")]
        public int Num2 { get; set; }
        public string Operation { get; set; }
    }
}