using System.ComponentModel.DataAnnotations;

namespace  MiApiRest.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string? Nombre_Cliente { get; set; }
        public string? Mail_Cliente { get; set; }
        public DateTime? Fecha_Registro { get; set; }
    }
}