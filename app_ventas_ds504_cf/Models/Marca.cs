using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace web_ventas_ds504_cf.Models
{
    [Table("tb_marca")]
    public class Marca
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el código de la marca")]
        [StringLength(5)]
        [Display(Name = "Código de Marca")]
        public string? codigo_marca { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la marca")]
        [StringLength(30)]
        [Display(Name = "Marca")]
        public string? marca { get; set; }
    }

}
