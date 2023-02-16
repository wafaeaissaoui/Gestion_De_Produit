using Gestion_de_Produit.models;

namespace Gestion_de_Produit.Services
{
    public interface IProduit
    {
        
        Task<IEnumerable<Produit>> GetProduitList();
        Task<Produit> GetProduitById(int produitId);
        Task<Produit> GetProduitByItem(string item);
    }
}
