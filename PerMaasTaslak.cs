using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_miras_inheritance_ornegi
{
    internal class PerMaasTaslak : PersonelOzlukTaslak
    {
        private int temelUcret;

        public PerMaasTaslak()
        {
            asgarimaas = asgarimaas + (asgarimaas*2);
            temelUcret = asgarimaas;
            para = "TL";
        }

        public void ZamYapDirek (int v)
        {
            temelUcret = asgarimaas + v;
            MaasBilgiGoster();
        }
        public void ZamyapYuzde(double v)
        {
            temelUcret = asgarimaas + Convert.ToInt16(asgarimaas*(v/100));
            MaasBilgiGoster();
        }

        public void MaasBilgiGoster()
        {
            Console.WriteLine($"Maaşa Zam Yapılmıştır, Önceki Maaş {asgarimaas} olup, {(temelUcret-asgarimaas)} kadar zam yapılmıştır. Güncel Maaş : {temelUcret} olmuştur...");
        }
    }
}
