using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE302MufreDATA
{
    public class MufreDAT
    {
        public string duzenleyenKisi_editorName { get; set; }

        public string dersinAdi_CourseName { get; set; }
        public string dersinHocasi_Lecturer { get; set; }
        public string dersinKodu_Code { get; set; }
        public string guz_Fall { get; set; }
        public string bahar_Spring { get; set; }
        public string teori_Theory { get; set; }
        public string uygulamaLab_ApplicationLab { get; set; }
        public string yerelKredi_LocalCredits { get; set; }
        public string akts_ects { get; set; }
        public string onKosullar_Prerequisities { get; set; }

        public List<string> SecilenDegerler_ChosenValues { get; set; } // RadioButton Listeleri
        public bool ingilizce_English { get; set; }
        public bool turkce_Turkish { get; set; }
        public bool ikinciYabanciDil_SecondForeignLang { get; set; }

        public bool zorunlu_Required { get; set; }
        public bool secmeli_Elective { get; set; }

        public bool onLisans_ShortCycle { get; set; }
        public bool lisans_FirstCycle { get; set; }
        public bool yuksekLisans_SecondCycle { get; set; }
        public bool doktora_ThirdCycle { get; set; }

        public bool yuzYuze_FaceToFace { get; set; }
        public bool cevrimIci_Online { get; set; }
        public bool karma_Blended { get; set; }

        public string yontemTeknik_MethodsTechniques { get; set; }

        public string koordinator_Coordinator { get; set; }
        public string ogretimElemani_Lecturer { get; set; }
        public string asistan_Assistant { get; set; }

        public string dersKitabi_CourseBook { get; set; }

        public string materyal_Material { get; set; }

        public string kisiselNotlar_PersonalNotes { get; set; }


        public string dersinAmaci_CourseObjectives { get; set; }
        public string ogrenmeCikti_LearningOutcomes { get; set; }
        public string dersTanimi_CourseDescripiton { get; set; }

        public bool temelDers_Core { get; set; }
        public bool uzmanlikAlanDers_MajorArea { get; set; }
        public bool destekDers_Supportive { get; set; }
        public bool iletisimDers_CommManagement { get; set; }
        public bool beceriDers_Skill { get; set; }

        public List<List<string>> haftalıkKonular_WeeklySubjects { get; set; } // Tablo2 Listesi

        public List<List<string>> degerlendirmeOlcutleri_Assessment { get; set; } // Tablo1 Listesi

        public List<List<string>> aktsData_EctsData { get; set; } // Tablo3 Listesi

        public List<List<string>> ogrenmeCıktılarıData_LearningOutcomesData { get; set; } // Tablo4 Listesi


    }
}
