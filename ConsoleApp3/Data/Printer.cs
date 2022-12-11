using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3.Data
{
    public class Printer
    {
        [Key]
        public int PrinterId { get; set; }
        public string PrinterName { get; set; }
        public string PrinterDescription { get; set; }
        public string PrinterLocation { get; set; }
        public bool IsAvailable { get; set; }
    }
}
