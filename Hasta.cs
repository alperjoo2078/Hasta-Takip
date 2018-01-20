using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Hasta
    {
        public string adi;
        public int ucret;
        public int dogumYili;
        public string cinsiyet;


        public int yas;
        public int indirimliUcret;

        public void YasHesapla()
        {
            yas = DateTime.Now.Year - dogumYili;

        }
        public void IndirimliUcretHesapla()
        {
            if (yas > 65)
            {
                indirimliUcret = 0;
            }
            else if (cinsiyet == "Kadın")
            {
                indirimliUcret = ucret * 80 / 100;
            }
            else if (yas < 15)
            {
                indirimliUcret = ucret * 50 / 100;
            }
            else indirimliUcret = ucret;


        }
















    }
}
