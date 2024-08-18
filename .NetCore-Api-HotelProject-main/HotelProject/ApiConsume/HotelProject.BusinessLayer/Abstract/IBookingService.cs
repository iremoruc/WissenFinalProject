using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService: IGenericService<Booking>
    {
        void TBookingStatusChangeApprove(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
        int TGetBookingCount();
        List<Booking> TGetLast6Booking();
    }
}
