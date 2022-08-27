internal class Program
{
    private static void Main(string[] args)
    {
        int month =DateTime.Now.Month;

        //Expression --> kontrol etmek istediğimiz koşulu yazıyoruz.
        switch (month)
        {
            case 1:
                Console.WriteLine("Ocak ayındasınız");
                break;
            case 2:
                Console.WriteLine("Şubat ayındasınız");
                break;
            case 4:
                Console.WriteLine("Nisan ayındasınız"); //Sırayla gitmek zorunda değiliz.
                break;
            case 8:
                Console.WriteLine("Ağustos ayındasınız");
                break;
            
            default:
                Console.WriteLine("Yanlış ver girişi");   // Şuan Datetime küpühanesinden çektiğimiz iin yanlış olmaz ancak kendimiz
            break;                                        //  hazırlar ve kullanıcı yanlış bi cevap verirse böyle yapılabilir.
            
                                                   
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış ayındasınız");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar ayındasınız");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz ayındasınız");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar ayındasınız");
                break;    

            default:  // Default ifadesinin mutlaka olması gerekir.Ancak en sonda olması gerekmemektedir. 
            break;    // Berak çıkış yapması içindir.
        }
    }
}