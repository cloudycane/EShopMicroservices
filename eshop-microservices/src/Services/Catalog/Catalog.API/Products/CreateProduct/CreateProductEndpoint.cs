namespace Catalog.API.Products.CreateProduct
{
    // records

    public record CreateProductRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
    public record CreateProductResponse(Guid Id); 

    // ENDPOINTS 
    // GET, POST, PUT, DELETE
    // Para organizar los endpoints más estructurados utilizamos una libreria que se llama Carter. 
    public class CreateProductEndpoint
    {
    }
}
