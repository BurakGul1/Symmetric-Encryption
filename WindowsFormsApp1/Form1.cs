using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifrele_Click_Click(object sender, EventArgs e)
        {

            
            int offset_value = Convert.ToInt32(tx_b.Text); // öteleme degeri alınıp dönüşüm yapılıyor.

            for (int i = 0; i < tx_acikmesaj.TextLength; i++)//girilen mesaj tek tek geziliyor.
            {
                int ascii_degeri = tx_acikmesaj.Text[i] - 96;//girilen mesajın harfleri tek tek çekiliyor.
                int y = (offset_value + ascii_degeri);//şifreleme fonksiyonu çalışıyor.

                

                char sifrelenmis_harf = (char)(y + 96);//Her şifrelenen harf tek tek ascii kodda yerine koyuluyor.

                tx_sifrelimesaj.Text += sifrelenmis_harf;//Şifrelenmiş mesaj labelında gösteriliyor.
            }
            
        }

        private void coz_Click(object sender, EventArgs e)
        {
            int offset_value = Convert.ToInt32(tx_b.Text); // öteleme degeri alınıp dönüşüm yapılıyor
            for (int i = 0; i < tx_sifrelimesaj.TextLength; i++)//şifreli mesaj tek tek geziliyor.
            {
                int ascii_value = tx_sifrelimesaj.Text[i] - 96;//şifreli mesajın harfleri tek tek çekiliyor.
                int y = (ascii_value-offset_value);//çözme fonksiyonu çalışıyor.


                char decoded_letter = (char)(y + 96);//Her çözülen harf tek tek ascii kodda yerine koyuluyor.

                cozulen_metin.Text += decoded_letter;//Çözülen mesaj labelında gösteriliyor.
            }
            
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            //Temizle butonunun çalışma metotları yer alıyor.
            tx_b.Clear();
            tx_acikmesaj.Clear();
            tx_sifrelimesaj.Clear();
            cozulen_metin.Clear();
        }

        private void tx_b_MouseClick(object sender, MouseEventArgs e)
        {
            //labelda görülen mesajın tıklayınca silinmesi.
            tx_b.Clear();
        }
    }
}
