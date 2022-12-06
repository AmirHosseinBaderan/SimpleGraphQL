using DataBase.Context;
using Services.Repository;

namespace Services.Implementation;

internal class ProductRepository : IProductRepository
{

    private readonly GraphContext _context;

    public ProductRepository(GraphContext context)
    {
        _context = context;
    }

    public async ValueTask DisposeAsync()
    {
        GC.SuppressFinalize(this);
        await _context.DisposeAsync();
    }
}
