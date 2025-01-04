using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{/*
  
    Inheritance (Kalıtım), C# ve diğer nesne yönelimli programlama dillerinde, bir sınıfın (class) başka bir sınıfın özelliklerini ve metotlarını devralmasına olanak tanır.
    Bu sayede, kod tekrarını azaltabilir ve daha düzenli, sürdürülebilir bir kod yazabilirsiniz.

    Temel Kavramlar
    Base Class (Ana Sınıf): Özelliklerini ve metotlarını diğer sınıflara devreden sınıftır.
    Derived Class (Türetilmiş Sınıf): Başka bir sınıfın özelliklerini ve metotlarını devralan sınıftır.
 

 class Hayvan
    {
        public string Ad { get; set; }

        public void SesCikar()
        {
            Console.WriteLine("Hayvan bir ses çıkarıyor...");
            Console.ReadLine();
        }
    }

    class Kopek : Hayvan
    {
        public void Havla()
        {
            Console.WriteLine($"{Ad} havlıyor!");
            Console.ReadLine();
        }
    }

    class Kedi : Hayvan
    {
        public void Miyavla()
        {
            Console.WriteLine($"{Ad} miyavlıyor!");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.Ad = "Karabaş";
            kopek.SesCikar(); // Hayvan bir ses çıkarıyor...
            kopek.Havla();    // Karabaş havlıyor!

            Kedi kedi = new Kedi();
            kedi.Ad = "Tekir";
            kedi.SesCikar(); // Hayvan bir ses çıkarıyor...
            kedi.Miyavla();  // Tekir miyavlıyor!
        }
    }


    //Override ile Metodları Geçersiz Kılmak
    Türetilmiş sınıf, ana sınıftaki bir metodu override ederek (geçersiz kılarak) kendi davranışını tanımlayabilir.
    SesCikar metodu Hayvan sınıfında virtual olarak işaretlenmiştir. Bu, türetilmiş sınıfların bu metodu override edebileceği anlamına gelir.
    Kopek ve Kedi sınıfları, SesCikar metodunu kendi ihtiyaçlarına göre yeniden tanımlamıştır.

    class Hayvan
    {
        public string Ad { get; set; }

        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan bir ses çıkarıyor...");
            Console.ReadLine();
        }
    }

    class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} havlıyor!");
            Console.ReadLine();
        }
    }

    class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} miyavlıyor!");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.Ad = "Hayvan";
            hayvan.SesCikar(); // Hayvan bir ses çıkarıyor...

            Kopek kopek = new Kopek();
            kopek.Ad = "Karabaş";
            kopek.SesCikar(); // Karabaş havlıyor!

            Kedi kedi = new Kedi();
            kedi.Ad = "Tekir";
            kedi.SesCikar(); // Tekir miyavlıyor!
        }
    }
    

    Örnek 3: Kalıtımın Hiyerarşisi
    Biraz daha karmaşık bir örnek:
    Diyelim ki Çalışan sınıfı var, bundan türeyen Mühendis ve Yönetici sınıflarını oluşturacağız.

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public virtual void Calis()
        {
            Console.WriteLine($"{Ad} {Soyad} çalışıyor.");
            Console.ReadLine();
        }
    }

    class Muhendis : Calisan
    {
        public string UzmanlikAlani { get; set; }

        public override void Calis()
        {
            Console.WriteLine($"{Ad} {Soyad}, {UzmanlikAlani} alanında mühendis olarak çalışıyor.");
            Console.ReadLine();
        }
    }

    class Yonetici : Calisan
    {
        public int EkipSayisi { get; set; }

        public override void Calis()
        {
            Console.WriteLine($"{Ad} {Soyad}, {EkipSayisi} kişilik bir ekibi yönetiyor.");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Muhendis muhendis = new Muhendis
            {
                Ad = "Ayşe",
                Soyad = "Yılmaz",
                UzmanlikAlani = "Yazılım"
            };
            muhendis.Calis(); // Ayşe Yılmaz, Yazılım alanında mühendis olarak çalışıyor.

            Yonetici yonetici = new Yonetici
            {
                Ad = "Ali",
                Soyad = "Demir",
                EkipSayisi = 10
            };
            yonetici.Calis(); // Ali Demir, 10 kişilik bir ekibi yönetiyor.
        }
    }

    Base Class Özellikleri ve Metotları Kullanma: Ana sınıfın (Base Class) özellik ve metotları türetilmiş sınıflar tarafından doğrudan kullanılabilir.
    Metotları Geçersiz Kılmak (Override): virtual ile tanımlanmış metotlar, türetilmiş sınıflar tarafından override edilerek özelleştirilebilir.
    sealed Anahtar Kelimesi:Türetilmiş bir sınıfta override edilen bir metodun, daha fazla türetilmiş sınıflar tarafından yeniden override edilmesi istenmiyorsa 
    sealed anahtar kelimesi kullanılabilir.

    sealed class FinalClass
    {
         // Bu sınıf başka sınıflar tarafından türetilemez.
    }

    virtual: Temel sınıftaki bir metodu türetilmiş sınıflarda geçersiz kılınabilir hale getirir.
    override: Türetilmiş sınıfta, temel sınıf metodunu geçersiz kılmak için kullanılır.
    sealed: Override edilen bir metodun daha fazla geçersiz kılınmasını engeller.
    Polimorfizm, override ile güçlü bir şekilde desteklenir. Temel sınıf referansı ile türetilmiş sınıfların davranışlarını çağırmak mümkündür.



Polimorfizm Nedir?
Polimorfizm, aynı taban sınıf (base class) referansına sahip farklı türetilmiş sınıfların, kendine özgü davranışlar sergileyebilmesini sağlar.

Compile Time Polymorphism (Derleme Zamanı Polimorfizmi): Method Overloading ve Operator Overloading ile sağlanır.
Run Time Polymorphism (Çalışma Zamanı Polimorfizmi): Method Overriding ile sağlanır.

1. Compile-Time Polymorphism
Compile-time polymorphism, statik polimorfizm olarak da adlandırılır ve derleme aşamasında çözümlenir. Bu, metotların ve operatörlerin aşırı yüklenmesi (overloading) ile gerçekleştirilir.

Özellikleri:
Metot Aşırı Yükleme (Method Overloading) ve Operatör Aşırı Yükleme (Operator Overloading) ile gerçekleştirilir.
Derleme sırasında hangi metotun çağrılacağı bellidir.
Daha hızlıdır, çünkü çalışma zamanında ek bir işlem yapılmaz.

Metot Aşırı Yükleme (Method Overloading)
Aynı sınıfta aynı isimde birden fazla metot tanımlanabilir, ancak bu metotlar farklı sayıda veya türde parametre alır. Bu, metot aşırı yüklemedir.


class Hesaplayici
{
    // İki sayı toplama
    public int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç sayı toplama
    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Farklı parametre türleriyle toplama
    public double Topla(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hesaplayici hesap = new Hesaplayici();

        Console.WriteLine(hesap.Topla(2, 3));          // 5
        Console.WriteLine(hesap.Topla(2, 3, 4));       // 9
        Console.WriteLine(hesap.Topla(2.5, 3.5));      // 6.0
    }
}


Operatör Aşırı Yükleme (Operator Overloading)
Operatörlerin (örneğin +, -, *) özel sınıflar için aşırı yüklenmesini sağlar.

class Nokta
{
    public int X { get; set; }
    public int Y { get; set; }

    public Nokta(int x, int y)
    {
        X = x;
        Y = y;
    }

    // + operatörünü aşırı yükleme
    public static Nokta operator +(Nokta n1, Nokta n2)
    {
        return new Nokta(n1.X + n2.X, n1.Y + n2.Y);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Nokta p1 = new Nokta(1, 2);
        Nokta p2 = new Nokta(3, 4);

        Nokta p3 = p1 + p2; // + operatörü aşırı yüklendi

        Console.WriteLine(p3); // (4, 6)
    }
}

2. Run-Time Polymorphism
Run-time polymorphism, dinamik polimorfizm olarak da adlandırılır ve çalışma zamanında çözümlenir.Bir temel sınıf (base class) referansı, 
türetilmiş sınıflara (derived class) işaret eder ve hangi metodun çağrılacağı çalışma zamanında belirlenir. Bu, metot geçersiz kılma (method overriding) ile gerçekleştirilir.

Özellikleri:
Metot Geçersiz Kılma (Method Overriding) ile gerçekleştirilir.
Bir base class referansı, türetilmiş sınıf nesnesine işaret ederek metot çağrısında bulunur.
Hangi metotun çağrılacağı çalışma zamanında belirlenir.
Çalışma zamanı maliyeti daha yüksektir, çünkü metot çağrısı çalışma zamanında çözülür.


Metot Geçersiz Kılma (Method Overriding)
Bir base class'taki metot, bir derived class'ta yeniden tanımlanabilir. Bu, virtual ve override anahtar kelimeleriyle yapılır.


class Hayvan
{
    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan bir ses çıkarıyor.");
    }
}

class Kopek : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Köpek havlıyor.");
    }
}

class Kedi : Hayvan
{
    public override void SesCikar()
    {
        Console.WriteLine("Kedi miyavlıyor.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan hayvan;

        hayvan = new Kopek();
        hayvan.SesCikar();  // Köpek havlıyor.

        hayvan = new Kedi();
        hayvan.SesCikar();  // Kedi miyavlıyor.
    }
}


Compile-Time vs Run-Time Polymorphism
Compile Time Polymorphism : Gerçekleşme zamanı derleme zamanında, Kullanım Yöntemleri; metot aşırı yükleme, operatör aşırı yükleme
    performans daha hızlı, esneklik daha az, anahtar kelime yok, çok biçimlilik düzeyi sabit
Run-Time Polymorphism : Gerçekleşme zamanı çalışma zamanında, Kullanım yöntemleri metot geçersiz kılma, performans daha yavaş, 
    esneklik daha fazla, anahtar kelimeler virtual, override ve new, çok biçimlilik düzeyi dinamik.

Özet
Compile-Time Polymorphism:
Derleyici, çağrılacak metodu belirler.
Metot aşırı yükleme ve operatör aşırı yükleme ile gerçekleştirilir.

Run-Time Polymorphism:
Çalışma zamanında hangi metotun çağrılacağı belirlenir.
Metot geçersiz kılma ile gerçekleştirilir.

Polymorphism'in Gücü
Kodun Yeniden Kullanılabilirliği:

Temel sınıfta yazılan kod, türetilmiş sınıflar tarafından yeniden kullanılabilir.
Dinamik Davranış:

Çalışma zamanında nesnelerin farklı davranışlar sergilemesi sağlanır.
Bakımı ve Genişletilebilirliği Kolaylaştırır:

Yeni sınıflar eklemek veya davranışları değiştirmek daha kolaydır.

Polimorfizm ve Abstract Sınıflar
Abstract sınıflar, polimorfizm için güçlü bir araçtır. Temel sınıfta abstract olarak tanımlanan bir metodun, türetilmiş sınıflarda mutlaka implementasyonu yapılmalıdır.
    İmplementasyon : ezme , overriding

    abstract class Sekil
    {
        public abstract double AlanHesapla();
    }

    class Dikdortgen : Sekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    class Daire : Sekil
    {
        public double Yaricap { get; set; }

        public override double AlanHesapla()
        {
            return Math.PI * Yaricap * Yaricap;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sekil[] sekiller = new Sekil[2];
            sekiller[0] = new Dikdortgen { Genislik = 4, Yukseklik = 5 };
            sekiller[1] = new Daire { Yaricap = 3 };

            foreach (var sekil in sekiller)
            {
                Console.WriteLine($"Alan: {sekil.AlanHesapla()}");
                Console.ReadLine();
            }
        }
    }

Polimorfizm, türetilmiş sınıfların kendi davranışlarını sergilemesini sağlar.
virtual ve override, temel sınıf metodunu geçersiz kılarak polimorfizmi mümkün kılar.
Abstract sınıflar, polimorfizmin sık kullanılan bir versiyonudur.
Temel sınıf referansı, türetilmiş sınıfın davranışını çağırabilir.
Polimorfizm, daha esnek ve genişletilebilir bir kod yapısı sağlar.



Abstract Sınıf Nedir?
Tanım:

Abstract sınıflar, kendilerinden bir nesne oluşturulamayan sınıflardır.
Soyut sınıflar genellikle diğer sınıfların türetildiği bir temel yapı sağlar.

Amaç:
Ortak özellikler ve metotları tanımlamak.
Ancak bu metotların bazılarını türetilmiş sınıfların kendi mantıklarına göre doldurmasını sağlamak.

Abstract Metotlar:

Soyut sınıflar, hem tamamlanmış (normal) metotlar hem de abstract (tamamlanmamış) metotlar içerebilir.
Abstract metotlar sadece tanımlanır, gövdesi olmaz. Türetilmiş sınıflarda bu metotların override edilmesi zorunludur.

Anahtar Kelime:
Soyut sınıflar abstract anahtar kelimesiyle tanımlanır.
Abstract metotlar da abstract anahtar kelimesiyle işaretlenir.


Abstract Sınıf Kullanımı
Soyut sınıflar, kalıtım (inheritance) ile birlikte çalışır. Soyut sınıftaki ortak özellikler ve davranışlar türetilmiş sınıflara aktarılır.

Temel Kurallar:

Abstract sınıflardan nesne oluşturulamaz:

abstract class Hayvan { }
Hayvan h = new Hayvan(); // Hata! Soyut sınıftan nesne oluşturulamaz.

Abstract metotlar sadece gövdesiz tanımlanır:

    abstract class Hayvan
    {
    public abstract void SesCikar(); // Gövdesiz metot
    }

Türetilmiş sınıflar, soyut sınıftaki abstract metotları override etmek zorundadır.

Örnek: Abstract Sınıf Kullanımı

    abstract class Hayvan
    {
        public string Ad { get; set; }

        // Soyut metot (Abstract Method)
        public abstract void SesCikar();

        // Normal bir metot (Concrete Method)
        public void Tanit()
        {
            Console.WriteLine($"Benim adım {Ad}");
            Console.ReadLine();
        }
    }

    class Kopek : Hayvan
    {
        // Abstract metodu override etmek zorundayız
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav!");
            Console.ReadLine();
        }
    }

    class Kedi : Hayvan
    {
        // Abstract metodu override etmek zorundayız
        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Hayvan sınıfından nesne oluşturulamaz
            // Hayvan hayvan = new Hayvan(); // Hata!

            // Türetilmiş sınıflar ile çalışıyoruz
            Hayvan kopek = new Kopek { Ad = "Karabaş" };
            kopek.Tanit();    // Benim adım Karabaş
            kopek.SesCikar(); // Hav hav!

            Hayvan kedi = new Kedi { Ad = "Tekir" };
            kedi.Tanit();    // Benim adım Tekir
            kedi.SesCikar(); // Miyav!
        }
    }

Hayvan sınıfı abstract olarak tanımlandı. Hem abstract (tamamlanmamış) hem de concrete (tamamlanmış) metotlar içeriyor.
Kopek ve Kedi sınıfları, Hayvan sınıfından türetildi.
SesCikar metodu, türetilmiş sınıflar tarafından özelleştirildi (override edildi).
Tanıt metodu, soyut sınıf içinde tamamlanmış olarak kaldı ve türetilmiş sınıflar tarafından doğrudan kullanılabildi.

Abstract Sınıfların Avantajları
Ortak Davranışların Tekrarını Önler:
Abstract sınıf, türetilmiş sınıflar için ortak olan özellikleri ve davranışları bir araya toplar.
Kurallar Tanımlar:
Soyut metotlar sayesinde türetilmiş sınıfların belli metotları mutlaka tanımlaması gerektiğini garanti eder.
Esneklik Sağlar:
Abstract sınıflar, hem tamamlanmış (concrete) hem de tamamlanmamış (abstract) metotlar içerebildiği için esnek bir yapı sunar.
   
  Abstract ve Virtual Karşılaştırması:
    Abstractlar abstract anahtar kelimesi ile tanımlanır. Gövdesi yoktur, sadece tanım yapılır. Türetilmiş sınıfta override edilmek zorundadır.
    Kalıtımla zorunlu davranışları belirlemek kullanım amacıdır.
    Virtual lar virtual anahtar kelimesi ile tanımlanır. Gövde tanımlanabilir(isteğe bağlı). Override edilmesi isteğe bağlıdır.
    Kullanım amacı varsayılan bir davranış sağlamaktır.

  Abstract Sınıflar ve Arayüzler (Interfaces) Arasındaki Farklar:
    Abstract Sınıf: Bir sınıf yalnızca bir abstract sınııfı miras alabilir. Hem gövdesiz (abstract) hem de gövdeli metotlara sahip olabilr.
    Alanlar (fields) tanımlanabilir. Ortak davranış ve özellikleri paylaşmak için kullanılır.
    Interface (Arayüz): Bir sınıf birden fazla arayüzü implemente edebilir. Sadece gövdesiz metotlara (C# 8.0 öncesi) sahiptir. 
    Alanlar tanımlanamaz. Yalnızca bir kontrat(arayüz) tanımlamak için kullanılır.

Abstract sınıflar, tamamlanmamış sınıflardır ve genellikle kalıtım yoluyla türetilmiş sınıflar için bir temel sağlar.
Abstract sınıflar, hem gövdesiz (abstract) hem de gövdeli (concrete) metotlar içerebilir.
Türetilmiş sınıflar, abstract metotları override etmek zorundadır.
Abstract sınıflar, kalıtımı zorunlu kılmak ve ortak bir yapı oluşturmak için mükemmel bir araçtır.
  
 

Interface Nedir?
Interface (arayüz), bir sınıfın uygulaması gereken bir sözleşme veya şablon sunar. Yani, bir interface içerisinde yalnızca imzaları (signature) tanımlanan metotlar, özellikler, olaylar ve indeksleyiciler bulunur, ama gövde (body) içermez.

Özellikleri:
Gövdesizdir:
Interface metotlarının bir uygulaması yoktur. Metotların yalnızca imzaları tanımlanır.
Bir Sözleşme Görevi Görür:
Bir sınıf bir interface'i uyguluyorsa, o interface'deki tüm metotları ve üyeleri uygulamak zorundadır.
Çoklu Kalıtım İmkanı Sağlar:
C#'da bir sınıf yalnızca bir abstract veya başka bir sınıfı miras alabilirken, birden fazla interface'i implemente edebilir.
Sınıflarla veya Abstract Sınıflarla Kombine Edilebilir:
Interface'ler sınıflar veya abstract sınıflarla birlikte kullanılabilir.
  
Interface Tanımlama ve Kullanımı
Interface Tanımı
Interface tanımlamak için interface anahtar kelimesi kullanılır.

interface IOrnek
{
    void Metot1();  // Metot imzası (gövdesiz)
    int Metot2(int param);  // Parametre alan bir metot imzası
}

Interface Uygulaması
Bir sınıf, bir interface'i implemente etmek (uygulamak) için : IOrnek ifadesini kullanır.

class Sinif : IOrnek
{
    public void Metot1()
    {
        Console.WriteLine("Metot1 uygulandı.");
    }

    public int Metot2(int param)
    {
        return param * 2;
    }
}

Interface Kullanımı - Örnek
  
    interface IHayvan
    {
        void SesCikar(); // Gövdesiz metot
        string HareketEt(); // Metot imzası
    }

    class Kopek : IHayvan
    {
        public void SesCikar()
        {
            Console.WriteLine("Hav hav!");
            Console.ReadLine();
        }

        public string HareketEt()
        {
            return "Köpek koşuyor.";
        }
    }

    class Kedi : IHayvan
    {
        public void SesCikar()
        {
            Console.WriteLine("Miyav miyav!");
            Console.ReadLine();
        }

        public string HareketEt()
        {
            return "Kedi tırmanıyor.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IHayvan kopek = new Kopek();
            kopek.SesCikar();  // Hav hav!
            Console.WriteLine(kopek.HareketEt());  // Köpek koşuyor.
            Console.Read();

            IHayvan kedi = new Kedi();
            kedi.SesCikar();  // Miyav miyav!
            Console.WriteLine(kedi.HareketEt());  // Kedi tırmanıyor.
            Console.ReadLine();
        }
    }

Birden Fazla Interface'in Uygulanması
Bir sınıf birden fazla interface'i implemente edebilir.

    interface IYurut
    {
        void Yuru();
    }

    interface IKos
    {
        void Kos();
    }

    class Insan : IYurut, IKos
    {
        public void Yuru()
        {
            Console.WriteLine("İnsan yürüyor.");
            Console.ReadLine();
        }

        public void Kos()
        {
            Console.WriteLine("İnsan koşuyor.");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            insan.Yuru();  // İnsan yürüyor.
            insan.Kos();   // İnsan koşuyor.
        }
    }

    Interface ile Abstract Sınıfların Karşılaştırılması
    Interface: Tüm metodlar gövdesizdir (C# 8.0 öncesi) Bir sınıf birden fazla interface i implemente edebilir. 
    Alan (field) tanımlanamaz. Interface içindeki tüm metodlar implemente edilmelidit.
    Abstract Sınıf: Hem gövdesiz hem de gövdeli metodlara sahip olabilir. Bir sınıf yalnızca bir abstract sınıfı miras alabilr.
    Alanlar tanımlanabilir. Abstract metodlar implemente edilmek (override) zorundadır.

 Interface ile Polimorfizm
 Interface'ler polimorfizm için çok kullanışlıdır. Interface türündeki bir referans, o interface'i implemente eden herhangi bir sınıfın
  nesnesini işaret edebilir.

    interface IArac
    {
        void HareketEt();
    }

    class Araba : IArac
    {
        public void HareketEt()
        {
            Console.WriteLine("Araba hareket ediyor.");
            Console.ReadLine();
        }
    }

    class Bisiklet : IArac
    {
        public void HareketEt()
        {
            Console.WriteLine("Bisiklet pedal çeviriyor.");
            Console.ReadLine(); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IArac[] araclar = new IArac[2];
            araclar[0] = new Araba();
            araclar[1] = new Bisiklet();

            foreach (var arac in araclar)
            {
                arac.HareketEt();
            }
        }
    }


Interface'lerin Avantajları

Çoklu Kalıtım: Bir sınıf birden fazla interface'i implemente edebilir.

Polimorfizm: Interface'ler, türetilmiş sınıfların farklı şekillerde davranmasına olanak tanır.

Bağımsızlık: Interface kullanarak kod daha modüler ve esnek hale gelir. Sınıflar bir interface'e göre tasarlandığında, o interface'i implemente eden farklı sınıflar değiştirilebilir.

Kodun Yeniden Kullanılabilirliği: Aynı interface'i implemente eden farklı sınıflar arasında ortak davranışları paylaşabilirsiniz.


Interface'ler, bir sınıfın uygulamak zorunda olduğu bir sözleşme sunar.
Sadece imzalar içerir; gövde içermez (C# 8.0 öncesi).
Bir sınıf birden fazla interface'i implemente edebilir.
Interface'ler polimorfizm ve çoklu kalıtım için güçlü bir araçtır.
C# 8.0 ile interface'lere varsayılan metotlar eklenebilir.
}

*/
}

