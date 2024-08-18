using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    internal class Insan
    {

        public string isim;//field
        string soyisim;
        private int yas;//field
        //Property budur!
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value > 10)
                {
                    yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş değeri uygun değildir.");
                }
            }
        }
        //AutoImplamentedProperty
        public string DogumYeri { get; set; }


        public void isimAl(string isim)
        {
            this.isim = isim;
        }
        public string isimGetir()
        {
            this.isim = isim;
            return isim;
        }
        public void setSoyisim(string data)
        {
            soyisim = data;
        }
        public string getSoyisim()
        {
            return soyisim;
        }
    }
}
