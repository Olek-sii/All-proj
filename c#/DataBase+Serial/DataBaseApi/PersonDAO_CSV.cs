﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DataBaseApi
{
    class PersonDAO_CSV : IPerson_DAO
    {
        string path = "CSV_DB.txt";
        private void WasCreated()
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(path);
                string str = sr.ReadLine();
                sr.Close();
                if (str.Length == 0)
                    throw new Exception();

            }
            catch(Exception)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Id, Fn, Ln, Age");
                sw.Close();
            }
        }
        private Person FromCSV(string str)
        {
            string[] args = str.Split(',');
            return new Person(Int32.Parse(args[0].Trim(' ')), args[1].Trim(' '), args[2].Trim(' '), Int32.Parse(args[3].Trim(' ')));
        }
        private string ToCSV(Person p)
        {
            string csv_string = "";//формирование строки для вывода
            csv_string += p.Id + ", ";
            csv_string += p.Fn + ", ";
            csv_string += p.Ln + ", ";
            csv_string += p.Age;
            return csv_string;
        }
        private void ReCreateFromTMP()
        {
            StreamReader sr = new StreamReader("tmp.txt");
            StreamWriter sw = new StreamWriter(path);
            string str;
            while(!sr.EndOfStream)
            {
                str=sr.ReadLine();
                sw.WriteLine(str);
            }
            sr.Close();
            sw.Close();
        }
        public void Create(Person p)
        {
            WasCreated();//отрисовка заголовка, если его нет
            string csv_string = ToCSV(p);
            StreamWriter sw = 
                new StreamWriter(File.Open(path, FileMode.Append, FileAccess.Write));
            sw.WriteLine(csv_string);//дозапись в файл
            sw.Close();
        }
        public void Delete(Person p)
        {
            WasCreated();
            StreamReader sr = new StreamReader(path);
            StreamWriter tmp = new StreamWriter("tmp.txt");
            string str = sr.ReadLine();//убираем строку с заголовком
            tmp.WriteLine(str);
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                Person p_db = FromCSV(str);
                if (p_db.Id != p.Id)
                {
                    tmp.WriteLine(str);
                }
            }
            tmp.Close();
            sr.Close();
            ReCreateFromTMP();
        }
        public List<Person> Read()
        {
            List<Person> li = new List<Person>();
            StreamReader data = new StreamReader(path);
            string str;
            data.ReadLine();
            while (!data.EndOfStream)
            {
                str = data.ReadLine();
                Person p=FromCSV(str);
                li.Add(p);
            }
            data.Close();
            return li;
        }
        public void Update(Person p)
        {
            WasCreated();
            StreamReader sr = new StreamReader(path);
            StreamWriter tmp = new StreamWriter("tmp.txt");
            string str = sr.ReadLine();//убираем строку с заголовком
            tmp.WriteLine(str);
            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                Person p_db = FromCSV(str);
                if (p_db.Id != p.Id)
                {
                    tmp.WriteLine(str);//запись всех, кроме модифицируемоего объекта
                }
                else
                {
                    tmp.WriteLine(ToCSV(p));//запись модифицируемого объекта
                }
            }
            tmp.Close();
            sr.Close();
            ReCreateFromTMP();
        }
    }
}
