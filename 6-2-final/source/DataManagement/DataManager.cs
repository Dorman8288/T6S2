using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace tamrin_6_2_final
{
    static class DataManager
    {
        static List<Media> medias = new List<Media>();
        static List<Account> accounts = new List<Account>();
        public static void SaveAll()
        {
            SaveAccounts();
            SaveMedias();
        }
        public static void SaveAccounts()
        {
            if (File.Exists("Accounts.json")) File.Delete("Accounts.json");
            foreach (var account in accounts)
            {
                Save("Accounts.json", account);
            }
        }
        public static void SaveMedias()
        {
            if (File.Exists("Media.json")) File.Delete("Media.json");
            foreach (var media in medias)
            {
                Save("Media.json", media);
            }
        }
        public static void Save(string path, object input)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine($"{input.GetType().FullName} {JsonSerializer.Serialize(input)}");
            writer.Close();
        }
        public static void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public static void AddMedia(Media media)
        {
            medias.Add(media);
        }
        public static void LoadAll()
        {
            LoadAccounts();
            LoadMedia();
        }
        public static void LoadAccounts()
        {
            if (!File.Exists("Accounts.json")) return;
            StreamReader reader = new StreamReader("Accounts.json");
            while (!reader.EndOfStream)
            {
                Account account = null;
                string[] data = reader.ReadLine().Split(' ');
                if(data[0] == typeof(Seller).FullName)
                {
                    account = JsonSerializer.Deserialize<Seller>(data[1]);
                }
                if (data[0] == typeof(Student).FullName)
                {
                    account = JsonSerializer.Deserialize<Student>(data[1]);
                }
                if (data[0] == typeof(Teacher).FullName)
                {
                    account = JsonSerializer.Deserialize<Teacher>(data[1]);
                }
                if (data[0] == typeof(Customer).FullName)
                {
                    account = JsonSerializer.Deserialize<Customer>(data[1]);
                }
                if (account == null) throw new Exception("data Currupted");
                AddAccount(account);
            }
            reader.Close();
        }
        public static void LoadMedia()
        {
            if (!File.Exists("Media.json")) return;
            StreamReader reader = new StreamReader("Media.json");
            while (!reader.EndOfStream)
            {
                Media media = null;
                string[] data = reader.ReadLine().Split(' ');
                if (data[0] == typeof(Magazines).FullName)
                {
                    media = JsonSerializer.Deserialize<Magazines>(data[1]);
                }
                if (data[0] == typeof(Videos).FullName)
                {
                    media = JsonSerializer.Deserialize<Videos>(data[1]);
                }
                if (data[0] == typeof(Book).FullName)
                {
                    media = JsonSerializer.Deserialize<Book>(data[1]);
                }
                if (media == null) throw new Exception("data Currupted");
                AddMedia(media);
            }
            reader.Close();
        }
        public static void DeleteMedia(string ID)
        {
            if (!isRegisteredID(ID)) throw new Exception("this id is not registered");
            for(int i = 0; i < medias.Count; i++)
            {
                if(medias[i].ID == ID)
                {
                    medias.Remove(medias[i]);
                    i--;
                }
            }
        }
        public static string SearchMedia(string ID)
        {
            if (!isRegisteredID(ID)) throw new Exception("this id is not registered");
            foreach(var media in medias)
            {
                if (media.ID == ID)
                {
                    return media.info();
                }
            }
            throw new Exception("not found");
        }
        public static Media FindMedia(string name)
        {
            return medias.Find(x => x.name == name);
        }
        public static bool isRegisteredID(string ID)
        {
            foreach(var media in medias)
            {
                if (ID == media.ID) return true;
            }
            return false;
        }
        public static bool isRegisteredSSN(string SSN)
        {
            foreach (var account in accounts)
            {
                if (account is Customer && (account as Customer).SSN == SSN) return true;
            }
            return false;
        }
        public static Account login(string name, string password, LoginType type)
        {
            switch (type)
            {
                case LoginType.Seller:
                    {
                        try
                        {
                            return findaccount(new Seller(name, password));
                        }
                        catch(Exception e)
                        {
                            if (e.Message == "this account is not registered")
                            {
                                Seller newSeller = new Seller(name, password);
                                AddAccount(newSeller);
                                return newSeller;
                            }
                            else throw e;
                        }
                        break;
                    }
                case LoginType.Customer:
                    {
                        try
                        {
                            return findaccount(new Customer(name, password));
                        }
                        catch (Exception e)
                        {
                            if (e.Message == "this account is not registered")
                            {
                                Customer newCustomer = new Customer(name, password);
                                AddAccount(newCustomer);
                                return newCustomer;
                            }
                            else throw e;
                        }
                        break;
                    }
                case LoginType.Teacher:
                    {
                        try
                        {
                            return findaccount(new Teacher(name, password));
                        }
                        catch (Exception e)
                        {
                            if (e.Message == "this account is not registered")
                            {
                                Teacher newTeacher = new Teacher(name, password);
                                AddAccount(newTeacher);
                                return newTeacher;
                            }
                            else throw e;
                        }
                        break;
                    }
                case LoginType.Student:
                    {
                        try
                        {
                            return findaccount(new Student(name, password));
                        }
                        catch (Exception e)
                        {
                            if (e.Message == "this account is not registered")
                            {
                                Student newStudent = new Student(name, password);
                                AddAccount(newStudent);
                                return newStudent;
                            }
                            else throw e;
                        }
                        break;
                    }
            }
            return null;
        }
        public static Account findaccount(Account input)
        {
            foreach(var Account in accounts)
            {
                if(Account == input)
                {
                    return Account;
                }
            }
            throw new Exception("this account is not registered");
        }
        public static string getCustomers()
        {
            string ans = "";
            foreach(var account in accounts)
            {
                if(!(account is Seller))
                {
                    ans += account.info() + "********\n";
                }
            }
            if (ans == "") return "no customers";
            return ans;
        }
        public static List<string> getMediasName()
        {
            List<string> ans = new List<string>();
            foreach (var media in medias)
                ans.Add($"{media.name} price:{media.price}$");
            return ans;
        }
    }
}
