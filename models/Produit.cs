namespace Gestion_de_Produit.models
{
    public class Produit
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public decimal UnitPrice { get; set; } 
        public string QuantityPerUnit { get; set; }= String.Empty;
        public int UnitsInStock { get; set; }

    }
}
