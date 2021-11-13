using BookList.Business.Abstract;
using BookList.DataAccess.Abstract;
using BookList.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void InitializeCart(string userId)
        {
            _cartDal.Create(new Cart() { UserId = userId });
        }
    }
}
