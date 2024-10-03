// Command Handler Proceso: 

/// 1 - Instalar la paquete MediatR (para una arquitectura vertical)
/// 2 - Usando public record, instanciar las propiedades del producto y estas propiedades heredan de IRequest<CreateProductResult> y encapusaladas por CreateProductCommand
/// 3 - Usando public record, instanciar el Id a partir de CreateProductResult
using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct

{
    // Instanciando los datos desde el modelo de Producto
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    // Un método interno
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Create a product entity from command object
            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price,
            };
            // Save to the database


            // return CreateProductResult result 
            return new CreateProductResult(Guid.NewGuid());
        }
    }
}
