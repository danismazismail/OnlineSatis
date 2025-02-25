using DataAccess.Context.ApplicationContext;
using DataAccess.Repositories.Interfaces;
using Entities.Concrete;

namespace DataAccess.Repositories.Concrete;

public class CategoryRepo(AppDbContext context) : BaseRepository<Category>(context),ICategoryRepo
{
    
}