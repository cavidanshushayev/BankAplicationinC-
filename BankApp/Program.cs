using System.ComponentModel.Design;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username = "admin";
            String password = "admin";
            breakpoint:
            Console.WriteLine("zehmet olmasa istifadechi adinizi daxil edin:");
            String user_name = Console.ReadLine();
            Console.WriteLine("password");
            String user_password = Console.ReadLine(); 
            if(username !=user_name || password != user_password)
            {
                Console.WriteLine("zehmet olmasa kodu yeniden daxil edin");
                goto breakpoint;
            }else if(user_name != username && user_password != password)
            {
                Console.WriteLine("zehmet olmasa kodu yeniden daxil edin");
                goto breakpoint;
            }else
            {
                Console.WriteLine("xosh geldiniz zehmet olmasa etmek istediyiniz emeliyyati secin:");
            
               
                
                int mebleg=0;
                int ay=0;
                int ayliq_odenis=0;
                int odenilecek_mebleg=0;
            breakpoint2:
                Console.WriteLine("1-kredit goturmek,2-kredit odemek ,3 hesabat");
                int emeliyyat = Convert.ToInt32(Console.ReadLine());
                switch (emeliyyat)
                {
                    case 1:
                        Console.WriteLine("ne qeder kredit goturmek isteyirsiniz?");
                        mebleg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("nece ayliq kredit goturmek isteyirsiniz?");
                        ay = Convert.ToInt32(Console.ReadLine());
                        if (ay <= 12) { 
                        odenilecek_mebleg = mebleg + (mebleg * 12 / 100); }
                        else
                        {
                            odenilecek_mebleg = mebleg + (mebleg * 18 / 100);
                        }
                        Console.WriteLine("odenlicek mebleg=" + odenilecek_mebleg);
                        ayliq_odenis = odenilecek_mebleg / ay;
                        Console.WriteLine("ayliq odenish=" + ayliq_odenis);
                        Console.WriteLine("davam etmek isteyirsinizmi? 1.beli ,2 xeyr");
                        int emeli = Convert.ToInt32(Console.ReadLine());
                        if (emeli == 1)
                        {
                            Console.WriteLine("xeyirli olsun ,kreditiniz tesdiqlendi.Banka odenilecek umumi mebleg" + odenilecek_mebleg);
                            goto breakpoint2;
                        }else if(emeli == 2)
                        {
                            Console.WriteLine("teesuf ki kredit gotrulmedi" );
                            goto breakpoint2;
                        }else
                        {
                            Console.WriteLine("teesuf ki bele emeliyyat movcud deyil");
                            goto breakpoint2;
                        }

                        break;

                    case 2:
                        Console.WriteLine("odenilecek mebleg"+ayliq_odenis +"azn dir . odemek isteyirsinizmi? 1.beli ,2 xeyr");

                        int emel = Convert.ToInt32(Console.ReadLine());
                        if (emel == 1)
                        {   
                            Console.WriteLine("xeyirli olsun ,kreditinizi odedeniz");
                            odenilecek_mebleg = odenilecek_mebleg - ayliq_odenis;
                            Console.WriteLine("qaliq kredit=" + odenilecek_mebleg + "azndir");
                        }
                        else if (emel == 2)
                        {
                            Console.WriteLine("teesuf ki kredit odenmedi");
                            goto breakpoint2;
                        }
                        else
                        {
                            Console.WriteLine("teesuf ki bele emeliyyat movcud deyil");
                        }
                        goto breakpoint2;

                        break;

                    case 3:
                        Console.WriteLine("qaliq mebleg=" + odenilecek_mebleg);
                        goto breakpoint2;
                        break;

                }

            }


        }
    }
}