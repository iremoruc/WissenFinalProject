using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageSubjectCategoryManager : IMessageSubjectCategoryService
    {
        private readonly IMessageSubjectCategoryDal _messageSubjectCategoryDal;

        public MessageSubjectCategoryManager(IMessageSubjectCategoryDal messageSubjectCategoryDal)
        {
            _messageSubjectCategoryDal = messageSubjectCategoryDal;
        }

        public void TDelete(MessageSubjectCategory t)
        {
            _messageSubjectCategoryDal.Delete(t);
        }

        public MessageSubjectCategory TGetById(int id)
        {
            return _messageSubjectCategoryDal.GetById(id);
        }

        public List<MessageSubjectCategory> TGetList()
        {
            return _messageSubjectCategoryDal.GetList();
        }

        public void TInsert(MessageSubjectCategory t)
        {
            _messageSubjectCategoryDal.Insert(t);
        }

        public void TUpdate(MessageSubjectCategory t)
        {
            _messageSubjectCategoryDal.Update(t);
        }
    }
}
