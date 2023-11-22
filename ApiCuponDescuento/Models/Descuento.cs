namespace ApiCuponDescuento.Models
{
    public partial class Descuento
    {
        public int DescuentoId { get; set; }
        public string? Tipo { get; set; }
        public decimal valor { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime FechaFin{ get; set; }

        public bool Activo { get; set; }

    }
}
