using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SE302MufreDATA
{
    public class Tables
    {
        public static void UpdateCellValue(DataGridView dataGridView, int rowIndex, int columnIndex, string newValue)
    {
        if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count &&
            columnIndex >= 0 && columnIndex < dataGridView.Columns.Count)
        {
            dataGridView.Rows[rowIndex].Cells[columnIndex].Value = newValue;
        }
    }

       
        public static void DataGridSettings3(DataGridView datagridview3)
        {
            datagridview3.RowCount = 14; // 14 satır
            datagridview3.ColumnCount = 4; // 4 sütun

            datagridview3.Dock = DockStyle.Fill;
            datagridview3.AllowUserToResizeColumns = true;
            datagridview3.AllowUserToResizeRows = true;
            datagridview3.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            datagridview3.RowsDefaultCellStyle.ForeColor = Color.Black;
            datagridview3.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            datagridview3.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
            datagridview3.Columns[1].DefaultCellStyle.BackColor = Color.LightGreen;
            datagridview3.Columns[2].DefaultCellStyle.BackColor = Color.LightPink;
            datagridview3.RowHeadersVisible = false;

            for (int i = 0; i < datagridview3.Rows.Count; i++)
            {
                datagridview3.Rows[0].Cells[0].Value = "Teorik Ders Saati";
                datagridview3.Rows[1].Cells[0].Value = "Laboratuvar / Uygulama Ders Saati";
                datagridview3.Rows[2].Cells[0].Value = "Sınıf Dışı Ders Çalışması";
                datagridview3.Rows[3].Cells[0].Value = "Arazi Çalışması";
                datagridview3.Rows[4].Cells[0].Value = "Küçük Sınav / Stüdyo Kritiği";
                datagridview3.Rows[5].Cells[0].Value = "Portfolyo";
                datagridview3.Rows[6].Cells[0].Value = "Ödev";
                datagridview3.Rows[7].Cells[0].Value = "Sunum / Jüri Önünde Sunum";
                datagridview3.Rows[8].Cells[0].Value = "Proje";
                datagridview3.Rows[9].Cells[0].Value = "Seminer/Çalıştay";
                datagridview3.Rows[10].Cells[0].Value = "Sözlü Sınav";
                datagridview3.Rows[11].Cells[0].Value = "Ara Sınavlar";
                datagridview3.Rows[12].Cells[0].Value = "Final Sınavı";
                datagridview3.Rows[13].Cells[0].Value = "Toplam";
            }
        } // AKTS İş Yükü Tablosu

        public static void DataGridSettings2(DataGridView datagridview2) // Haftalık Konular Tablosu
        {
            datagridview2.RowCount = 16; 
            datagridview2.ColumnCount = 3; 

            datagridview2.Dock = DockStyle.Fill;
            datagridview2.AllowUserToResizeColumns = true;
            datagridview2.AllowUserToResizeRows = true;
            datagridview2.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            datagridview2.RowsDefaultCellStyle.ForeColor = Color.Black;
            datagridview2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            datagridview2.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
            datagridview2.Columns[1].DefaultCellStyle.BackColor = Color.LightGreen;
            datagridview2.Columns[2].DefaultCellStyle.BackColor = Color.LightPink;
            datagridview2.RowHeadersVisible = false;


            for (int i = 0; i < datagridview2.Rows.Count; i++)
            {
                datagridview2.Rows[0].Cells[0].Value = "1";
                datagridview2.Rows[1].Cells[0].Value = "2";
                datagridview2.Rows[2].Cells[0].Value = "3";
                datagridview2.Rows[3].Cells[0].Value = "4";
                datagridview2.Rows[4].Cells[0].Value = "5";
                datagridview2.Rows[5].Cells[0].Value = "6";
                datagridview2.Rows[6].Cells[0].Value = "7";
                datagridview2.Rows[7].Cells[0].Value = "8";
                datagridview2.Rows[8].Cells[0].Value = "9";
                datagridview2.Rows[9].Cells[0].Value = "10";
                datagridview2.Rows[10].Cells[0].Value = "11";
                datagridview2.Rows[11].Cells[0].Value = "12";
                datagridview2.Rows[12].Cells[0].Value = "13";
                datagridview2.Rows[13].Cells[0].Value = "14";
                datagridview2.Rows[14].Cells[0].Value = "15";
                datagridview2.Rows[15].Cells[0].Value = "16";
                datagridview2.Rows[14].Cells[1].Value = "Drsin Gözden Geçirilmesi";
                datagridview2.Rows[15].Cells[1].Value = "Final Sınavı";

            }
        }

        public static void DataGridSettings(DataGridView datagridview) // Değerlendirme Ölçütleri Tablosu
        {
            datagridview.RowCount = 13; // 13 satır
            datagridview.ColumnCount = 7; // 7 sütun

            datagridview.Dock = DockStyle.Fill;
            datagridview.AllowUserToResizeColumns = true;
            datagridview.AllowUserToResizeRows = true;
            datagridview.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            datagridview.RowsDefaultCellStyle.ForeColor = Color.Black;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            datagridview.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
            datagridview.Columns[1].DefaultCellStyle.BackColor = Color.LightGreen;
            datagridview.Columns[2].DefaultCellStyle.BackColor = Color.LightPink;
            datagridview.RowHeadersVisible = false;

            for (int i = 0; i < datagridview.Rows.Count; i++)
            {
                datagridview.Rows[0].Cells[0].Value = "Katılım";
                datagridview.Rows[1].Cells[0].Value = "Laboratuvar / Uygulama";
                datagridview.Rows[2].Cells[0].Value = "Arazi Çalışması";
                datagridview.Rows[3].Cells[0].Value = "Küçük Sınav / Stüdyo Kritiği";
                datagridview.Rows[4].Cells[0].Value = "Ödev";
                datagridview.Rows[5].Cells[0].Value = "Sunum / Jüri Önünde Sunum";
                datagridview.Rows[6].Cells[0].Value = "Proje";
                datagridview.Rows[7].Cells[0].Value = "Portfolyo";
                datagridview.Rows[8].Cells[0].Value = "Seminer/Çalıştay";
                datagridview.Rows[9].Cells[0].Value = "Sözlü Sınav";
                datagridview.Rows[10].Cells[0].Value = "Ara Sınav";
                datagridview.Rows[11].Cells[0].Value = "Final Sınavı";
                datagridview.Rows[12].Cells[0].Value = "Toplam";
            }
        }

        public static void DataGridSettings4(DataGridView datagridview4) // Program Çıktıları
        {
            datagridview4.RowCount = 13; // 13 satır
            datagridview4.ColumnCount = 7; // 7 sütun

            datagridview4.Dock = DockStyle.Fill;
            datagridview4.AllowUserToResizeColumns = true;
            datagridview4.AllowUserToResizeRows = true;
            datagridview4.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            datagridview4.RowsDefaultCellStyle.ForeColor = Color.Black;
            datagridview4.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            datagridview4.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
            datagridview4.Columns[1].DefaultCellStyle.BackColor = Color.LightGreen;
            datagridview4.Columns[2].DefaultCellStyle.BackColor = Color.LightPink;
            datagridview4.RowHeadersVisible = false;

            for (int i = 0; i < datagridview4.Rows.Count; i++)
            {
                datagridview4.Rows[0].Cells[0].Value = "1";
                datagridview4.Rows[1].Cells[0].Value = "2";
                datagridview4.Rows[2].Cells[0].Value = "3";
                datagridview4.Rows[3].Cells[0].Value = "4";
                datagridview4.Rows[4].Cells[0].Value = "5";
                datagridview4.Rows[5].Cells[0].Value = "6";
                datagridview4.Rows[6].Cells[0].Value = "7";
                datagridview4.Rows[7].Cells[0].Value = "8";
                datagridview4.Rows[8].Cells[0].Value = "9";
                datagridview4.Rows[9].Cells[0].Value = "10";
                datagridview4.Rows[10].Cells[0].Value = "11";
                datagridview4.Rows[11].Cells[0].Value = "12";
                datagridview4.Rows[12].Cells[0].Value = "13";
                
            }
        } 

        public static void DataGridView1_CellEndEdit(DataGridView dataGridView) // Toplamın 100 Den Büyük Olma Durumu
        {
            int toplam2 = 0;
            int toplam3 = 0;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                object cellValue2 = dataGridView.Rows[i].Cells[1].Value;
                object cellValue3 = dataGridView.Rows[i].Cells[2].Value;

                if (cellValue2 != null && int.TryParse(cellValue2.ToString(), out int deger2))
                {
                    toplam2 += deger2;
                }

                if (cellValue3 != null && int.TryParse(cellValue3.ToString(), out int deger3))
                {
                    toplam3 += deger3;
                }
            }

            if (toplam3 > 100)
            {
                MessageBox.Show("Toplam 100'den Büyük Olamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[1].Value = toplam2.ToString();
            dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[2].Value = toplam3.ToString();
        }

        public static void DataGridView3_CellEndEdit(DataGridView dataGridView3)
        {
            int toplam2 = 0;
            int toplam3 = 0;
            int toplam4 = 0;


            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                object cellValue2 = dataGridView3.Rows[i].Cells[1].Value;
                object cellValue3 = dataGridView3.Rows[i].Cells[2].Value;
                object cellValue4 = dataGridView3.Rows[i].Cells[3].Value;

                if (cellValue2 != null && int.TryParse(cellValue2.ToString(), out int deger2))
                {
                    toplam2 += deger2;
                }

                if (cellValue3 != null && int.TryParse(cellValue3.ToString(), out int deger3))
                {
                    toplam3 += deger3;
                }

                if (cellValue4 != null && int.TryParse(cellValue4.ToString(), out int deger4))
                {
                    toplam4 += deger4;
                }
            }

            dataGridView3.Rows[dataGridView3.Rows.Count - 1].Cells[1].Value = toplam2.ToString();
            dataGridView3.Rows[dataGridView3.Rows.Count - 1].Cells[2].Value = toplam3.ToString();
            dataGridView3.Rows[dataGridView3.Rows.Count - 1].Cells[3].Value = toplam4.ToString();
        }
    }
}

