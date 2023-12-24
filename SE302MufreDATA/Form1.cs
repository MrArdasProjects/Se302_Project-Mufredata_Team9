using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SE302MufreDATA
{
    public partial class Form1 : Form
    {
        private string firstJsonFilePath;
        private string secondJsonFilePath;
        private bool isEngButtonClicked = false;
        private bool isTrButtonClicked = true;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 920;   // Formun genişliğini 1200 piksel olarak ayarlar
            this.Height = 970;  // Formun yüksekliğini 100*0 piksel olarak ayarlar

            Tables.DataGridSettings2(dataGridView2); 
            Tables.DataGridSettings3(dataGridView3);
            Tables.DataGridSettings(dataGridView1);
            Tables.DataGridSettings4(dataGridView4);

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit; // DataGridView1_CellEndEdit metodu
            dataGridView3.CellEndEdit += DataGridView3_CellEndEdit; // DataGridView3_CellEndEdit metodu
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView1_CellEndEdit metodunu çağırma
            Tables.DataGridView1_CellEndEdit(dataGridView1);
        }
        private void DataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Tables.DataGridView3_CellEndEdit(dataGridView3);
        }


        // JSON Kaydetme 
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            MufreDAT list = new MufreDAT();
            list.SecilenDegerler_ChosenValues = new List<string>();
            
            List<List<string>> tabloVerileri = new List<List<string>>();
            
            List<List<string>> tabloVerileri2 = new List<List<string>>();
            
            List<List<string>> tabloVerileri3 = new List<List<string>>();

            List<List<string>> tabloVerileri4 = new List<List<string>>();


            // Tablo verilerini al
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri.Add(satir);
                }
            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri2.Add(satir);
                }
            }

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri3.Add(satir);
                }
            }


            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView4.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView4.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri4.Add(satir);
                }
            }



            try
            {
                // Kullanıcının girdiği değeri al

                if (ingilizce_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(ingilizce_radiobutton.Text);
                }

                if (turkce_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(turkce_radiobutton.Text);
                }

                if (ikinciyabancidil_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(ikinciyabancidil_radiobutton.Text);
                }

                if (zorunlu_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(zorunlu_radiobutton.Text);
                }

                if (secmeli_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(secmeli_radiobutton.Text);
                }

                if (onlisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(onlisans_radiobutton.Text);
                }

                if (lisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(lisans_radiobutton.Text);
                }

                if (yukseklisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(yukseklisans_radiobutton.Text);
                }

                if (doktora_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(doktora_radiobutton.Text);
                }

                if (yuzyuze_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(yuzyuze_radiobutton.Text);
                }

                if (cevrimici_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(cevrimici_radiobutton.Text);
                }

                if (karma_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(karma_radiobutton.Text);
                }

                if (radioButton1.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton3.Text);
                }
                if (radioButton4.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton4.Text);
                }
                if (radioButton5.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton5.Text);
                }


                string duzenleyenKisi_editorName= duzenleyen_kisi_textbox.Text;
                string dersin_adi = dersinadi_textbox.Text;
                string dersin_kodu = kod_textbox.Text;
                string guz = guz_textbox.Text;
                string bahar = bahar_textbox.Text;
                string teori = teori_textbox.Text;
                string uyglab = uyglab_textbox.Text;
                string kredi = kredi_textbox.Text;
                string akts = akts_textbox.Text;
                string kosul = kod_textbox.Text;
                string teknik = teknik_textbox.Text;
                string koordinator = koordinator_textbox.Text;
                string ogrtmeleman = ogrtmeleman_textbox.Text;
                string yardimci = yardimci_textbox.Text;
                string dersin_amaci = dersinamaci_textbox.Text;
                string ogrenme_cikti = ogrenmecikti_textbox.Text;
                string ders_tanimi = derstanimi_textbox.Text;
                string ders_kitabi = derskitabi_textbox.Text;
                string materyal = materyal_textbox.Text;
                string kisise_notlar = kisisel_notlar_textbox.Text;
             

                // Geçerli tarih ve saat bilgisini al
                DateTime now = DateTime.Now;
                string tarih = now.ToString("dd/MM/yyyy");

                // SaveFileDialog oluştur
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                saveFileDialog.Title = "JSON Dosyası Kaydet";
                saveFileDialog.FileName = $"syllabus {dersin_kodu}_{now.ToString("dd MM yyyy_HH mm ss")}_{duzenleyenKisi_editorName}_TR.json";

                // Kullanıcıdan dosya yolu seçmesini iste
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosyanın yolu
                    string dosyaYolu = saveFileDialog.FileName;
                    string folderPath = Path.Combine(Path.GetDirectoryName(dosyaYolu), dersin_kodu);

                    // Create the folder if it doesn't exist
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // Append the file name to the folder path
                    string fullFilePath = Path.Combine(folderPath, Path.GetFileName(dosyaYolu));

                    // JSON verilerini temsil eden bir nesne oluştur
                    MufreDAT kisi = new MufreDAT
                    {

                        duzenleyenKisi_editorName = duzenleyenKisi_editorName,


                        dersinAdi_CourseName = dersin_adi,
                        dersinKodu_Code = dersin_kodu,
                        guz_Fall = guz,
                        bahar_Spring = bahar,
                        teori_Theory = teori,
                        uygulamaLab_ApplicationLab = uyglab,
                        akts_ects = akts,
                        yerelKredi_LocalCredits = kredi,
                        onKosullar_Prerequisities = kosul,
                        yontemTeknik_MethodsTechniques = teknik,
                        koordinator_Coordinator = koordinator,
                        ogretimElemani_Lecturer = ogrtmeleman,
                        asistan_Assistant = yardimci,
                        dersinAmaci_CourseObjectives = dersin_amaci,
                        ogrenmeCikti_LearningOutcomes = ogrenme_cikti,  
                        dersTanimi_CourseDescripiton = ders_tanimi,
                        dersKitabi_CourseBook = ders_kitabi,
                        materyal_Material = materyal,
                        kisiselNotlar_PersonalNotes = kisise_notlar,
                       

                        haftalıkKonular_WeeklySubjects = tabloVerileri2,
                        degerlendirmeOlcutleri_Assessment = tabloVerileri,
                        aktsData_EctsData = tabloVerileri3,
                        ogrenmeCıktılarıData_LearningOutcomesData = tabloVerileri4,




                        ingilizce_English = ingilizce_radiobutton.Checked,
                        turkce_Turkish = turkce_radiobutton.Checked,
                        ikinciYabanciDil_SecondForeignLang = ikinciyabancidil_radiobutton.Checked,

                        zorunlu_Required = zorunlu_radiobutton.Checked,
                        secmeli_Elective = secmeli_radiobutton.Checked,

                        onLisans_ShortCycle = onlisans_radiobutton.Checked,
                        lisans_FirstCycle = lisans_radiobutton.Checked,
                        yuksekLisans_SecondCycle = yukseklisans_radiobutton.Checked,
                        doktora_ThirdCycle = doktora_radiobutton.Checked,

                        yuzYuze_FaceToFace = yuzyuze_radiobutton.Checked,
                        cevrimIci_Online = cevrimici_radiobutton.Checked,
                        karma_Blended = karma_radiobutton.Checked,

                        temelDers_Core = radioButton1.Checked,
                        uzmanlikAlanDers_MajorArea = radioButton2.Checked,
                        destekDers_Supportive = radioButton3.Checked,  
                        iletisimDers_CommManagement = radioButton4.Checked,    
                        beceriDers_Skill = radioButton5.Checked,

                    };



                    // Nesneyi JSON formatına dönüştür
                    string json = JsonConvert.SerializeObject(kisi);

                    // JSON'u dosyaya kaydet
                    System.IO.File.WriteAllText(fullFilePath, json);

                    MessageBox.Show("JSON dosyası kaydedildi.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        } 
        // JSON Kaydetme ENG
        private void btnKaydetENG_Click(object sender, EventArgs e)
        {

            MufreDAT list = new MufreDAT();
            list.SecilenDegerler_ChosenValues = new List<string>();
            
            List<List<string>> tabloVerileri = new List<List<string>>();
            
            List<List<string>> tabloVerileri2 = new List<List<string>>();
            
            List<List<string>> tabloVerileri3 = new List<List<string>>();

            List<List<string>> tabloVerileri4 = new List<List<string>>();


            // Tablo verilerini al
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri2.Add(satir);
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri.Add(satir);
                }
            }

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri3.Add(satir);
                }
            }


            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView4.Rows[i];
                if (!row.IsNewRow)
                {
                    List<string> satir = new List<string>();
                    for (int j = 0; j < dataGridView4.Columns.Count; j++)
                    {
                        satir.Add(row.Cells[j].Value != null ? row.Cells[j].Value.ToString() : "");
                    }
                    tabloVerileri4.Add(satir);
                }
            }



            try
            {
                // Kullanıcının girdiği değeri al

                if (ingilizce_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(ingilizce_radiobutton.Text);
                }

                if (turkce_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(turkce_radiobutton.Text);
                }

                if (ikinciyabancidil_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(ikinciyabancidil_radiobutton.Text);
                }

                if (zorunlu_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(zorunlu_radiobutton.Text);
                }

                if (secmeli_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(secmeli_radiobutton.Text);
                }

                if (onlisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(onlisans_radiobutton.Text);
                }

                if (lisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(lisans_radiobutton.Text);
                }

                if (yukseklisans_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(yukseklisans_radiobutton.Text);
                }

                if (doktora_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(doktora_radiobutton.Text);
                }

                if (yuzyuze_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(yuzyuze_radiobutton.Text);
                }

                if (cevrimici_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(cevrimici_radiobutton.Text);
                }

                if (karma_radiobutton.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(karma_radiobutton.Text);
                }

                if (radioButton1.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton3.Text);
                }
                if (radioButton4.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton4.Text);
                }
                if (radioButton5.Checked)
                {
                    list.SecilenDegerler_ChosenValues.Add(radioButton5.Text);
                }


                string duzenleyenKisi_editorName = duzenleyen_kisi_textbox.Text;
                string dersin_adi = dersinadi_textbox.Text;
                string dersin_kodu = kod_textbox.Text;
                string guz = guz_textbox.Text;
                string bahar = bahar_textbox.Text;
                string teori = teori_textbox.Text;
                string uyglab = uyglab_textbox.Text;
                string kredi = kredi_textbox.Text;
                string akts = akts_textbox.Text;
                string kosul = kod_textbox.Text;
                string teknik = teknik_textbox.Text;
                string koordinator = koordinator_textbox.Text;
                string ogrtmeleman = ogrtmeleman_textbox.Text;
                string yardimci = yardimci_textbox.Text;
                string dersin_amaci = dersinamaci_textbox.Text;
                string ogrenme_cikti = ogrenmecikti_textbox.Text;
                string ders_tanimi = derstanimi_textbox.Text;
                string ders_kitabi = derskitabi_textbox.Text;
                string materyal = materyal_textbox.Text;
                string kisise_notlar = kisisel_notlar_textbox.Text;
             


                // Geçerli tarih ve saat bilgisini al
                DateTime now = DateTime.Now;
                string tarih = now.ToString("dd/MM/yyyy");

                // SaveFileDialog oluştur
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                saveFileDialog.Title = "Save JSON File";
                saveFileDialog.FileName = $"SyllabusOf_{dersin_kodu}_{now.ToString("dd MM yyyy_HH mm ss")}_{duzenleyenKisi_editorName}_ENG.json";

                // Kullanıcıdan dosya yolu seçmesini iste
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosyanın yolu
                    string dosyaYolu = saveFileDialog.FileName;

                    string folderPath = Path.Combine(Path.GetDirectoryName(dosyaYolu), dersin_kodu);

                    // Create the folder if it doesn't exist
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    // Append the file name to the folder path
                    string fullFilePath = Path.Combine(folderPath, Path.GetFileName(dosyaYolu));

                    // JSON verilerini temsil eden bir nesne oluştur
                    MufreDAT kisi = new MufreDAT
                    {

                        duzenleyenKisi_editorName = duzenleyenKisi_editorName,


                        dersinAdi_CourseName = dersin_adi,
                        dersinKodu_Code = dersin_kodu,
                        guz_Fall = guz,
                        bahar_Spring = bahar,
                        teori_Theory = teori,
                        uygulamaLab_ApplicationLab = uyglab,
                        akts_ects = akts,
                        yerelKredi_LocalCredits = kredi,
                        onKosullar_Prerequisities = kosul,
                        yontemTeknik_MethodsTechniques = teknik,
                        koordinator_Coordinator = koordinator,
                        ogretimElemani_Lecturer = ogrtmeleman,
                        asistan_Assistant = yardimci,
                        dersinAmaci_CourseObjectives = dersin_amaci,
                        ogrenmeCikti_LearningOutcomes = ogrenme_cikti,  
                        dersTanimi_CourseDescripiton = ders_tanimi,
                        dersKitabi_CourseBook = ders_kitabi,
                        materyal_Material = materyal,
                        kisiselNotlar_PersonalNotes = kisise_notlar,
                       
                      
                    

                        haftalıkKonular_WeeklySubjects = tabloVerileri2,
                        degerlendirmeOlcutleri_Assessment = tabloVerileri,
                        aktsData_EctsData = tabloVerileri3,
                        ogrenmeCıktılarıData_LearningOutcomesData = tabloVerileri4,




                        ingilizce_English = ingilizce_radiobutton.Checked,
                        turkce_Turkish = turkce_radiobutton.Checked,
                        ikinciYabanciDil_SecondForeignLang = ikinciyabancidil_radiobutton.Checked,

                        zorunlu_Required = zorunlu_radiobutton.Checked,
                        secmeli_Elective = secmeli_radiobutton.Checked,

                        onLisans_ShortCycle = onlisans_radiobutton.Checked,
                        lisans_FirstCycle = lisans_radiobutton.Checked,
                        yuksekLisans_SecondCycle = yukseklisans_radiobutton.Checked,
                        doktora_ThirdCycle = doktora_radiobutton.Checked,

                        yuzYuze_FaceToFace = yuzyuze_radiobutton.Checked,
                        cevrimIci_Online = cevrimici_radiobutton.Checked,
                        karma_Blended = karma_radiobutton.Checked,

                        temelDers_Core = radioButton1.Checked,
                        uzmanlikAlanDers_MajorArea = radioButton2.Checked,
                        destekDers_Supportive = radioButton3.Checked,  
                        iletisimDers_CommManagement = radioButton4.Checked,    
                        beceriDers_Skill = radioButton5.Checked,

                    };

                    // Nesneyi JSON formatına dönüştür
                    string json = JsonConvert.SerializeObject(kisi);

                    // JSON'u dosyaya kaydet
                    System.IO.File.WriteAllText(fullFilePath, json);

                    MessageBox.Show("JSON File Save Succesful");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message);
            }
        } 

        // JSON Açma
        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                openFileDialog.Title = "JSON Dosyası Seç";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dosyaYolu = openFileDialog.FileName;
                    string json = System.IO.File.ReadAllText(dosyaYolu);
                    MufreDAT kisi = JsonConvert.DeserializeObject<MufreDAT>(json);

                    // Dosyanın kayıt tarihini al
                    DateTime dosyaKayitTarihi = System.IO.File.GetCreationTime(dosyaYolu);

                    // Tarih Biçimi
                    string formatliTarih = dosyaKayitTarihi.ToString("dd/MM/yyyy HH:mm:ss");

                    // TextBox içine atama yap
                    duzenlenme_tarih_textbox.Text = formatliTarih;

                    //

                    dataGridView1.Rows.Clear();

                    foreach (List<string> satir in kisi.degerlendirmeOlcutleri_Assessment)
                    {
                        dataGridView1.Rows.Add(satir.ToArray());
                    }

                    dataGridView2.Rows.Clear();

                    foreach (List<string> satir in kisi.haftalıkKonular_WeeklySubjects)
                    {
                        dataGridView2.Rows.Add(satir.ToArray());
                    }
                    
                    dataGridView3.Rows.Clear();

                    foreach (List<string> satir in kisi.aktsData_EctsData)
                    {
                        dataGridView3.Rows.Add(satir.ToArray());
                    }

                    dataGridView4.Rows.Clear();

                    foreach (List<string> satir in kisi.ogrenmeCıktılarıData_LearningOutcomesData)
                    {
                        dataGridView4.Rows.Add(satir.ToArray());
                    }




                    duzenleyen_kisi_textbox.Text = kisi.duzenleyenKisi_editorName;
                   

                    dersinadi_textbox.Text = kisi.dersinAdi_CourseName;

                    kod_textbox.Text = kisi.dersinKodu_Code;
                    guz_textbox.Text = kisi.guz_Fall;
                    bahar_textbox.Text = kisi.bahar_Spring;
                    teori_textbox.Text = kisi.teori_Theory;
                    uyglab_textbox.Text = kisi.uygulamaLab_ApplicationLab;
                    kredi_textbox.Text = kisi.yerelKredi_LocalCredits;
                    akts_textbox.Text = kisi.akts_ects;

                    kosul_textbox.Text = kisi.onKosullar_Prerequisities;

                    teknik_textbox.Text = kisi.yontemTeknik_MethodsTechniques;
                    
                    koordinator_textbox.Text = kisi.koordinator_Coordinator;
                    ogrtmeleman_textbox.Text = kisi.ogretimElemani_Lecturer;
                    yardimci_textbox.Text = kisi.asistan_Assistant;

                    dersinamaci_textbox.Text = kisi.dersinAmaci_CourseObjectives;
                    ogrenmecikti_textbox.Text = kisi.ogrenmeCikti_LearningOutcomes;
                    derstanimi_textbox.Text = kisi.dersTanimi_CourseDescripiton;
                    derskitabi_textbox.Text = kisi.dersKitabi_CourseBook;
                    materyal_textbox.Text = kisi.materyal_Material;
                    kisisel_notlar_textbox.Text = kisi.kisiselNotlar_PersonalNotes;

                   


                    turkce_radiobutton.Checked = kisi.turkce_Turkish;
                    ingilizce_radiobutton.Checked = kisi.ingilizce_English;
                    ikinciyabancidil_radiobutton.Checked = kisi.ikinciYabanciDil_SecondForeignLang;

                    zorunlu_radiobutton.Checked = kisi.zorunlu_Required;
                    secmeli_radiobutton.Checked = kisi.secmeli_Elective;

                    onlisans_radiobutton.Checked = kisi.onLisans_ShortCycle;
                    lisans_radiobutton.Checked = kisi.lisans_FirstCycle;
                    yukseklisans_radiobutton.Checked = kisi.yuksekLisans_SecondCycle;
                    doktora_radiobutton.Checked = kisi.doktora_ThirdCycle;

                    yuzyuze_radiobutton.Checked = kisi.yuzYuze_FaceToFace;
                    cevrimici_radiobutton.Checked = kisi.cevrimIci_Online;
                    karma_radiobutton.Checked = kisi.karma_Blended;



                    radioButton1.Checked = kisi.temelDers_Core;
                    radioButton2.Checked = kisi.uzmanlikAlanDers_MajorArea;
                    radioButton3.Checked = kisi.destekDers_Supportive;
                    radioButton4.Checked = kisi.iletisimDers_CommManagement;
                    radioButton5.Checked = kisi.beceriDers_Skill;
                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu: " + ex.Message);

            }
        } 

        // FARK KARŞILAŞTIRMA
        private void comparerbtn_Click(object sender, EventArgs e)
        {
            string file1Content = SelectFileAndReadContent("İlk JSON Dosyasını Seçiniz");
            string file2Content = SelectFileAndReadContent("İkinci JSON Dosyasını Seçiniz");

            if (string.IsNullOrEmpty(file1Content) || string.IsNullOrEmpty(file2Content))
            {
                MessageBox.Show("Lütfen Karşılaştırma Yapmadan Önce İki JSON Dosyası Seçiniz", "!!HATA!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JToken token1 = JToken.Parse(file1Content);
            JToken token2 = JToken.Parse(file2Content);

            string differences = GetDifferences(token1, token2);

            MessageBox.Show(differences, "FARKLAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string SelectFileAndReadContent(string dialogTitle)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                openFileDialog.Title = dialogTitle;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    return File.ReadAllText(selectedFile);
                }
            }

            return null;
        }
        private string GetDifferences(JToken token1, JToken token2)
        {
            StringBuilder differences = new StringBuilder();

            CompareTokens(token1, token2, differences, "");

            if (differences.Length == 0)
            {
                return "JSON Dosyaları Birbirinin Aynısı";
            }
            else
            {
                return differences.ToString();
            }
        }
        private void CompareTokens(JToken token1, JToken token2, StringBuilder differences, string path)
        {
            if (!JToken.DeepEquals(token1, token2))
            {
                switch (token1.Type)
                {
                    case JTokenType.Object:
                        var obj1 = (JObject)token1;
                        var obj2 = (JObject)token2;

                        var addedProperties = obj2.Properties().Where(p => !obj1.Properties().Any(p1 => p1.Name == p.Name));
                        var removedProperties = obj1.Properties().Where(p => !obj2.Properties().Any(p2 => p2.Name == p.Name));

                        foreach (var addedProperty in addedProperties)
                        {
                            differences.AppendLine($"EKLENEN ÖĞE [ {GetModifiedPath(path)}{addedProperty.Name} ]: {addedProperty.Value}\n");
                        }

                        foreach (var removedProperty in removedProperties)
                        {
                            differences.AppendLine($"SİLİNEN ÖĞE [ {GetModifiedPath(path)}{removedProperty.Name} ]: {removedProperty.Value}\n");
                        }

                        foreach (var commonProperty in obj1.Properties().Where(p => obj2.Properties().Any(p2 => p2.Name == p.Name)))
                        {
                            CompareTokens(commonProperty.Value, obj2[commonProperty.Name], differences, $"{path}{commonProperty.Name}\n");
                        }

                        break;

                    case JTokenType.Array:
                        var arr1 = (JArray)token1;
                        var arr2 = (JArray)token2;

                        for (int i = 0; i < Math.Max(arr1.Count, arr2.Count); i++)
                        {
                            if (i >= arr1.Count)
                            {
                                differences.AppendLine($"EKLENEN DEĞER [ {GetModifiedPath(path)}[{i}] ]: {arr2[i]}\n");
                            }
                            else if (i >= arr2.Count)
                            {
                                differences.AppendLine($"SİLİNEN DEĞER [ {GetModifiedPath(path)}[{i}] ]: {arr1[i]}\n");
                            }
                            else
                            {
                                CompareTokens(arr1[i], arr2[i], differences, $"{path}[{i}]");
                            }
                        }

                        break;

                    default:
                        differences.AppendLine($"DEĞİŞTİRİLEN DEĞERLER [ {GetModifiedPath(path)} ]: '{token1}' -> '{token2}'\n");
                        break;
                }
            }
        }
        private string GetModifiedPath(string originalPath)
        {
            if (isEngButtonClicked)
            {
                // Read after "_", excluding the last character
                int underscoreIndex = originalPath.LastIndexOf('_');
                string pathAfterUnderscore = underscoreIndex >= 0 ? originalPath.Substring(underscoreIndex + 1, originalPath.Length - underscoreIndex - 2) : originalPath;

                // Insert spaces before uppercase letters and capitalize the first letter
                string modifiedPath = string.Concat(pathAfterUnderscore.Select((c, i) => i > 0 && char.IsUpper(c) ? " " + c.ToString() : c.ToString())).Trim();

                return modifiedPath;
            }
            else if (isTrButtonClicked)
            {
                // Read before "_", insert spaces before uppercase letters, and capitalize the first letter
                string modifiedPath = originalPath
                    .Split('_')[0] // Take the part before the underscore
                    .Select((c, i) => i > 0 && char.IsUpper(c) ? " " + char.ToUpper(c) : char.ToUpper(c).ToString())
                    .Aggregate((s1, s2) => s1 + s2)
                    .Trim();

                return modifiedPath;
            }
            else
            {
                // Default behavior
                return originalPath;
            }
        }

        // ENG-TR
        private void engButton_Click(object sender, EventArgs e)
        {
            
            trButton.FlatStyle = FlatStyle.Standard;
            engButton.FlatStyle = FlatStyle.Flat;
            engButton.BackColor = Color.Orange;
            trButton.BackColor = SystemColors.Control;
            isEngButtonClicked = true;
            isTrButtonClicked = false;
            btnKaydet.Visible = false;
            btnKaydetENG.Visible = true;
            btnAc.Text = "OPEN";
            comparerbtn.Text = "COMPARE";
            tabPage1.Text = "General Information";
            tabPage6.Text = "General Information-2";
            tabPage2.Text = "Assessments";
            tabPage3.Text = "Weekly Subjects";
            tabPage5.Text = "ECTS / Workload Table";
            label6.Text = "Course Name";
            label6.Location = new System.Drawing.Point(215, 117);
            label7.Text = "Code";
            label8.Text = "Fall";
            label9.Text = "Spring";
            label9.Location = new System.Drawing.Point(210, 166);
            label10.Text = "Theory";
            label10.Location = new System.Drawing.Point(295, 166);
            label16.Text = "Application/Lab";
            label16.Location = new System.Drawing.Point(382, 166);
            label11.Text = "Local Credits";
            label11.Location = new System.Drawing.Point(524, 166);
            label13.Text = "ECTS";
            label14.Text = "Prerequisites";
            label15.Text = "Course Language";
            label15.Location = new System.Drawing.Point(110, 288);
            ingilizce_radiobutton.Text = "English";
            turkce_radiobutton.Text = "Turkish";
            ikinciyabancidil_radiobutton.Text = "Second Foreign Language";
            label2.Text = "Course Type";
            zorunlu_radiobutton.Text = "Required";
            secmeli_radiobutton.Text = "Elective";
            label17.Text = "Course Level";
            label17.Location = new System.Drawing.Point(138, 377);
            onlisans_radiobutton.Text = "Short Cycle";
            lisans_radiobutton.Text = "First Cycle";
            yukseklisans_radiobutton.Text = "Second Cycle";
            doktora_radiobutton.Text = "Third Cycle";
            label18.Text = "Mode of Delivery";
            label18.Location = new System.Drawing.Point(112, 426);
            yuzyuze_radiobutton.Text = "Face-to-Face";
            cevrimici_radiobutton.Text = "Online";
            karma_radiobutton.Text = "Blended";
            label19.Text = "Teaching Methods";
            label19.Location = new System.Drawing.Point(101, 488);
            label3.Text = "and Techniques";
            label3.Location = new System.Drawing.Point(119, 512);
            label12.Text = "Course Coordinator";
            label12.Location = new System.Drawing.Point(90, 562);
            label20.Text = "Course Lecturer(s)";
            label20.Location = new System.Drawing.Point(93, 616);
            label21.Text = "Assistan(s)";
            label21.Location = new System.Drawing.Point(150, 676);
            label22.Text = "Course Objectives\t";
            label22.Location = new System.Drawing.Point(65, 43);
            label23.Text = "Learning Outcomes";
            label23.Location = new System.Drawing.Point(60, 157);
            label24.Text = "Course Derscription";
            label24.Location = new System.Drawing.Point(55, 292);
            label25.Text = "Course Category";
            radioButton1.Text = "Core Course";
            radioButton2.Text = "Major Area Course";
            radioButton3.Text = "Supportive Course";
            radioButton4.Text = "Communication and Management Skills Course\t";
            radioButton5.Text = "Transferable Skill Course";
            label26.Text = "Course Notes/Textbooks\r\n";
            label26.Location = new System.Drawing.Point(27, 474);
            label27.Text = "Suggested Materials";
            label27.Location = new System.Drawing.Point(50, 573);
            Hafta.HeaderText = "Week";
            Konular.HeaderText = "Subjects";
            On_hazirlik.HeaderText = "Required Materials";
            yariyilaktivite.HeaderText = "Semester Activities";
            Sayı.HeaderText = "Number";
            katkipayi.HeaderText = "Weighting";
            activite.HeaderText = "Semester Activities\t";
            sayi.HeaderText = "Number";
            sure.HeaderText = "Duration(Hour)\t";
            is_yuku.HeaderText = "Workload";
            label1.Text = "One Who Edited ";
            label4.Text = "Date :";
            Hafta.HeaderText = "Week";
            yeterlilik.HeaderText = "Program Competencies / Outcomes\t";
            tabPage4.Text = "Course Learning Outcome";
            tabPage7.Text = "Personal Notes";
            label28.Text = "My Personal Notes\r\n";
            //WeeklyEnglish
            Tables.UpdateCellValue(dataGridView2, 14, 1, "Semester Review");
            Tables.UpdateCellValue(dataGridView2, 15, 1, "Exam");
            //AssessmentsEnglish
            Tables.UpdateCellValue(dataGridView1, 0, 0, "Participation");
            Tables.UpdateCellValue(dataGridView1, 1, 0, "Laboratory / Application");
            Tables.UpdateCellValue(dataGridView1, 2, 0, "Field Work");
            Tables.UpdateCellValue(dataGridView1, 3, 0, "Quiz / Studio Critique");
            Tables.UpdateCellValue(dataGridView1, 4, 0, "Homework / Assignment");
            Tables.UpdateCellValue(dataGridView1, 5, 0, "Presentation / Jury");
            Tables.UpdateCellValue(dataGridView1, 6, 0, "Project");
            Tables.UpdateCellValue(dataGridView1, 7, 0, "Portfolio");
            Tables.UpdateCellValue(dataGridView1, 8, 0, "Seminar / Workshop");
            Tables.UpdateCellValue(dataGridView1, 9, 0, "Oral Exam");
            Tables.UpdateCellValue(dataGridView1, 10, 0, "Midterm");
            Tables.UpdateCellValue(dataGridView1, 11, 0, "Final Exam");
            Tables.UpdateCellValue(dataGridView1, 12, 0, "Total");
            //ECTS
            Tables.UpdateCellValue(dataGridView3, 0, 0, "Course Hours");
            Tables.UpdateCellValue(dataGridView3, 1, 0, "Laboratory / Application Hours");
            Tables.UpdateCellValue(dataGridView3, 2, 0, "Study Hours out of Class");
            Tables.UpdateCellValue(dataGridView3, 3, 0, "Field Work");
            Tables.UpdateCellValue(dataGridView3, 4, 0, "Quiz / Studio Critique");
            Tables.UpdateCellValue(dataGridView3, 5, 0, "Homework");
            Tables.UpdateCellValue(dataGridView3, 6, 0, "Presentation / Jury");
            Tables.UpdateCellValue(dataGridView3, 7, 0, "Project");
            Tables.UpdateCellValue(dataGridView3, 8, 0, "Portfolio");
            Tables.UpdateCellValue(dataGridView3, 9, 0, "Seminar / Workshop");
            Tables.UpdateCellValue(dataGridView3, 10, 0, "Oral Exam");
            Tables.UpdateCellValue(dataGridView3, 11, 0, "Midterm");
            Tables.UpdateCellValue(dataGridView3, 12, 0, "Final Examı");
            Tables.UpdateCellValue(dataGridView3, 13, 0, "Total");
        }
        private void trButton_Click(object sender, EventArgs e)
        {
            engButton.FlatStyle = FlatStyle.Standard;
            trButton.FlatStyle = FlatStyle.Flat;
            trButton.BackColor = Color.Orange;
            engButton.BackColor = SystemColors.Control;
            isEngButtonClicked = false;
            isTrButtonClicked = true;
            btnKaydet.Visible = true;
            btnKaydetENG.Visible = false;
            btnAc.Text = "AÇ";
            comparerbtn.Text = "KARŞILAŞTIR";
            tabPage1.Text = "Genel Bilgiler";
            tabPage6.Text = "Genel Bilgiler-2";
            tabPage2.Text = "Değerlendirme Ölçütleri";
            tabPage3.Text = "Haftalık Konular";
            tabPage5.Text = "AKTS / İş Yükü Tablosu";
            label6.Text = "Dersin Adı";
            label6.Location = new System.Drawing.Point(239, 117);
            label7.Text = "Kodu";
            label8.Text = "Güz";
            label9.Text = "Bahar";
            label9.Location = new System.Drawing.Point(215, 166);
            label10.Text = "Teori";
            label10.Location = new System.Drawing.Point(303, 166);
            label16.Text = "Uygulama/Lab";
            label16.Location = new System.Drawing.Point(389, 166);
            label11.Text = "Yerel Kredi";
            label11.Location = new System.Drawing.Point(531, 166);
            label13.Text = "AKTS";
            label14.Text = "Ön Koşul(lar)";
            label15.Text = "Dersin Dili";
            label15.Location = new System.Drawing.Point(155, 288);
            ingilizce_radiobutton.Text = "İngilizce";
            turkce_radiobutton.Text = "Türkçe";
            ikinciyabancidil_radiobutton.Text = "İkinci Yabancı Dil";
            label2.Text = "Dersin Türü";
            zorunlu_radiobutton.Text = "Zorunlu";
            secmeli_radiobutton.Text = "Seçmeli";
            label17.Text = "Dersin Düzeyi";
            label17.Location = new System.Drawing.Point(132, 377);
            onlisans_radiobutton.Text = "Ön Lisans";
            lisans_radiobutton.Text = "Lisans";
            yukseklisans_radiobutton.Text = "Yüksek Lisans";
            doktora_radiobutton.Text = "Doktora";
            label18.Text = "Dersin Veriliş Şekli";
            label18.Location = new System.Drawing.Point(99, 426);
            yuzyuze_radiobutton.Text = "Yüz Yüze";
            cevrimici_radiobutton.Text = "Çevrim içi";
            karma_radiobutton.Text = "Karma";
            label19.Text = "Dersin Öğretim";
            label19.Location = new System.Drawing.Point(101, 488);
            label3.Text = "Yöntem ve Teknikleri";
            label3.Location = new System.Drawing.Point(79, 512);
            label12.Text = "Dersin Koordinatörü";
            label12.Location = new System.Drawing.Point(87, 562);
            label20.Text = "Öğretim Eleman(lar)ı";
            label20.Location = new System.Drawing.Point(85, 616);
            label21.Text = "Yardımcı(lar)ı";
            label21.Location = new System.Drawing.Point(138, 676);
            label22.Text = "Dersin Amacı\t";
            label22.Location = new System.Drawing.Point(96, 43);
            label23.Text = "Öğrenme Çıktıları";
            label23.Location = new System.Drawing.Point(69, 157);
            label24.Text = "Ders Tanımı";
            label24.Location = new System.Drawing.Point(103, 292);
            label25.Text = "Ders Kategorisi";
            radioButton1.Text = "Temel Ders";
            radioButton2.Text = "Uzmanlık/Alan Dersleri";
            radioButton3.Text = "Destek Dersleri";
            radioButton4.Text = "İletişim ve Yönetim Becerileri Dersleri\t";
            radioButton5.Text = "Aktarılabilir Beceri Dersleri";
            label26.Text = "Ders Kitabı";
            label26.Location = new System.Drawing.Point(110, 474);
            label27.Text = "Önerilen Materyaller";
            label27.Location = new System.Drawing.Point(45, 573);
            Hafta.HeaderText = "Hafta";
            Konular.HeaderText = "Konular";
            On_hazirlik.HeaderText = "Ön Hazırlık";
            yariyilaktivite.HeaderText = "Yarıyıl Aktiviteleri";
            Sayı.HeaderText = "Sayı";
            katkipayi.HeaderText = "Katkı Payı %";
            activite.HeaderText = "Yarıyıl Aktiviteleri\t";
            sayi.HeaderText = "Sayı";
            sure.HeaderText = "Süre (Saat)\t";
            is_yuku.HeaderText = "İş Yükü";
            label1.Text = "Düzenleyen Kişi ";
            label4.Text = "Tarih :";
            Hafta.HeaderText = "Hafta";
            yeterlilik.HeaderText = "Program Yeterlilikleri / Çıktıları\t";
            tabPage4.Text = "Dersin Öğrenme Çıktıları";
            tabPage7.Text = "Kişisel Notlar";
            label28.Text = "Kişisel Notlarım\r\n";
            //HaftalıkTürkçe
            Tables.UpdateCellValue(dataGridView2, 14, 1, "Dersin Gözden Geçirilmesi");
            Tables.UpdateCellValue(dataGridView2, 15, 1, "Fina Sınavı");
            //DeğerlendirmeÖlçütleriTürkçe
            Tables.UpdateCellValue(dataGridView1, 0, 0, "Katılım");
            Tables.UpdateCellValue(dataGridView1, 1, 0, "Laboratuvar / Uygulama");
            Tables.UpdateCellValue(dataGridView1, 2, 0, "Arazi Çalışması");
            Tables.UpdateCellValue(dataGridView1, 3, 0, "Küçük Sınav / Stüdyo Kritiği");
            Tables.UpdateCellValue(dataGridView1, 4, 0, "Ödev");
            Tables.UpdateCellValue(dataGridView1, 5, 0, "Sunum / Juri Önünde Sunum");
            Tables.UpdateCellValue(dataGridView1, 6, 0, "Proje");
            Tables.UpdateCellValue(dataGridView1, 7, 0, "Portfolyo");
            Tables.UpdateCellValue(dataGridView1, 8, 0, "Seminer / Çalıştay");
            Tables.UpdateCellValue(dataGridView1, 9, 0, "Sözlü Sınav");
            Tables.UpdateCellValue(dataGridView1, 10, 0, "Ara Sınav");
            Tables.UpdateCellValue(dataGridView1, 11, 0, "Final Sınavı");
            Tables.UpdateCellValue(dataGridView1, 12, 0, "Toplam");
            //AKTS
            Tables.UpdateCellValue(dataGridView3, 0, 0, "Teorik Ders Saati");
            Tables.UpdateCellValue(dataGridView3, 1, 0, "Laboratuvar / Uygulama Saati");
            Tables.UpdateCellValue(dataGridView3, 2, 0, "Sınıf Dışı Ders Çalışması");
            Tables.UpdateCellValue(dataGridView3, 3, 0, "Arazi Çalışması");
            Tables.UpdateCellValue(dataGridView3, 4, 0, "Küçük Sınav / Stüdyo Kritiği");
            Tables.UpdateCellValue(dataGridView3, 5, 0, "Ödev");
            Tables.UpdateCellValue(dataGridView3, 6, 0, "Sunum / Juri Önünde Sunum");
            Tables.UpdateCellValue(dataGridView3, 7, 0, "Proje");
            Tables.UpdateCellValue(dataGridView3, 8, 0, "Portfolyo");
            Tables.UpdateCellValue(dataGridView3, 9, 0, "Seminer / Çalıştay");
            Tables.UpdateCellValue(dataGridView3, 10, 0, "Sözlü Sınav");
            Tables.UpdateCellValue(dataGridView3, 11, 0, "Ara Sınav");
            Tables.UpdateCellValue(dataGridView3, 12, 0, "Final Sınavı");
            Tables.UpdateCellValue(dataGridView3, 13, 0, "Toplam");
        }
    }
}
