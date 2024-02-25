using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaTicketsAssembly.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int DetalleId {  get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [ForeignKey("TicketId")]
        public int TicketId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Emisor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Mensaje { get; set; }


    }
}
