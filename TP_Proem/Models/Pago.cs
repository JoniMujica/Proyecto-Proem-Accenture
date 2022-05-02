namespace TP_Proem.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importte { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
