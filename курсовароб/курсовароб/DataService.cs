using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using course.Models;
using System;

namespace course.Services
{
    public static class DataService
    {
        private const string PropertiesFileName = "properties.xml";
        private const string TransactionsFileName = "transactions.xml";

        public static void Save(List<Property> properties)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Property>), new[] { typeof(Apartment), typeof(House) });
            using FileStream fs = new FileStream(PropertiesFileName, FileMode.Create);
            serializer.Serialize(fs, properties);
        }

        public static List<Property> Load()
        {
            if (!File.Exists(PropertiesFileName))
            {
                var def = CreateDefaultProperties();
                Save(def);
                return def;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Property>), new[] { typeof(Apartment), typeof(House) });
            using FileStream fs = new FileStream(PropertiesFileName, FileMode.Open);
            var list = (List<Property>)serializer.Deserialize(fs) ?? new List<Property>();

            if (list.Count == 0)
            {
                list = CreateDefaultProperties();
                Save(list);
            }

            return list;
        }

        private static List<Property> CreateDefaultProperties()
        {
            return new List<Property>()
            {
                new Apartment("вул. Київська 10", 55, 55000, 3) { Status = "Продається" },
                new House("вул. Шевченка 22", 120, 120000, 12) { Status = "Продається" },
                new Apartment("просп. Миру 5", 40, 42000, 1) { Status = "Продається" }
            };
        }

        public static void SaveTransactions(List<Transaction> transactions)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transaction>), new[] { typeof(Transaction), typeof(Buyer), typeof(Seller), typeof(Agent), typeof(Apartment), typeof(House) });
            using FileStream fs = new FileStream(TransactionsFileName, FileMode.Create);
            serializer.Serialize(fs, transactions);
        }

        public static List<Transaction> LoadTransactions()
        {
            if (!File.Exists(TransactionsFileName))
                return new List<Transaction>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Transaction>), new[] { typeof(Transaction), typeof(Buyer), typeof(Seller), typeof(Agent), typeof(Apartment), typeof(House) });
            using FileStream fs = new FileStream(TransactionsFileName, FileMode.Open);
            return (List<Transaction>)serializer.Deserialize(fs) ?? new List<Transaction>();
        }
    }
}
