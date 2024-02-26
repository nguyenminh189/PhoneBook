using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
        public class PhoneBook : Phone
        {


            private List<(string name, string phone)> PhoneList = new List<(string, string)>();
            public override void insertPhone(string name, string phone)
            {
                bool exists = false;
                for (int i = 0; i < PhoneList.Count; i++)
                {

                    if (PhoneList[i].name == name)
                    {
                        exists = true;
                        if (PhoneList[i].phone != phone)
                        {
                        PhoneList[i] = (name, phone);
                            Console.WriteLine("Updated");
                        }
                        else
                        {
                            Console.WriteLine("Already exsist!");
                        }
                    break;

                    } else
                    {
                        PhoneList.Add((name, phone));
                        Console.WriteLine("Success!");
                    }
                }
            }

            public override void removePhone(string name)
            {
                PhoneList.RemoveAll(x => x.name == name);
                Console.WriteLine("Deleted" + name);
            }

            public override void updatePhone(string name, string newPhone)
            {
                for (int i = 0; i < PhoneList.Count; i++)
                {
                    if (PhoneList[i].name == name)
                    {
                        PhoneList.Add((name, newPhone));
                        Console.WriteLine("Success!");
                    } else
                    {
                        Console.WriteLine("Cannot find " + name);
                    }
                }
            }

  
                public override void searchPhone(string name)
            {
                var result = PhoneList.Find(x => x.name == name);
                if (result.name != null)
                {
                    Console.WriteLine($"Phone number of {name}: {result.phone}");
                }
                else
                {
                    Console.WriteLine($"Unable to find phone number {name}");
                }
            }

            public override void Sort()
            {
                PhoneList.Sort((x, y) => x.name.CompareTo(y.name));
                Console.WriteLine("Done.");
            }

            public override void Enter()
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Phone number: ");
                string phone = Console.ReadLine();
                insertPhone(name, phone);
            }
        }

    }

