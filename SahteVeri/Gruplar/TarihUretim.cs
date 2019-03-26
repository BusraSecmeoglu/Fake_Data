using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri.Gruplar
{
  public  class TarihUretim
    {
        private Random _random;

        public TarihUretim()
        {
            _random = new Random();
        }
        public DateTime DTarihi()
        {
            DateTime start = new DateTime(1960, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));

            //int yas = _random.Next(18, 80);
            //return DateTime.Now.AddYears(-yas);
        }
    }
}
