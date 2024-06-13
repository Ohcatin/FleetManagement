using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FleetManagement.Models
{
    public class Taxi
    {
        public int Id { get; set; }
        public char Plate { get; set; }
    }
}
