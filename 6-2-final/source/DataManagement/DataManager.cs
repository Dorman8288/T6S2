using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace tamrin_6_2_final.source.DataManagement
{
    static class DataManager
    {
        static List<MediaClasses.Media> medias = new List<MediaClasses.Media>();
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
            Save("Accounts.json", account);
        }
        public static void AddMedia(MediaClasses.Media media)
        {
            medias.Add(media);
            Save("Accounts.json", media);
        }
    }
}
