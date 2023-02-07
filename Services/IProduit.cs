using Gestion_de_Produit.models;

namespace Gestion_de_Produit.Services
{
    public interface IProduit
    {
        
        Task<List<Produit>> GetProduitList();
        Task<Produit> GetProduitById(Guid produitId);
        Task<Produit> GetProduitByItem(string item);
    }
}
