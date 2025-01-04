using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{/*
    

   Constructorların (yapıcı metod) ana amacı objeji başlatmak(initialization), obje oluşturur, objeyi başlatır, başlangıç işlemlerini 
   otomatikleştirir, gerekirse doğrulama yapar. 

   Neden constructor ? 
    1_Kodun daha temiz ve güvenli olması : attribute ları manuel atamak yerine constructor ile topluca yapabiliriz.
    2_Başlangıç işlemlerini otomatikleştirme: obje oluştururken belirli işlemler yapılması gerekıyorsa (örneğin bir ID üretmek), bunu constructor ile tanımlayabiliriz.
    3_Veri Doğrulama: Constructor içinde parametrelerin doğru olup olmadığını kontrol edebiliriz.

  // CONSTRUCTOR OLMADAN 
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Alice";
            p1.Age = 25;
            Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name;
        public int Age;
    }
    

    //CONSTRUCTOR KULLANARAK
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alice", 25);
            Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age) //constructor
        {
            Name = name;
            Age = age;
        }
    }

    Constructor tür olarak bir metod ancak 
    Constructor; sınıf adıyla aynı olmalıdır, dönüş değeri hiçbir zaman olmaz( void bile), obje oluşturulurken otomatik çağırılır
    amacı obje başlatma işlemlerini yapmak.
    Normal Metod; istediğimiz bir isiim verilebilir, herhangi bir değer dönebilir, kullanıcı tarafından manuel olarak çağrılır
    amacı obje üzerinde işlem yapmak.

    Constructor Doğrudan Çağrılır Mı?
    Hayır, bir constructor yalnızca bir obje oluşturulurken çalışır ve sınıfın adı kullanılarak tetiklenir. 
    new anahtar kelimesi kullanılarak bir obje oluşturduğunuzda, constructor otomatik olarak devreye girer.

    Constructor Özellikleri 
    Default (Varsayılan) Constructor : Eğer bir sınıfta constructor tanımlamazsanız derleyici sizin için parametresiz bir constructor sağlar. Ama parametreli tanımladıysak çağırırken değeri vermek gerekir.
    Overloading (Aşırı Yükleme): C# constructorlar aşırı yüklemeyi destekler; yani farklı parametre listeleriyle birden fazla constructor tanımlayabilirsiniz.
    Static Constructor: Eğer bir sınıfın statik üyeleri varsa( static variables/ properties), bu üyeleri başlatmak için bir static constructor tanımlayabilirsiniz.
     Static Constructor, sınıf ilk kez kullanıldığında otomatik olarak çağırılır (örneğin bir statik üyeye erişildiğinde veya ilk nesne oluşturulduğunda). Constructordan önce çalışır.
     Yalnızca bir kere çalışır; her nesne oluşturulduğunda yeniden çağrılmaz. Manuel olarak çağırmayız. Static veya olmayan bir sınıfta bulunabilir. Parametre alamaz.


    Properties ( Encapsulation*)
    C#da properties (özellikler),  bir sınıfın özel verilerini kontrol etmek için kullanılan özel üyelerdir. Özellikler, genellikle bir sınıf private (özel) alanlarına erişimi yönetir ve bu verilere
    dışarıdan erişimi kontrol etmek için kullanılan get ve set erişimcilerini içerir.

    Properties iki ana bölümden oluşur:
    get : Özelliğin değerini döndürür.
    set : Özelliğe yeni bir değer atar.
                                                                                            
    Örnek:

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Alice";
            p1.Age = 25;

            Console.WriteLine(p1.Name +"  "+ p1.Age);
            Console.ReadLine();
        }
    }
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    
    Auto-Implemented Properties (Otomatik Uygulamalı Özellikler)
    Eğer getter ve setter fonksiyonları sadece basit bir şekilde veriye erişim sağlıyorsa. C# auto-implemented properties olarak bilinen bir özellik sağlar. Bu özellik, sınıfın özellikleri için get/set metodlarını 
    kendiliğinden tanımlar ve her bir özelliğin arka planda saklanması için gizli bir alan oluşturur.
    Örnek:

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Bob";
            p1.Age = 30;

            Console.WriteLine($"Name : {p1.Name}, Age: {p1.Age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    Read-Only ve Write-Only Özellikler
    C# da sadece get metodu tanımlanmış olan özellikler read-only olur, yani yalnızca okunabilirler. Eğer sadece set metodu tanımlanmışsa, o özellik sadece yazılabilir olur, ancak okunamaz. Bu özellikler veri güvenliiği için kullanılır.
    
    //Örnek Read-Only:
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alice");
            Console.WriteLine($"Name{p1.Name}");
            Console.ReadLine();
        }
    }
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public Person (string name)
        {
            this.name = name;
        }
    }
    
    //Örnek Write-Only:

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Bob";
            p1.ShowName();
        }
    }
    class Person
    {
        private string name;
        public string Name
        {
            set { name = value; }
        }
        public void ShowName() // Direkt console writeline da yazdıramazdık ancak fonksşyon yazıp atayınca çıktı alabildik.
        {
            Console.WriteLine($"Name: {name}");
            Console.ReadLine();
        }
  

    Property ile Veri Doğrulama
    Veri doğrulama yapmak için set metodunda kontrol yapabiliriz. Örneğin yaşın negatif olmasını engellemek gibi:
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Emily";
            try
            {
                p1.Age = -5;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Name: {p1.Name}, Age:{p1.Age}");
            Console.ReadLine();

        }
    }
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");
                age = value;
            }
        }
    }


    Destructor ve Garbage Collector
    Destructor, C# da nesneler yok edilmeden önce kaynakları serbest bırakmak için kullanılan özel bir metodtur. C# da destructor, finalizer olarak da bilinir ve garbage collector tarafından otomatik olarak çağrılır. 
    Destructor, nesne ömrü sona erdiğinde kaynakları temizlemek için kullanılır. Ancak, destructor lar manuel olarak çağrılamaz.
    Yıkıcı(Destructor) ile İlgili Önemli Noktalar
    Destructorlar, nesneler garbage collector tarafından toplanmadan önce çalışırtırılır. Dönüş tipi ve parametresi yoktur.
    Yıkıcılar ~ClassName şeklinde yazılır ve parametre almaz. 
    C#da destructor kullanımı genellikle ihtiyaç duyulmaz çünkü garbage collector nesneleri otomatik olarak temizler. Ancak unmanaged kaynaklala (örneğin dosya işlemleri, veritabanı bağlantıları) çalışıyorsanız
    destructor kullanmka faydalı olabilir.

    Garbage Collector (GC)
    Garbage Collector, belirli bir nesnenin referans sayısı sıfır olduğunda, yani nesneye artık ihtiyaç duyulmadığında bu nesneyi otomatik olarak bellekten temizler. Bu işlem,C# ın yönetilen bellek sisteminin bir 
    parçasıdırç GC, Dispose veya Finalize metodu gibi manuel bellek yönetimine ihtiyaç duymaz.

    Destructor ve GC İlişkisi
    Destructor, garbage collector nesneye olan tüm referansları sıfırladığında çağrılır.
    Dispose metodları ise, nesneler hala kullanılabilirken, kaynakları temizlemek için kullanılır.

    
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass nesnesi oluşturuluyor
            MyClass obj = new MyClass();
            obj = null; //nesneye hiçbir referans kalması, garbage collector nesneyi toplayacak
            
            GC.Collect(); //Garbage Collector ı manuel olarak çalıştırmak
            //Program sonlanınca garbage collector finalizer metodunu çağıracak
            Console.WriteLine("Program sonlandı.");
            Console.ReadLine();

        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor çalıştı");
            Console.ReadLine() ;
        }

        ~MyClass() //Destructor (finalizer)
        {
            Console.WriteLine("Destructor çalıştı");
            Console.ReadLine() ;
        }

    }

    Constructor nesne oluşturulduğunda çalışır. Destructor nesneye olan tüm referanslar sıfırlandığında ve garbage collector tarafından toplanmaya başlanırken çalışır. GC.Collect() komutu, garbage collector ı manuel olarak etkiler.
    Destructor nesne bellekten temizlenmeden önce son temizlik işlemlerini yapar.

    Destructor: Nesne garbage collector tarafından temizlenmeden önce, belirli bir temizlik işlemi yapmak için kullanılır. Ancak, manuel olarak çağrılamaz ve genellikle unmanaged kaynaklar için gereklidir.
    Garbage Collector: Nesneleri otomatik olarak bellekten siler. Yönetilen bellek yönetimi sağlar.
    Dispose: Unmanaged kaynaklar ile çalışırken, kaynakları mauel olarak serbest bırakmak için kullanılır. using bloğu ile birlikte kullanıldığında, kaynaklar otomatik olarak temizlenir.


    this Keyword
    Genellikle bir sınıfın üye üyelerine (özellikler, metodlar) erişmek için kullanılır. this, mevcut nesneye (vurrent object) referans verir. Bu, özellikle sınıfın üye isimleri ile parametre isimleri çakıştığında kullanışlıdır,

    Kullanım Alanları
    1_Nesnenin üye değişkenlerine erişim: Nesnenin özellikleri veya metodları ile çalışma yaparken, bu nesneyi belirtmek için kullanılır.
    2_Constructor da parametre ve üye isimleri arasındaki çakışmayı çözmek: Eğer constructor parametreleri ve üye değişkenlerinin isimleri aynıysa, this anahtar kelimesi bu çakışmayı çözmek için kullanılır. 
    3_Method chaining: Bir metodun sonucunda, aynı sınıfın başka bir metodunu zincirleme olarak çağırmaya imkan tanır.

    Örnek1:
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ahmet", 25);
            person.DisplayInfo();
        }
    }
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name; //this ile nesnenin Name özelliğine erişiyoruz
            this.Age = age; // this ile öznenin Age özelliğine erişiyoruz
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
            Console.ReadLine();
        }

    }
   // this burada, constructordaki parametrelerle sınıfın üye değişkenlerini ayırt etmek için kullanılıyor. this.Name ve this.Age ifadeleri nesnenin özelliklerine erişmek için kullanılıyor.

    Örnek2:
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop", 1500.99);
            product.ShowProductInfo();
        }
    }
    class Product
    {
        public string Name;
        public double Price;

        public Product(string Name, double Price)
        {
            this.Name = Name; //this ile parametreyi nesne özelliğine atıyoruz
            this.Price = Price; // thia iale parametreyi nesne özelliğine atıyoruz
        }

        //Method
        public void ShowProductInfo()
        {
            Console.WriteLine($"Product: {this.Name}, Price: {this.Price}");
            Console.ReadLine();
        }

    }
     //Bu örnekte product sınıfındaki constructor da parametre adları ile  sınıfın üye değişkenlerinin adları aynıdır. Bu durumda, this keyword u ile sınıfın üye değişkenlerine parametreleri atıyoruz.

    Örnek3:

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota").SetModel("Corolla");
            myCar.ShowCarInfo();
        }
    }
    class Car
    {
        public string Brand;
        public string Model;

        public Car(string brand)
        {
            this.Brand= brand;
        }

        public Car SetModel(string model) //Metod zincirleme
        {
            this.Model = model;
            return this; //this aynı  nesneyi geri döndürüyor
        }

        //Method
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car: {this.Brand} {this.Model}");
            Console.ReadLine();
        }

    }
    Bir metodun sonucunda, aynı sınıfın başka bir metodunu çağırmak için this kullanılabillir. Bu örnekte SetModel metodu, nesnenin model bilgisini atar ve this keyword ü sayesinde aynı nesneyi geri döndürür.
    Bu sayede, metodu zincirleme olarak çağırabiliriz: new Car("Toyota").SetModel("Corolla").

    Özetle:
    this keyword ü, bir nesnenin kendi özelliklerine ve metodlarına erişmek için kullanılır.
    Constructor veya metodlarda parametreler ile üye değişkenlerinin isimleri çakıştığında this kullanılır.
    this, Aynı sınıf içinde metod zincirlemesi yapabilmek için de kullanılabilirç
    this nesneye ait üyeleri belirtmek ve kodun daha anlaşılır olmasını sağlamak için güçlü bir araçtır.Sınıfın statik üyeleri için this kullanılamaz yalnızca nesne tabanlı(instance) üyeler için geçerlidir. 
    Constructorda this kullanımı daha çok üye değişkenleri ile parametre isimleri çakıştığında gereklidir.

    Access Modifiers (Erişim Belirleyiciler)
    Erişim belirleyiciler, bir sınıfın, metodun, değişkenin veya diğer üyelerin nerelerden erişilebilir olduğunu kontrol eder. Bunlar,kodunuzu düzenli tutar ve veri güvenliğini sağlar.
    Türleri:

    1.public: 
    Her yerden erişilebilir.
    Sınıfın, metodun ya da değişkenin herhangi bir sınıf veya proje içerisinden kullanılmasına izin verir.

    public class MyClass
    {
       public int Number= 10;
    }


    2.private:
    Sadece tanımlandığı sınıf içinde erişilebilir.
    En kısıtlayıcı erişim düzeyidir.

    public class MyClass
    {
        private int number = 10;
        public void ShowNumber()
        {
        Console.WriteLine(number); //Buradan erişilebilir.
        }
    }


    3.protected:
    Sadece kendi sınfında ve türetilmiş(kalıtım alan) sınıflar içinde erişilebilir.

    public class ParentClass
    {
        protected int number= 10;
    }

    public class ChildClass : ParentClass
    {
        public void ShowNumber()
        {
            Console.WriteLine(number); //Erişim mümkün
        }
    }


    4.internal:
    Aynı projede (assembly) yer alan tüm sınıflar erişebilir.
    Proje dışından erişim yoktur.

    internal class MyClass
    {
        internal int Number = 10;
    }


    5.protected internal:
    Hem türetilmiş sınıflarda(protected) hem de aynı projede (internal) erişime izin verir.

    public class MyClass
    {
        protected internal int Number = 10;
    }


    6.private protected: 
    Sadece aynı sınıfta veya aynı projedeki türetilmiş sınıflarda kullanılabilir.

    public class MyClass
    {
        private protected int Number = 10;
    }


    Encapsulation (Kapsülleme)
    Encapsulation, veriyi gizleme ve kontrollü bir şekilde erişim sağlama ilkesidir. Bunun için genellikle private değişkenler ve public getter/setter veya properties kullanılır.
    Neden Önemlidir?
    Veri Güvenliği: Değişkenler sadece kontrollü bir şekilde erişilir.
    Esneklik: Gerektiğinde sınıfın iç yapısı değiiştirilebilir, dış kod etkilenmez.
    Kod Düzeni: Kodun okunabilirliğini ve bakımını kolaylaştırır.

    Encapsulation Nasıl Sağlanır? 
    1. Access Modifiers Kullanımı:
    Değişkenleri genelde private tanımlayın.
    Dış dünyaya erişimi kontrol etmek için getter ve setter metodları (veya properties) kullanın.
    2. Properties ile Kullanım:
    Veri okuma/yazma işlemlerini kontrol eden özel bir yapı sağlar.


    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //Setter lar ile değer atanır
            person.Name = " Ahmet";
            person.Age = 25;

            //Getter lar ile değer okunur
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.ReadLine();

            //Hatalı değer denemesi
            person.Age = -5;
            person.DisPlayInfo();
        }
    }
    class Person
    {
        private string name; //Dışarıdan doğrudan erişilemez
        private int age;

        //Getter ile setter ile kontrolllü erişim sağlanır.
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
                    Console.ReadLine();

            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age must be postiive");
                    Console.ReadLine();
            }
        }

        public void DisPlayInfo()
        {
            Console.WriteLine($"Name: {name}, Age:{age}");
            Console.ReadLine();
        }

    }
*/
}
