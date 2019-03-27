using InterplayService;
using InterplayService.Contracts;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EndApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserService();
            CatalogeService catalogeService = new CatalogeService();
            int continueInput = 0;

            do
            {
                    Console.WriteLine("Press 1 to Get Profile");
                    Console.WriteLine("Press 2 to Get ProfileUsers");
                    Console.WriteLine("Press 3 to Get Cataloges");
                int input = Convert.ToInt16(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            {
                                Console.WriteLine("Getting Profile");
                                Console.WriteLine("__________________________________________________");
                                string profile = service.GetProfile();
                                Console.WriteLine(profile);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Getting User Profile");
                                Console.WriteLine("__________________________________________________");
                                string users = service.GetProfileUsers();
                                Console.WriteLine(users);
                                break;
                            }

                    case 3:
                        {
                            Console.WriteLine("Getting User cataloge");
                            Console.WriteLine("__________________________________________________");
                            string users = catalogeService.GetCataloge();
                            Console.WriteLine(users);
                            break;
                        }
                    }

                    Console.WriteLine("Press 1 to continue");
                    continueInput = Convert.ToInt16(Console.ReadLine());
                }
            while (continueInput == 1);
        }
    }
}
