﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class Test
    {
        //parameterless constructor
        public Test()
        {
            name = "Babu";
            i = 100;
        }

        //parameterized
        public Test(string Name)
        {
            name = Name;
            i = 20;
        }

        public Test(string Name, int I)
        {
            i = I;
            name = Name;
        }


        public int i ;

        private string name ; //variable

        //property
        public string Name
        {
            get //READ
            {
                return name;
            }
            set //WRITE
            {
                if (value=="")
                {
                    name = "Broadway";
                }
                else
                {
                    name = value;

                }
            }
        }

        private string firstName = "";
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

       public string LastName { get; set; }

       
        public string FullName
        {
            get { return FirstName + " " + LastName; }
           
        }

       
        //paramerterized
        public string FunctionOne(string str)
        {
            Console.WriteLine("Function One Called "+str);
            Console.WriteLine("I am from function one");

            if (str=="Biraj")
            {
                return "Pradhan";
            }
            else
            {
                return "Shrestha";
            }

            
        }

        public string FunctionOne()
        {
            return "";
        }

        public string FunctionOne(string s, string y)
        {
            return "";
        }
       
        public string FunctionOne(int i)
        {
            return i.ToString();
        }

        //nothing get returns
        public void Add(int x, int y)
        {
            //processing 
            var res = x + y;
            Console.WriteLine("the sum of x and y are " + res);
        }



        public void TemplatedFunction<T1,T2,T3,T4,T5>(T1 x, T2 y)
        {
            Console.WriteLine("Type of T1 = " + typeof(T1));
            Console.WriteLine("Type of T2 = " + typeof(T2));
        }

        public double TestFunction(double a, double b)
        {
            Console.WriteLine("The function is ruuning from test class");
            return 0;
        }

    }

    //public class Animal
    //{
    //    private int FromPartial = 10;
    //}
}
