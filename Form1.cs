using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void komediToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
         richTextBox1.Text = "Infinity War'la korkunç titan Thanos amacına ulaşmış ve evrenin yarısını yok etmişti. Russo Kardeşler'in yeniden yönetmen koltuğunda oturduğu Avengers: Endgame'de evrenin sevilen kahramanları Captain Marvel'ı da yanlarına alarak her şeyleri pahasına Thanos'a karşı mücadeleyi sürdürecekler.";
            listBox1.Items.Add("Avengers Endgame");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void xMenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= "X-Men ekibi önemli bir yol ayrımına gelmiştir. Uzun çalışmalar sonucunda mutantların sıradan insanlar gibi yaşama olanağı sağlanmıştır.Mutantlar Amerikan hükumeti'nin emriyle mutantların tedavi edilmesi için üretilmiş ve daha da ileri gidilerek bir silaha dönüştürülmüş bu tedavinin kendilerine zorla uygulanacağını fark etmiştir. Sonrasında mutantlar arasında tartışmalar ve bu tedaviye karşı karşı örgütlenmeler başlayacaktır. Örgütlenme adeta bir direnişe dönmüştür ve direnişin başında Magento önderlik etmektedir.";
            listBox1.Items.Add("X Men 3");
            listBox2.Items.Add(toolStripComboBox1.Text);

        }

        private void theConjuringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= "Amityville'den önce, Harrisville vardı. Gerçek bir yaşam öyküsüne dayanan,The Conjuring -Korku Seansı dünyaca tanınmış şeytan ve cinlerin varlığını araştıran bilim uzmanı Ed ve Lorraine Warren'in, hikayesini anlatmakta.";
            listBox1.Items.Add("The Conjuring");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void theOthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Amerika İkinci Dünya Savaşı'nın yaralarını sarmaya çalışmaktadır. New Jersey'de hayatını devam ettirmekte olan Grave ise savaşta eşini kaybetmiştir. Çocuklarının güneşe karşı alerjisi olduğundan oldukça karanlık bir evde yaşamaktadırlar. Grace, onlardan yardım almak üzere malikanelerine gelen insanlara yardım edip onlara iş vermektedir. Grace'in kızı olan Anne ise, Victor isimli bir hayali arkadaşa sahiptir. Bir gün oluşan sis yüzünden evin dünyanın geriye kalanıyla olan irtibatı tamamen kesilir. Grace ve çocukları, bir türlü güvenemedikleri çalışanlarıyla beraber yalnız kalmışlardır.";
            listBox1.Items.Add("The Others");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void harryPotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Voldemort hem Muggle hem de büyücüler dünyasındaki kıskacını daraltmaktadır ve Hogwarts artık bir zamanlar olduğu güvenli liman değildir. Harry tehlikenin kalenin içinde bile olabileceğinden şüphelenirken, Dumbledore da Harry’yi hızla yaklaşmakta olduğunu bildiği nihai savaşa hazırlamaya her zamankinden kararlıdır. Birlikte, Voldemort’un savunma hattını kırmanın yollarını ararlar. Bu amaçla, Dumbledore eski bir dostu ve meslektaşı olan, çok önemli bilgilere sahip olduğunu düşündüğü Profesör Horace Slughorn’u görevlendirir. Profesör iyi bağlantıları olan, iyi yaşamayı seven, saf bir insandır. Bu arada, öğrenciler bambaşka bir rakibin kuşatması altındadırlar: Gençlik hormonları zirveye tırmanmaktadır. Harry, Ginny’ye gitgide daha çok aşık olmaktadır; ama Dean Thomas’ın da durumu aynıdır. Lavender Brown ise kendisi için doğru kişinin Ron olduğuna karar verir. Hesaba katmadığı şey ise Romilda Vane’in çikolatalarıdır! Diğer yandan Hermione da kıskançlıktan çatlamaktadır ama duygularını göstermemeye kararlıdır. Romantizm dallanıp budaklanırken, bir öğrenci tüm bunların dışında kalır. O, karanlık bir şekilde de olsa ismini hafızalara kazımayı kafasına koymuştur. Havada aşk kokusu vardır ama trajedi kapıdadır ve Hogwarts bir daha asla aynı olamayabilir.";
            listBox1.Items.Add("Harry Potter ve Melez Prens");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kralın Dönüşü, Peter Jacksonın üçünü bir arada çekerek sinemaya uyarladığı Tolkienin ölümsüz eseri Yüzüklerin Efendisinin son bölümünü beyazperdeye taşıyor. Kıyamet günü ortamını yaşayan Orta Dünyada, Yüzük Savaşının son ve en büyük mücadelesine hoşgeldiniz. Bir yanda güvenilmez Gollumun rehberlik ettiği yüzük taşıyıcısı Frodo ve yoldaşı Sam, Mordora ulaşıp Tek Yüzükü yokedebilecekleri tek yere götürmeye çalışıyorlar.";
            listBox1.Items.Add("Yüzüklerin Efendisi Kralın Dönüşü");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           


        }
    }
}
