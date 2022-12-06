using DataBase.Context;
using DataBase.Entities;

namespace Services.Query;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Group> GetGroups([Service] GraphContext graphContext) => graphContext.Group;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Product> GetProducts([Service] GraphContext graphContext) => graphContext.Product;
}
