// Command Handler Proceso: 

/// 1 - Instalar la paquete MediatR (para una arquitectura vertical)
/// 2 - Usando public record, instanciar las propiedades del producto y estas propiedades heredan de IRequest<CreateProductResult> y encapusaladas por CreateProductCommand
/// 3 - Usando public record, instanciar el Id a partir de CreateProductResult
using MediatR;

namespace Catalog.API.Products.CreateProduct

{
    // Instanciando los datos desde el modelo de Producto
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    // Un método interno
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
