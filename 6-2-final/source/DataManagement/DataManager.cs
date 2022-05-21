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
            writer.WriteLine(JsonSerializer.Serialize(input));
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
                string json = reader.ReadLine();
                Account account = JsonSerializer.Deserialize<Account>(json);
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
                string json = reader.ReadLine();
                Media media = JsonSerializer.Deserialize<Media>(json);
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
                        catch
                        {
                            Seller newSeller = new Seller(name, password);
                            AddAccount(newSeller);
                        }
                        break;
                    }
                case LoginType.Customer:
                    {
                        try
                        {
                            return findaccount(new Customer(name, password));
                        }
                        catch
                        {
                            MessageBox.Show("YES");
                            Customer newSeller = new Customer(name, password);
                            AddAccount(newSeller);
                        }
                        break;
                    }
                case LoginType.Teacher:
                    {
                        try
                        {
                            return findaccount(new Teacher(name, password));
                        }
                        catch
                        {
                            Teacher newSeller = new Teacher(name, password);
                            AddAccount(newSeller);
                        }
                        break;
                    }
                case LoginType.Student:
                    {
                        try
                        {
                            return findaccount(new Student(name, password));
                        }
                        catch
                        {
                            Student newSeller = new Student(name, password);
                            AddAccount(newSeller);
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
    }
}
