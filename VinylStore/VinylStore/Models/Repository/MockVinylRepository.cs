using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
   // public class MockVinylRepository : IVinylRepository
   // {
   //     private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();

   //     public IEnumerable<Vinyl> AllVinyls =>
   //         new List<Vinyl>
   //         {
   //     new Vinyl{VinylId=1,Name="The Beatles", Price=14.56M,ShortDescription="First album",LongDescription="Most rated album", Category = categoryRepository.AllCategories.ToList()[0], ImageUrl="https://apollo-ireland.akamaized.net/v1/files/xvl64dfbl6yz2-UA/image;s=644x461",ImageThumbnailUrl="https://www.picclickimg.com/d/l400/pict/323780263538_/Madonna-You-Can-Dance-Lp-Og-1987-Compilation.jpg"},
   //         new Vinyl{VinylId=1,Name="The Who", Price=16.56M,ShortDescription="First album",LongDescription="Most rated album", Category = categoryRepository.AllCategories.ToList()[1],ImageThumbnailUrl="https://images-na.ssl-images-amazon.com/images/I/71nM3iWRrBL._AC_SY879_.jpg"},
   //new Vinyl{VinylId=1,Name="Madonna", Price=12.56M,ShortDescription="First album",LongDescription="Most rated album", Category = categoryRepository.AllCategories.ToList()[2],ImageThumbnailUrl="https://images.radiox.co.uk/images/67648?crop=16_9&width=660&relax=1&signature=eByuvCrWDgvOazgvkXyoU7P248Y=" }
   //         };
   //     public IEnumerable<Vinyl> VinylsOfTheWeek { get; }
   //     public Vinyl GetVinylById(int vinylId)
   //     {
   //         return AllVinyls.FirstOrDefault(v => v.VinylId == vinylId);
   //     }
   // }
}
