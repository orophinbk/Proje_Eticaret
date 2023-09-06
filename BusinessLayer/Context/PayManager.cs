using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Context
{
    public class PayManager : IPayService
    {
        IPayDal _payDal;

        public PayManager(IPayDal payDal)
        {
            _payDal = payDal;
        }

        public void TAdd(Pay t)
        {
            _payDal.Insert(t);
        }

        public void TDelete(Pay t)
        {
            _payDal.Delete(t);
        }

        public Pay? TGetByID(int id)
        {
            return _payDal.GetByID(id);
        }

        public List<Pay> TGetList()
        {
            return _payDal.GetList();
        }

        public void TUpdate(Pay t)
        {
            _payDal.Update(t);
        }
    }
}
