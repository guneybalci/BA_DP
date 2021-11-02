using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralObserver
{
    // Observer: Üzerinde değişik olan nesnenin yani o nesne'nin davranışı ile ilgilinen gözlemci Design Patterndir.
    // Observer Design Pattern: 1-Çok ilişki varsa ise Observer! Mediator ÇOK-ÇOK kullanılır. Subjective'i takip eden kim var ise kim ABONE olmuşsa o listedeki herkesin haber olmasını sağlar. Abstrach ve Interface ile yapıyı sağlarız.
    // Bir işi liste ile paylaşcaksak observer.

    /*
            Observer tasarım deseni behavior grubununa ait, bir nesnede meydana gelen değişikliklerde içinde bulundurduğu listede bulunan nesnelere haber gönderen tasarım desenidir. Observer tasarım deseninin uluslar arası kullanıma  göre en sık kullanılan tasarım desenlerindendir. 

            Observer tasarım deseni; birbirleri ile bire çok (yani bir nesnenin içinde başka bir nesnenin listesinin bulunması olarak düşünebiliriz) ilişki olan nesneler arasında olay bazlı bir etkileşim olduğu durumları düzenler. Örnek senaryo olarak;

            Bir e-ticaret sitesinde bir üründeki stok değişiminde o ürünü takip eden üyelere haber verilmesi.

            Ham madde – ürün ilişkisi olan bir durumda, ham maddenin fiyatı değişince ürünün fiyatının da değişmesi.

            Facebook da ki bir iletiye yorum yapılması durumunda o iletiye yorum yapan ve beğenen üyelere bildirim gitmesi

            Subject:Takip edilecek nesneyi Subject terimiyle ifade etmekteyiz.

            Observer:Subject’i takip edecek olan aboneler tek tip olmayabilirler.İşte böyle bir durumda birden fazla tipe arayüz görevi görecek abstract yahut interface yapımıza Observer denmektedir. 

            Concrete:Subject’i takip eden nesnelerdir.

             */

    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Class olduğu için new'lenemz
            KitapUrunu kitapUrunu = new Urun("Pirayeye Mektuplar",10.25M);
            kitapUrunu.takipListesi.Add(new Uye() { Email = "test@gmail.com" });
            kitapUrunu.takipListesi.Add(new Uye() { Email = "deneme@gmail.com" });

            // Kitap'ın yeni değeri:
            kitapUrunu.Fiyat = 8M;
        }
    }
}
