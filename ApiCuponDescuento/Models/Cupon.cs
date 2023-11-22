namespace ApiCuponDescuento.Models
{
    public partial class Cupon
    {
        public int CuponId { get; set; }

        public string? codigo { get; set; }

        public int DescuentoId { get; set; }

        public decimal valor { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public bool Activo { get; set; }

        public Descuento? Descuento { get; set; }
    }
}
