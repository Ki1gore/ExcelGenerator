using GeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OfficeInteropTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new List<Account> {
                new Account { 
                  ID = 345678,
                  Balance = 541.27
                },
                new Account {
                  ID = 1230221,
                  Balance = -127.44
                }
            };
            //DisplayAccounts(bankAccounts);
            //Entities ctx = new Entities();
            //var articles = ctx.Articles;
            //List<Article> aList = new List<Article>();
            //foreach (var item in articles)
            //{
            //    aList.Add(item);
            //}
            GeneratedClass gc = new GeneratedClass();
            gc.CreatePackage(@"C:\Users\Ltcol\Documents\GeneratedSpreadsheets\out.xlsx");
        }

        private static void DisplayAccounts(List<Account> bankAccounts)
        {
            List<string> properties = new List<string>();
            MemberInfo[] memberInfoList = bankAccounts[0].GetType().GetMembers();
            AlphabetProvider ap = new AlphabetProvider();
            List<char> alphabet = new List<char>(ap.GetAlphabet());
            foreach (var item in memberInfoList)
            {
                if (item.MemberType == MemberTypes.Property)
                {
                    properties.Add(item.Name);
                    string s = GetPropValue(bankAccounts[0], item.Name).ToString();
                }
            }
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }

    public class Account
    {
        public int ID { get; set; }
        public double Balance { get; set; }
    }
}
