using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinylStore.Models
{
    public class VinylRepository:IVinylRepository
    {
        private readonly AppDbContext appDbContext;
        public VinylRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Vinyl> AllVinyls
        {
            get
            {
                return appDbContext.Vinyls.Include(c => c.Category); 
            }
        }

        public IEnumerable<Vinyl> VinylsOfTheWeek
        {
            get
            {
                return appDbContext.Vinyls.Include(c => c.Category).Where(p=>p.IsVinylOfTheWeek);
            }
        }

        public Vinyl DeleteVinyl(int vinylId)
        {
            Vinyl dbEntry = appDbContext.Vinyls.FirstOrDefault(v => v.VinylId == vinylId);

            if(dbEntry != null)
            {
                appDbContext.Vinyls.Remove(dbEntry);
                appDbContext.SaveChanges();
            }
            return dbEntry;
        }

        public Vinyl GetVinylById(int vinylId)
        {
            return appDbContext.Vinyls.FirstOrDefault(p => p.VinylId == vinylId);
        }

        public void SaveVinyl(Vinyl vinyl)
        {
            if(vinyl.VinylId == 0)
            {
                appDbContext.Vinyls.Add(vinyl);
            }
            else
            {
                Vinyl dbEntry = appDbContext.Vinyls.FirstOrDefault(v => v.VinylId == vinyl.VinylId);
                if(dbEntry != null)
                {
                    dbEntry.Name = vinyl.Name;
                    dbEntry.ShortDescription = vinyl.ShortDescription;
                    dbEntry.LongDescription = vinyl.LongDescription;
                    dbEntry.Label = vinyl.Label;
                    dbEntry.Price = vinyl.Price;
                    dbEntry.ImageUrl = vinyl.ImageUrl;
                    dbEntry.ImageThumbnailUrl = vinyl.ImageThumbnailUrl;
                    dbEntry.IsVinylOfTheWeek = vinyl.IsVinylOfTheWeek;
                    dbEntry.InStock = vinyl.InStock;
                    dbEntry.CategoryId = vinyl.CategoryId;
                }
                
            }
            appDbContext.SaveChanges();
        }

       



    }
}
