using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Models;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public List<AppUserWorkLocationViewModel> GetUserListWithWorkLocation()
        {
            var context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y=> new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                //WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl,
            }).ToList();
            return values;
        }
    }
}
