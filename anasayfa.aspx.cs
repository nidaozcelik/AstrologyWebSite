using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

		Label4.Text = "Aynı Burçların Uyumunu Öğreniyorum...";
        Label5.Text = "Yan Taraftan Onun Burcunu ve Senin Burcunu seçerek Burcunuzun Uyumuna bakabilirsiniz. Burçların farklı özellikleri, farklı karakteristikleri vardır. Bu özelliklerden dolayı, farklı insanların birbiriyle anlaşması burç uyumuna bağlıdır. Burç uyumunda burçların özellikleri baz alınarak liste haline getirilmiştir. Bu liste kontrol edilmeden kolayca yukarıdaki menüden sizin ve uyumunu öğrenmek istediğiniz arkadaşınızın, sevgilinizin veya iş arkadaşınızın burç uyumunu öğrenebilisiniz.";
	}


	protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string[,] burclar;
		burclar = new string[12, 2];
		burclar[0, 0] = "KOÇ";
		burclar[0, 1] = "Alacakları kararlarda oldukça uyumlu olacak Koç burcu mensupları, ortak nokta bulmakta zorlanmazlar. Genelikle aynı şeylerden zevk alan bu ikili, oldukça enerjik ve dinamik bir çift olarak etrafındaki insanlara enerji verirler. İki koç bir araya geldiğinde aralarına kimse giremez ve birlikte zaman geçirirken zamanın nasıl geçtiğini anlamazlar";

		burclar[1, 0] = "BOĞA";
		burclar[1, 1] = "Boğa burcu, toprak grubuna mensuptur. Bu yönüyle oldukça çalışkan, ilişkilerinde sadık, evine bağlı, tutkulu ve bir o kadar da inatçı olduğunu söylemek yanlış olmaz. Boğa burcu, diğer toprak grubu burçları ile anlaşmakta hiç zorlanmaz. Aynı burçtan diğer bir boğa burcu insanı ile de harika bir ilişki yaşayabilir.";

		burclar[2, 0] = "İKİZLER";
		burclar[2, 1] = "kizler burcu, burçlar dünyasında çift karakterli oluşu ile tanınır. Bu durumda da ikizler burcunun diğer bir ikizler burcu ile olan ilişkisi için dört kişilik bir ilişki olacağını söylemek yanlış olmaz. Burada dört farklı kişiden değil, dört farklı karakterden bahsediyoruz.";

		burclar[3, 0] = "YENGEÇ";
		burclar[3, 1] = "Bir yengeci çok iyi anlayabilecek bir başka kişi varsa, o da diğer bir yengeçtir. Her ikisi de aynı burca mensup su grubunun insanları olduklarından, her ikisi de duygusal ve romantiktir. Ayrıca yengeç, en fedakar burçlar arasındadır. İkisinin de bu ilişkide fedakarlık yapacaklarından şüphemiz yok. ";

		burclar[4, 0] = "ASLAN";
		burclar[4, 1] = "Aynı burçtan iki insanın anlaşmaları çok kolay da olabilir çok zor da. Aslında bu, biraz da onlara bağlıdır. Her ikisi de lükse oldukça düşkün olan bir çiftin maddi durumu, zaman zaman zorluklar yaşamalarına neden olabilir. İkisinden birinin biraz tutumlu olmasını tavsiye ediyoruz. ";


		burclar[5, 0] = "BAŞAK";
		burclar[5, 1] = "Bir başağı en iyi anlayabilecek, yine diğer bir başaktır. Birlikte vakit geçirmek, bu ikiliye çok iyi gelecektir. Hem iş hayatında hem aşk hayatında harika bir uyum içinde olan başak ve başak ikilisi, aşk hayatları ile bizden 10 üzerinden 8 puan alıyor. Kalan iki puanı, benzer özellikler taşımalarından kırdık.";


		burclar[6, 0] = "TERAZİ";
		burclar[6, 1] = "Aynı burcun insanları ne kadar iyi anlaşırlar dersiniz? Birlikte bir uyum mu yakalarlar? Yoksa zıtlıkların uyumu daha mı kalıcıdır? Bir teraziye ilgi duyan diğer bir terazi, karşısındakinin zayıf ve güçlü yönlerini çok iyi bilir. Terazi, dengeli ve akıllı bir burçtur. Aklı ile karşısındakini etkilemeyi de çok iyi bilir. ";


		burclar[7, 0] = "AKREP";
		burclar[7, 1] = " Akrep kendine yapılanı asla unutmaz. Birisinden biri büyük bir hata yaparsa, bu ilişki geri dönülmez yollara girebilir. Kimin kimi sokacağı hiç belli olmayan bu ilişki, oldukça tehlikeli görünüyor. Akrep burcu her ne kadar duyguları ile yaşayan, tutkulu ve duygusal kişiler olsa da, ona yapılan bir yanlışı asla unutmaz ve intikamını almadan da o olayın peşini bırakmaz. Her iki tarafın da aynı karaktere sahip olduğunu düşünürsek, birinin yanlış yapması durumunda neler olabileceğini siz düşünün. Her ikisi de seksi, her ikisi de dikkat çekici kişilerdir ve bir ortama çift olarak girdiklerinde, tüm bakışların üzerlerinde olacağından emin olabilirsiniz.";


		burclar[8, 0] = "YAY";
		burclar[8, 1] = "Aynı burca mensup kişiler, genellikle iyi anlaşırlar ancak söz konusu aşk ilişkisi olduğunda durumlar biraz değişebilir. Bir yay, başka bir yaya ilgi duyuyorsa, onun pratik zekası ve entellektüelliği, yine aynı özelliklere sahip olan diğer yayı da etkilemeyi başaracaktır. ";


		burclar[9, 0] = "OĞLAK";
		burclar[9, 1] = "Aynı burçtan iki kişinin bir araya gelmesi, onların ilişkilerinin kusursuz olacağı anlamına gelmez. Aksine, oğlak burcuna mensup bu ikilinin de inatçı yönü ağır bastığından, oğlak ve oğlak ilişkisi her zaman kusursuz yürümeyebilir. Ancak her ikisi de çalışkan kişilerdir.";


		burclar[10, 0] = "KOVA";
		burclar[10, 1] = "kisinin de en büyük hatta tek sorunu inat olan bir ilişkiye sahiptir Kova ile Kova burcu. Genel olarak baktığımızda, gerek zihinsel olarak çok güçlü, gerekse de düşüncelerin birbiri ile uyumlu olduğu eğlenceli bir ilişki görürüz Kova burcu ve Kova burcu arasında. ";


		burclar[11, 0] = "BALIK";
		burclar[11, 1] = "Bir balık burcu, diğer bir balık burcu ile duygusal açıdan oldukça uyumludur. Nitekim hayal gücü geniş olan ve manevi açıdan bakıldığı zaman dünyaya çok zengin bir açıdan yaklaşabilen balıkların, duygusal yönden aralarında pek bir sorun yaşanmaz. Balık burçları arasında ki sorunlar genelde maddi nedenlere bağlıdır.";


		Label4.Text = burclar[ListBox2.SelectedIndex, 0];
		Label5.Text = burclar[ListBox2.SelectedIndex, 1];


	}



	protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{

	}

	protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{

	}

	protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{

	
	}
}