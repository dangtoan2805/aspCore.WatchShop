using System.Collections.Generic;

using aspCore.WatchShop.EF;
using aspCore.WatchShop.Entities;

namespace aspCore.WatchShop.DAOs
{
    public class CustomerDao
    {
        private watchContext _db = null;

        public CustomerDao(watchContext context)
        {
            _db = context;
        }

        public List<Customer> GetCusomters()
        {
            List<Customer> ls = new List<Customer>();
            for (int i = 0; i < 30; i++)
            {
                ls.Add(new Customer() { Phone = "076805221", Name = "Đặng Việt Toàn", Address = "312 Nguyễn Tri Phương, P.8, Quận 10, TP.HCM" });
            }
            return ls;
        }
    }
}