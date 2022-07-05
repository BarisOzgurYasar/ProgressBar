using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolbar.DataAcses.EntityFramewor;
using toolbar.Entities;

namespace toolbar.Busnies
{
    public class MyTimesManager
    {
        private MytimesDal _mytimesDal = new MytimesDal();

        public List<MyTimes> GetAll()
        {
            return _mytimesDal.GetAll();
        }

        public MyTimes Get(string time)
        {
            return _mytimesDal.Get(p => p.now == time);
        }

        public void Add(MyTimes mytime)
        {
            _mytimesDal.Add(mytime);
        }

        public void Update(MyTimes mytime)
        {
            _mytimesDal.Update(mytime);
        }

        public void Delete(MyTimes mytime)
        {
            try
            {
                _mytimesDal.Delete(mytime);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi!");
            }
        }
    }
}
