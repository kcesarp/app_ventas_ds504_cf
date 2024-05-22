
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDS504_cf.Models
{
    [Table("tb_personal")]
    public class Personal
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el número de DNI.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El número de DNI debe tener 8 dígitos.")]
        [Display(Name = "Número de DNI")]
        public string? dni { get; set; }

        [Required(ErrorMessage = "Ingrese el apellido paterno.")]
        [StringLength(25)]
        [Display(Name = "Apellido Paterno")]
        public string? ap_paterno { get; set; }

        [Required(ErrorMessage = "Ingrese el apellido materno.")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public string? ap_materno { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre.")]
        [StringLength(25)]
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Género")]
        public string? genero { get; set; }

        [Required(ErrorMessage = "Ingrese una fecha de nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }

        [Required(ErrorMessage = "Ingrese sueldo")]
        [Display(Name = "Sueldo")]
        public double sueldo { get; set; }
    }
}
