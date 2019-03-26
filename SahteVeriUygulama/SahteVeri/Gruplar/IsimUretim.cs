using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri.Gruplar
{
  public  class IsimUretim
    {
        private string[] _names = { "Büşra", "Ömer Can", "Emre", "Ali", "Vedat" };
        private string[] _surnames = {"Seçmeoğlu", "Danacıoğlu", "İşleyen", "Kavak", "Baysal"};
        private Random _random;

        public IsimUretim()
        {
            _random = new Random();
        }
        public string IsimGonder()
        {
            return _names[_random.Next(_names.Length)];
        }
        public string SoyisimGonder()
        {
            return _surnames[_random.Next(_surnames.Length)];
        }


    }
}
