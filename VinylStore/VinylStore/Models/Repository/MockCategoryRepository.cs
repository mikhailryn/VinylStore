using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {

        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Jazz Vinyl Records", Description="All jazz music types"},
                new Category{CategoryId=2,CategoryName="Rock Vinyl Records", Description="All rock music types"},
                new Category{CategoryId=3,CategoryName="Blues Vinyl Records", Description="All blues music types"}
            };
    }
}
