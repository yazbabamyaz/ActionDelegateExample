internal class Program
{
    private static void Main(string[] args)
    {
        
        Ornek1();

        //LAMBDA İFADELERİNİ KULLANMADAN ACTİON KULLANIMI:
        Ornek2();

        Ornek3();

        //İsimsiz -Anonymous Method- Metot atama örneği.
        Ornek4();

        Console.ReadLine();
    }

    private static void Ornek4()
    {
        Action<string> show = delegate (string name)
        {
            Console.WriteLine(name);
        };

        show("Mustafa");
    }

    private static void Ornek3()
    {
        List<string> student = new List<string>
        {
            "Ali","Veli","Ayşe"
        };

        student.ForEach(givePrefix);//Student içindeki her öğede givePrefix çalıştır.
        
    }

    private static void givePrefix(string person)
    {
        Console.WriteLine("Mr: {0}",person);
    }

    private static void Ornek2()
    {
        Action<string> test = topla;//Delegate olduğu için Parametre olarak method verebiliriz.
        test("Value1");
    }

    private static void Ornek1()
    {
        //parametre almayan Action Delegate.//parametre olmadığı için :() yazdık.
        Action message = () =>
        {
            Console.WriteLine("Test Test...");

        };
        message();

        //tek parametre alan Action Delegate.Lambda kullanımı.
        Action<string> errorMessage = param => Console.WriteLine("Message:{0}", param);
        errorMessage("Test test test...");


        Action<string, string> errorMessage2 = (param1, param2) => Console.WriteLine("Message:{0} , Type:{1} ", param1, param2);
        errorMessage2("Test test test...", "Test2,test2");
    }

    public static void topla(string param1)
    {
        Console.WriteLine("Gelen değer:{0}",param1);
    }
}