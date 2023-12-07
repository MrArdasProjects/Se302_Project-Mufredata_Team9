﻿using System;
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

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1400;   // Formun genişliğini 1200 piksel olarak ayarlar
            this.Height = 1200;  // Formun yüksekliğini 100*0 piksel olarak ayarlar

            Tables.DataGridSettings(dataGridView1);
            Tables.DataGridSettings2(dataGridView2);
            Tables.DataGridSettings3(dataGridView3);

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit; // DataGridView1_CellEndEdit metodu
            dataGridView3.CellEndEdit += DataGridView3_CellEndEdit; // DataGridView3_CellEndEdit metodu

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



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            MufreDAT list = new MufreDAT();
            list.SecilenDegerler = new List<string>();

            List<List<string>> tabloVerileri = new List<List<string>>();

            List<List<string>> tabloVerileri2 = new List<List<string>>();

            List<List<string>> tabloVerileri3 = new List<List<string>>();


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



            try
            {
                // Kullanıcının girdiği değeri al

                if (ingilizce_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(ingilizce_radiobutton.Text);
                }

                if (turkce_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(turkce_radiobutton.Text);
                }

                if (ikinciyabancidil_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(ikinciyabancidil_radiobutton.Text);
                }

                if (zorunlu_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(zorunlu_radiobutton.Text);
                }

                if (secmeli_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(secmeli_radiobutton.Text);
                }

                if (onlisans_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(onlisans_radiobutton.Text);
                }

                if (lisans_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(lisans_radiobutton.Text);
                }

                if (yukseklisans_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(yukseklisans_radiobutton.Text);
                }

                if (doktora_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(doktora_radiobutton.Text);
                }

                if (yuzyuze_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(yuzyuze_radiobutton.Text);
                }

                if (cevrimici_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(cevrimici_radiobutton.Text);
                }

                if (karma_radiobutton.Checked)
                {
                    list.SecilenDegerler.Add(karma_radiobutton.Text);
                }

                if (radioButton1.Checked)
                {
                    list.SecilenDegerler.Add(radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    list.SecilenDegerler.Add(radioButton2.Text);
                }
                if (radioButton3.Checked)
                {
                    list.SecilenDegerler.Add(radioButton3.Text);
                }
                if (radioButton4.Checked)
                {
                    list.SecilenDegerler.Add(radioButton4.Text);
                }
                if (radioButton5.Checked)
                {
                    list.SecilenDegerler.Add(radioButton5.Text);
                }


                string duzenleyen_kisi = duzenleyen_kisi_textbox.Text;
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




                // Geçerli tarih ve saat bilgisini al
                DateTime now = DateTime.Now;
                string tarih = now.ToString("dd/MM/yyyy");

                // SaveFileDialog oluştur
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
                saveFileDialog.Title = "JSON Dosyası Kaydet";
                saveFileDialog.FileName = $"syllabus {now.ToString("dd MM yyyy_HH mm ss")}_{duzenleyen_kisi}.json";

                // Kullanıcıdan dosya yolu seçmesini iste
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosyanın yolu
                    string dosyaYolu = saveFileDialog.FileName;

                    // JSON verilerini temsil eden bir nesne oluştur
                    MufreDAT kisi = new MufreDAT
                    {

                        duzenleyen_kisi = duzenleyen_kisi,


                        dersin_adi = dersin_adi,
                        dersin_kodu = dersin_kodu,
                        guz = guz,
                        bahar = bahar,
                        teori = teori,
                        uygulama_lab = uyglab,
                        akts = akts,
                        yerel_kredi = kredi,
                        on_kosullar = kosul,
                        yontem_teknik = teknik,
                        koordinator = koordinator,
                        ogrtmeleman = ogrtmeleman,
                        yardimci = yardimci,
                        dersin_amaci = dersin_amaci,
                        ogrenme_cikti = ogrenme_cikti,
                        ders_tanimi = ders_tanimi,





                        Veriler = tabloVerileri,
                        Veriler2 = tabloVerileri2,
                        Veriler3 = tabloVerileri3,




                        ingilizce = ingilizce_radiobutton.Checked,
                        turkce = turkce_radiobutton.Checked,
                        ikinci_yabanci_dil = ikinciyabancidil_radiobutton.Checked,

                        zorunlu = zorunlu_radiobutton.Checked,
                        secmeli = secmeli_radiobutton.Checked,

                        on_lisans = onlisans_radiobutton.Checked,
                        lisans = lisans_radiobutton.Checked,
                        yuksek_lisans = yukseklisans_radiobutton.Checked,
                        yuz_yuze = yuzyuze_radiobutton.Checked,
                        cevrim_ici = cevrimici_radiobutton.Checked,
                        karma = karma_radiobutton.Checked,

                        temelders = radioButton1.Checked,
                        uzmanlikalanders = radioButton2.Checked,
                        destekders = radioButton3.Checked,
                        iletisimders = radioButton4.Checked,
                        beceriders = radioButton5.Checked,

                    };



                    // Nesneyi JSON formatına dönüştür
                    string json = JsonConvert.SerializeObject(kisi);

                    // JSON'u dosyaya kaydet
                    System.IO.File.WriteAllText(dosyaYolu, json);

                    MessageBox.Show("JSON dosyası kaydedildi.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        } // JSON Kaydetme 

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

                    foreach (List<string> satir in kisi.Veriler)
                    {
                        dataGridView1.Rows.Add(satir.ToArray());
                    }

                    dataGridView2.Rows.Clear();

                    foreach (List<string> satir in kisi.Veriler2)
                    {
                        dataGridView2.Rows.Add(satir.ToArray());
                    }

                    dataGridView3.Rows.Clear();

                    foreach (List<string> satir in kisi.Veriler3)
                    {
                        dataGridView3.Rows.Add(satir.ToArray());
                    }




                    duzenleyen_kisi_textbox.Text = kisi.duzenleyen_kisi;


                    dersinadi_textbox.Text = kisi.dersin_adi;

                    kod_textbox.Text = kisi.dersin_kodu;
                    guz_textbox.Text = kisi.guz;
                    bahar_textbox.Text = kisi.bahar;
                    teori_textbox.Text = kisi.teori;
                    uyglab_textbox.Text = kisi.uygulama_lab;
                    kredi_textbox.Text = kisi.yerel_kredi;
                    akts_textbox.Text = kisi.akts;

                    kosul_textbox.Text = kisi.on_kosullar;

                    teknik_textbox.Text = kisi.yontem_teknik;

                    koordinator_textbox.Text = kisi.koordinator;
                    ogrtmeleman_textbox.Text = kisi.ogrtmeleman;
                    yardimci_textbox.Text = kisi.yardimci;

                    dersinamaci_textbox.Text = kisi.dersin_amaci;
                    ogrenmecikti_textbox.Text = kisi.ogrenme_cikti;
                    derstanimi_textbox.Text = kisi.ders_tanimi;


                    turkce_radiobutton.Checked = kisi.turkce;
                    ingilizce_radiobutton.Checked = kisi.ingilizce;
                    ikinciyabancidil_radiobutton.Checked = kisi.ikinci_yabanci_dil;

                    zorunlu_radiobutton.Checked = kisi.zorunlu;
                    secmeli_radiobutton.Checked = kisi.secmeli;

                    onlisans_radiobutton.Checked = kisi.on_lisans;
                    lisans_radiobutton.Checked = kisi.lisans;
                    yukseklisans_radiobutton.Checked = kisi.yuksek_lisans;
                    doktora_radiobutton.Checked = kisi.doktora;

                    yuzyuze_radiobutton.Checked = kisi.yuz_yuze;
                    cevrimici_radiobutton.Checked = kisi.cevrim_ici;
                    karma_radiobutton.Checked = kisi.karma;



                    radioButton1.Checked = kisi.temelders;
                    radioButton2.Checked = kisi.uzmanlikalanders;
                    radioButton3.Checked = kisi.destekders;
                    radioButton4.Checked = kisi.iletisimders;
                    radioButton5.Checked = kisi.beceriders;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata oluştu: " + ex.Message);

            }
        } // JSON Açma 

        private void comparerbtn_Click(object sender, EventArgs e)
        {

        }


    }


}


