using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE302MufreDATA
{
    public class MufreDAT
    {
        public List<List<string>> Veriler { get; set; } // Tablo1 Listesi

        public List<List<string>> Veriler2 { get; set; } // Tablo2 Listesi

        public List<List<string>> Veriler3 { get; set; } // Tablo3 Listesi


        public string duzenleyen_kisi { get; set; }

        public List<string> SecilenDegerler { get; set; } // RadioButton Listeleri
        public bool ingilizce { get; set; }
        public bool turkce { get; set; }
        public bool ikinci_yabanci_dil { get; set; }

        public bool zorunlu { get; set; }
        public bool secmeli { get; set; }

        public bool on_lisans { get; set; }
        public bool lisans { get; set; }

        public bool yuksek_lisans { get; set; }
        public bool doktora { get; set; }

        public bool yuz_yuze { get; set; }
        public bool cevrim_ici { get; set; }
        public bool karma { get; set; }

        public string dersin_adi { get; set; }
        public string dersin_hocasi { get; set; }
        public string dersin_kodu { get; set; }
        public string guz { get; set; }
        public string bahar { get; set; }
        public string teori { get; set; }
        public string uygulama_lab { get; set; }
        public string yerel_kredi { get; set; }
        public string akts { get; set; }
        public string on_kosullar { get; set; }
        public string yontem_teknik { get; set; }

        public string koordinator { get; set; }
        public string ogrtmeleman { get; set; }
        public string yardimci { get; set; }


        public string dersin_amaci { get; set; }

        public string ogrenme_cikti { get; set; }

        public string ders_tanimi { get; set; }

        public bool temelders { get; set; }

        public bool uzmanlikalanders { get; set; }

        public bool destekders { get; set; }

        public bool iletisimders { get; set; }

        public bool beceriders { get; set; }





    }
}
