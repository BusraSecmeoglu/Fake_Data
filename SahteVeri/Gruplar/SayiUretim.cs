using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri.Gruplar
{
   public class SayiUretim
    {
        private Random _random;

        public SayiUretim()
        {
            _random = new Random();
        }

        public int RastgeleSayi(int max=int.MaxValue, int min=int.MinValue)
        {
            return _random.Next(min, max);
        }

        //public double RastgeleSayi( double max = int.MaxValue/10000000, double min = 0)
        //{
        //    double ds = _random.NextDouble();
        //    for (int i = 0; i < bs; i++)
        //    {
        //        ds *= 0.1;
        //    }

        //    return double.MaxValue - ds;
        //}
    }
}
