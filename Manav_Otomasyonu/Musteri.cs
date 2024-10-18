using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_Otomasyonu
{
    internal class Musteri<T> where T : class
    {
        internal static List<T> sepet = new List<T>();
    }
}

