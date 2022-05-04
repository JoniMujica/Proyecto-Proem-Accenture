namespace TP_Proem.Models
{
    public class FacCli
    {
        public Cliente Cliente { get; set; }
        public Factura Factura { get; set; }
        public Item Item1 { get; set; }
        public Item Item2 { get; set; }
        public Item Item3 { get; set; }
        public Item Item4 { get; set; }
        public Item Item5 { get; set; }
        public FacCli()
        {
            Cliente = new Cliente();
            Factura = new Factura();
            Item1 = new Item();
            Item2 = new Item();
            Item3 = new Item();
            Item4 = new Item();
            Item5 = new Item();
        }
    }
}
