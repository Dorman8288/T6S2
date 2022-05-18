using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace tamrin_6_2_final.source
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
    }
}
