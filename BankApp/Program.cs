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


                breakpoint3:
                int mebleg=0;
                int ay=0;
                int ayliq_odenis=0;
                int odenilecek_mebleg=0;
            breakpoint2:
                Console.WriteLine("1-kredit goturmek,2-kredit odemek ,3 hesabat,4 cixhis");
                int emeliyyat = Convert.ToInt32(Console.ReadLine());
                switch (emeliyyat)
                {
                    case 1:
                        if (odenilecek_mebleg == 0)
                        {
                            Console.WriteLine("ne qeder kredit goturmek isteyirsiniz?");
                            mebleg = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("nece ayliq kredit goturmek isteyirsiniz?");
                            ay = Convert.ToInt32(Console.ReadLine());
                            if (ay <= 12)
                            {
                                odenilecek_mebleg = mebleg + (mebleg * 12 / 100);
                            }
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
                            }
                            else if (emeli == 2)
                            {
                                Console.WriteLine("teesuf ki kredit gotrulmedi");
                                goto breakpoint3;
                            }
                            else
                            {
                                Console.WriteLine("teesuf ki bele emeliyyat movcud deyil");
                                goto breakpoint2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("tessuf ki sizin banka borcunuz var,yeni kredit goturmek ucun hazirki krediti odeyin");
                            Console.WriteLine("basqa emeliyyatdan istifade etmek isteyirsinizmi? 1.beli ,2.xeyre");
                            int emell = Convert.ToInt32(Console.ReadLine());
                            if (emell == 1)
                            {
                                goto breakpoint2;
                            }
                            else
                            {
                                break;
                            }
                        }

                        break;

                    case 2:
                    breakpoint4:
                        Console.WriteLine("ayliq odenish "+ayliq_odenis +"azn dir . neche ayi odemek isteyirsiniz?  ");
                        int aysay = Convert.ToInt32(Console.ReadLine());

                        if (aysay <= ay)
                        {    
                            Console.WriteLine(aysay + " -ayliq odenish " + aysay * ayliq_odenis + "azndir");
                            Console.WriteLine("odemek isteyirsinizmi? 1.beli ,2 xeyr");
                            int emel = Convert.ToInt32(Console.ReadLine());
                            if (emel == 1)
                            {
                                Console.WriteLine("xeyirli olsun ,kreditinizi odedeniz");
                                odenilecek_mebleg = odenilecek_mebleg - (ayliq_odenis * aysay);
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
                        }else
                        {
                            Console.WriteLine("zehmet olmasa odemek istediyiniz ayi duzgun daxil edin!");
                            goto breakpoint4;
                        }
                        break;

                    case 3:
                        Console.WriteLine("qaliq mebleg=" + odenilecek_mebleg);
                        goto breakpoint2;
                        break;
                    case 4:
                        Console.WriteLine("eminsinizmi cixmaq isteyirsinizmi?");
                        break;
                    default :
                        Console.WriteLine("zehmet olmasa emeliyyati duzgun daxil edin");
                        goto breakpoint2;
                        break;



                }

            }


        }
    }
}