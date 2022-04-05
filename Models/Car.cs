using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_BlueFleet.Models
{
    [Table("Car")]
    public class Car
    {
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Placa")]
        [Column("license")]
        public string License { get; set; }

        [Display(Name = "Montadora")]
        [Column("automaker")]
        public string Automaker { get; set; }

        [Display(Name = "Modelo")]
        [Column("model")]
        public string Model{ get; set; }
    }
}
