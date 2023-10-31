using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private static int _id = 0;
        private static string _groupno;
        private static string _name;
        private static string _surName;
        private static int _age;

        public int Id { get; set; }

        public static string Name { 
            get => _name;
            set => _name = value;
        }
        public static string SurName
        {
            get => _surName;
            set => _surName = value;
        }
        public string GroupNo { 
            get => _groupno;
            set {

                while (value[0] < 65 || value[0] > 90) 
                {
                    Console.WriteLine("Herfi duz daxil edin!!!");
                    Console.WriteLine("Input group name: ");
                    value = Console.ReadLine();
                }

                for (int i = 1; i < value.Length; i++)
                {
                    while (value[i] < 48 || value[i] > 57)
                    {
                        Console.WriteLine(i+1 + "." + "Sirada reqem olmalidir!!!");
                        Console.WriteLine("Input group name: ");
                        value = Console.ReadLine();
                    }
                }

                _groupno = value;

            }
        }
        public int Age
        {
            get => _age;
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Input Wrong!!!");
                    Console.WriteLine("Input Age: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _age = value;
            } 
        }


        internal static bool CheckGroupName(string groupNo)
        {
            if (groupNo.ToUpper() == _groupno)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FullName() => char.ToUpper(Name[0]) + Name.Substring(1) + " " + char.ToUpper(SurName[0]) + SurName.Substring(1);

        public static bool CheckFullname(string fullname)
        {
            if (fullname == FullName())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Student()
        {
            _id++;
            Id = _id;
        }
    }
}
