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
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public void TAdd(Card t)
        {
            _cardDal.Insert(t);
        }

        public void TDelete(Card t)
        {
            _cardDal.Delete(t);
        }

        public Card? TGetByID(int id)
        {
            return _cardDal.GetByID(id);
        }

        public List<Card> TGetList()
        {
            return _cardDal.GetList();
        }

        public void TUpdate(Card t)
        {
            _cardDal.Update(t);
        }
    }
}
