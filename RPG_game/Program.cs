using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RPG_game
{
    internal class RPG_game
    {
        static void Main(string[] args)
        {
            string trieda1 = "obyvatel";
            string trieda2 = "billa_pracovnik";
            string trieda3 = "lidl_pracovnik";
            string trieda4 = "zivnostnik";
            string idem = "idem";
            string nejdem = "nejdem";
            string nic = "nic";
            string hadat_sa = "hadat_sa";
            string[] triedy = { trieda1, trieda2, trieda3, trieda4 };
            string necham_ho = "necham_ho";
            string chytim_ho = "chytim_ho";
            int peniaze = 100;
            Console.WriteLine($"vyber si povolanie > {trieda1}, {trieda2}, {trieda3}, {trieda4} <");
            string povolanie = Console.ReadLine();
            while (povolanie != trieda1 && povolanie != trieda2 && povolanie != trieda3 && povolanie != trieda4)
            {
                Console.WriteLine("nauc sa pisat");
                povolanie = Console.ReadLine();
            }
            if (povolanie == trieda1)
            {
                Console.WriteLine($"vybral si si {trieda1}, stlac lubovolnu klavesu na pokracovanie");
                Console.ReadKey();
                Console.WriteLine("Ides vecernym hlohovcom, stretnes nejakeho fetaka na ulici, co urobis?, pojdes za nim alebo nie?");
                Console.WriteLine("(napis <idem> alebo <nejdem>)");
                string vyber0 = Console.ReadLine();
                while (vyber0 != idem && vyber0 != nejdem && vyber0 != nic && vyber0 != hadat_sa && vyber0 != necham_ho && vyber0 != chytim_ho)
                {
                    Console.WriteLine("nevies pisat, skus znova");
                    vyber0 = Console.ReadLine();
                }
                if (vyber0 == idem)
                {
                    Console.WriteLine("vybral si si ze ides za nim");
                    Console.WriteLine("zbil ta, zostal si v nemocnici");
                    Console.WriteLine("stlac hocico pre exit");
                    Console.ReadKey();
                }
                else if (vyber0 == nejdem)
                {
                    Console.WriteLine("isiel si okolo, daco na teba zahucal ale si bez zraneni");
                    Console.WriteLine("stlac hocico pre pokracovanie");
                    Console.ReadKey();
                    Console.WriteLine($"pokracujes v ceste domov, si v pohode, mas {peniaze}$ si ale hladny, chces pizzu?");
                    Console.WriteLine("(napis <ano> alebo <nie>)");
                    if (Console.ReadLine() == "ano")
                    {
                        Console.WriteLine("kupil si si pizzu, ale ostalo ti len 20$");
                        peniaze = peniaze - 80;
                        Console.WriteLine($"mas {peniaze}$");
                        Console.WriteLine("stlac hocico na exit");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("si hladny, ale mas este peniaze, takze si v pohode");
                        Console.WriteLine("stlac hocico na exit");
                        Console.ReadKey();
                    }
                }
            }

                if (povolanie == trieda2)
                {
                    Console.WriteLine($"vybral si si {trieda2}, stlac lubovolnu klavesu na pokracovanie");
                    Console.ReadKey();
                    Console.WriteLine($"si v bille, si za kasou a krici nateba zakaznik, ze kupon mu nejde, aj ked si mu povedal ze neni platny, co urobis? tip> mas {peniaze}$");
                    Console.WriteLine("napis <nic>(uplatnis zlavu ajtak)<hadat_sa>");
                    string vyber2 = Console.ReadLine();
                    while (vyber2 != idem && vyber2 != nejdem && vyber2 != nic && vyber2 != hadat_sa && vyber2 != necham_ho && vyber2 != chytim_ho)
                    {
                        Console.WriteLine("nevies pisat, skus znova");
                        vyber2 = Console.ReadLine();
                    }
                    if (vyber2 == nic)
                    {
                        Console.WriteLine("urobil si asi dobre pre svoje dusevne zdravie, zakaznik odisiel, pokracujes v praci");
                        Console.WriteLine("stlac hocico pre exit");
                        Console.ReadKey();
                    }
                    else if (vyber2 == hadat_sa)
                    {
                        peniaze = peniaze + 70;
                        Console.WriteLine($"Hadal si sa 5 minut, no vyhral si, sef ti dal odmenu 70$ za dobru pracu, mas {peniaze}$");
                        Console.WriteLine("stlac hocico pre exit");
                        Console.ReadKey();
                    }

                }
                if (povolanie == trieda3)
                {
                    Console.WriteLine($"vybral si si {trieda3}, stlac lubovolnu klavesu na pokracovanie");
                    Console.ReadKey();
                    Console.WriteLine($"Si v LIDL, prave sa dopieklo cerstve a chrumkave pecivo, praimo z pece, ale vidis niekoho kradnut pizza tasticku, co urobis? tip> mas {peniaze}$");
                    Console.WriteLine("napis <necham_ho> (nechas ho utiect) alebo <chytim_ho>");
                    string vyber3 = Console.ReadLine();
                    while (vyber3 != idem && vyber3 != nejdem && vyber3 != nic && vyber3 != hadat_sa && vyber3 != necham_ho && vyber3 != chytim_ho)
                    {
                        Console.WriteLine("nevies pisat, skus znova");
                        vyber3 = Console.ReadLine();
                    }
                    if (vyber3 == necham_ho)
                    {
                        peniaze = 0;
                        Console.WriteLine($"nechal si ho utiect, ale bohuzial ta videla sefova lidlu, dostal si padaka, si bezdomovec, umrel si na hlad, nemal si ani {peniaze} na pohreb");
                        Console.WriteLine("stlac hocico na exit");
                        Console.ReadKey();
                    }
                    else if (vyber3 == chytim_ho)
                    {
                        Console.WriteLine("prichitil si to decko, zavolal si policiu slovenskej republiky, navyse ti sefova zvisila vyplatu, a to sa oplati");
                        Console.WriteLine("stlac hocico na exit");
                        Console.ReadKey();
                    }

                }
                if (povolanie == trieda4)
                {
                    Console.WriteLine($"vybral si si {trieda4}, stlac lubovolnu klavesu na pokracovanie");
                    Console.ReadKey();
                    Console.WriteLine("si zivnostnik, dosiel ti danovy list, co urobis?");
                    Console.WriteLine("napis <zaplatis> <zahodis>");
                    string vyber4 = Console.ReadLine();
                    while (vyber4 != idem && vyber4 != nejdem && vyber4 != nic && vyber4 != hadat_sa && vyber4 != necham_ho && vyber4 != chytim_ho && vyber4 != "zaplatis" && vyber4 != "zahodis")
                    {
                        Console.WriteLine("nevies pisat, skus znova");
                        vyber4 = Console.ReadLine();
                    }
                    if (vyber4 == "zaplatis")
                    {
                        Console.WriteLine("urobil si asi dobre pre svoje dusevne zdravie ,no strata bola velka, skrachoval si");
                        Console.WriteLine("stlac hocico pre exit");
                        Console.ReadKey();
                    }
                    else if (vyber4 == "zahodis")
                    {
                        Console.WriteLine("zahodil si danovy list, to neni dobre, dosla policia slovenskej republiky. ides do vazenia na zivot");
                        Console.WriteLine("stlac hocico pre exit");
                        Console.ReadKey();
                    }

                }
        }
    }
}
