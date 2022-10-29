using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_miras_inheritance_ornegi
{
    internal class PersonelOzlukTaslak
    {
        protected string persicil, perisim, persoyisim, permeslek;
        protected int asgarimaas = 6000;
        private string moneyV = "TL";

        public string para
        {
            get { return moneyV; }
            set { moneyV = value; }
        }

        public void PersonelKayit(string persicil, string perisim, string persoyisim, string permeslek)
        {
            this.persicil = persicil;
            this.perisim = perisim;
            this.persoyisim = persoyisim;
            this.permeslek = permeslek;
            if (asgarimaas == 0)
                this.asgarimaas = 6000;
        }

        public void PerKayitSil()
        {
            persicil = null;
            perisim = null;
            persoyisim = null;
            permeslek = null;
            asgarimaas = 0;
            Console.WriteLine("Personel Kayıdı Silinmiştir....");
        }

        public void PerBilgiAl()
        {
            if(persicil != null)
            {
                Console.WriteLine($"Personel Kayıtları \nSicil No: {persicil} \nPersonel : {perisim} {persoyisim} \nMeslek : {permeslek} \nMaaş : {asgarimaas}");
            }
            else
            {
                Console.WriteLine("Lütfen personel kaydı yapınız...");
            }
        }
    }
}
