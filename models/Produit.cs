namespace Gestion_de_Produit.models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom_Produit { get; set; } = String.Empty;
        public string Vendeur { get; set; } = String.Empty;
        public int    Prix_unitaire { get; set; }
        public string Unités_en_stock { get; set; }= String.Empty;

    }
}
