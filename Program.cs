using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_3_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = Convert.ToInt32(Console.ReadLine());
            if (task == 1)
            {

                File file = new File() { path = @"E:\Matan" };
                file.Add();
                file.GetList();
                file.Add2();
                file.Add();
                file.GetList();
            }

            else
            {
                Dictionary<int, int> dict = new Dictionary<int, int>()
                {
                    [0] = 12352773,
                    [1] = 13251536,
                    [2] = 12456865,
                    [3] = 24523467,
                    [4] = 94283564,
                    [5] = 24352346,
                    [6] = 23436546,
                    [7] = 64324356,
                    [8] = 21454263,
                    [9] = 21452363

                };
                List<int> res = new List<int>();

                foreach (KeyValuePair<int, int> p in dict)
                {


                }

                for (int i = 0; i < 10; i++)
                {
                    res.Add(dict[i]);


                }
                foreach (int r in res)
                {
                    Console.WriteLine(r);
                }
                res.Sort();
                res.Reverse();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(res[i]);
                }

            }
        }
    }
    class File
    {
        List<string> cat = new List<string>();
        public string path;
        public void Add()
        {
            
            Console.WriteLine("files");
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                Console.WriteLine(f);
                cat.Add(f);
                
            }
        }
        public void Add2()
        {
            Console.WriteLine(new string('-', 25));
            string[] dirs = Directory.GetDirectories(path);
            foreach(string d in dirs)
            {
                Console.WriteLine("Directories");
                path = d;
                
            }
        }
        public void GetList()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("List");
            
            foreach(string c in cat)
            {
                Console.WriteLine(c);
            }
        }

    }
   
    
}
