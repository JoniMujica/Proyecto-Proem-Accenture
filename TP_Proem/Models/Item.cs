namespace TP_Proem.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
