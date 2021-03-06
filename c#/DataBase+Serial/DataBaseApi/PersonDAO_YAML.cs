﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DataBaseApi
{
    class PersonDAO_YAML : IPerson_DAO
    {
        string path="YAML_DB.txt";
        private string ToYAML(Person p)
        {
            string yaml_string = "- ";
            yaml_string += "Id:" + p.Id;
            yaml_string += "\n  Fn:" + p.Fn;
            yaml_string += "\n  Ln:" + p.Ln;
            yaml_string += "\n  Age:" + p.Age + "\n";
            return yaml_string;
        }
        private Person FromYAML(string str)
        {
            string[] args = str.Split('\n', ':');
            return new Person(Int32.Parse(args[1]), args[3], args[5], Int32.Parse(args[7]));
        }
        private void WasCreated()
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.Close();
            }
            catch (Exception)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write("Persons:\n");
                sw.Close();
            }
        }
        private List<string> CurrentData()
        {
            StreamReader sr = new StreamReader(path);
            List<string> data = new List<string>();
            while (!sr.EndOfStream)
            {
                data.Add(sr.ReadLine());
            }
            sr.Close();
            return data;
        }
        public void Create(Person p)
        {
            WasCreated();
            StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Append, FileAccess.Write));
            sw.Write(ToYAML(p));
            sw.Close();
        }
        private void ReCreate(List<Person> li)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write("Persons:\n");
            foreach(Person p in li)
            {
                sw.Write(ToYAML(p));
            }
            sw.Close();
        }
        public void Delete(Person p)
        {
            WasCreated();
            List<string> data = CurrentData();
            List<Person> li = new List<Person>();
            string yaml_string = "";
            int i = 0;
            while (++i < data.Count)
            {
                yaml_string += data[i] + "\n";
                if (i % 4 == 0)
                {
                    if (FromYAML(yaml_string).Id != p.Id)
                    {
                        li.Add(FromYAML(yaml_string));
                    }
                    yaml_string = "";
                }
            }
            ReCreate(li);
        }
        public List<Person> Read()
        {
            WasCreated();
            List<string> data = CurrentData();
            List<Person> li = new List<Person>();
            string yaml_string="";
            int i = 0;
            while(++i<data.Count)
            {
                yaml_string += data[i]+"\n";
                if(i%4==0)
                {
                    li.Add(FromYAML(yaml_string));
                    yaml_string = "";
                }
            }
            return li;
        }
        public void Update(Person p)
        {
            WasCreated();
            List<string> data = CurrentData();
            List<Person> li = new List<Person>();
            string yaml_string = "";
            int i = 0;
            while (++i < data.Count)
            {
                yaml_string += data[i] + "\n";
                if (i % 4 == 0)
                {
                    if (FromYAML(yaml_string).Id != p.Id)
                    {
                        li.Add(FromYAML(yaml_string));
                    }
                    else
                    {
                        li.Add(p);
                    }
                    yaml_string = "";
                }
            }
            ReCreate(li);
        }
    }
}
