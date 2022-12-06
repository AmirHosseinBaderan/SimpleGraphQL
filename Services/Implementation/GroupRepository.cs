using DataBase.Context;
using Services.Repository;

namespace Services.Implementation;

internal class GroupRepository : IGroupRepository
{
    private readonly GraphContext _context;

    public GroupRepository(GraphContext context)
    {
        _context = context;
    }

    public async ValueTask DisposeAsync()
    {
        GC.SuppressFinalize(this);
        await _context.DisposeAsync();
    }
}
