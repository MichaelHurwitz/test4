using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;
using test4.Model;

namespace test4.Service
{
    internal static class DateService
    {
        private static readonly string _path = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Queries.xml"
            );

        public static XDocument ReadDocument() => XDocument.Load(_path);
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(_path))
            {
                XDocument document = XDocument.Parse(@"<Queries></Queries>");
                document.Save(_path);
            }
        }
        public static XElement ConvertQueryToXElement(Date date) =>
            new("Query",
                new XAttribute("dayWeek", date.dayOfWeek),
                new XAttribute("dayMonth", date.dayOfMonth),
                new XAttribute("Month", date.month),
                new XAttribute("Year", date.year),
                new XAttribute("Result", date.result)
            );
        public static XDocument AddDate(XDocument document, Date date)
        {
            document.Descendants("Queries")
                .First()
                .Add(ConvertQueryToXElement(date));
            return document;
        }
        public static void Save(XDocument document)
        {
            document.Save(_path);
        }

        public static string GetDay(string day) =>
            day switch
            {
                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "שישי" => "בששי בשבת"
            };
        public static string GetMonth(string month) =>
            month switch
            {
                "תשרי" => "תשרי",
                "מרחשון" => "מרחשון",
                "כסלו" => "כסלו",
                "טבת" => "טבת",
                "שבט" => "שבט",
                "אדר" => "אדר",
                "אדר הראשון" => "אדר הראשון",
                "אדר השני" => "אדר השני",
                "ניסן" => "ניסן",
                "אייר" => "אייר",
                "סיון" => "סיון",
                "תמוז" => "תמוז",
                "אב" => "אב",
                "אלול" => "אלול"
            };
        public static string GetDayOfMonth(string dayOfMonth, string month) =>
            dayOfMonth switch
            {
                "1" => $"אחד לירח{GetMonth(month)}",
                "2" => $"שני לירח {GetMonth(month)}",
                "3" => $"שלושה ימים לירח {GetMonth(month)}",
                "4" => $"ארבעה ימים לירח {GetMonth(month)}",
                "5" => $"חמשה ימים לירח {GetMonth(month)}",
                "6" => $"ששה ימים לירח {GetMonth(month)}",
                "7" => $"שבעה ימים לירח {GetMonth(month)}",
                "8" => $"שמנה ימים לירח {GetMonth(month)}",
                "9" => $"תשעה ימים לירח {GetMonth(month)}",
                "10" => $"עשרה ימים לירח {GetMonth(month)}",
                "11" => $"אחד עשר יום לירח {GetMonth(month)}",
                "12" => $"שנים עשר יום לירח {GetMonth(month)}",
                "13" => $"שלושה עשר יום לירח {GetMonth(month)}",
                "14" => $"ארבעה עשר יום לירח {GetMonth(month)}",
                "15" => $"חמשה עשר יום לירח{GetMonth(month)}",
                "16" => $"ששה עשר יום לירח {GetMonth(month)}",
                "17" => $"שבעה עשר יום לירח {GetMonth(month)}",
                "18" => $"שמנה עשר יום לירח {GetMonth(month)}",
                "19" => $"תשעה עשר יום לירח {GetMonth(month)}",
                "20" => $"עשרים יום לירח {GetMonth(month)}",
                "21" => $"אחד ועשרים יום לירח {GetMonth(month)}",
                "22" => $"שנים ועשרים יון לירח {GetMonth(month)}",
                "23" => $"שלושה ועשרים יום לירח {GetMonth(month)}",
                "24" => $"ארבעה ועשרים יום לירח {GetMonth(month)}",
                "25" => $"חמשה ועשרים יום לירח {GetMonth(month)}",
                "26" => $"ששה ועשרים יום לירח {GetMonth(month)}",
                "27" => $"שבעה ועשרים יום לירח {GetMonth(month)}",
                "28" => $"שמנה ועשרים יום לירח {GetMonth(month)}",
                "29" => $"תשעה ועשרים יום לירח {GetMonth(month)}",
                "30" => $"יום שלושים לחודש {GetMonth(month)} שהוא ראש חודש {NextMonth(month)}"
            };

        public static string NextMonth(string month) =>
            month switch
            {
                "תשרי" => "מרחשון",
                "מרחשון" => "כסלו",
                "כסלו" => "טבת",
                "טבת" => "שבט",
                "שבט" => "אדר",
                "אדר" => "ניסן",
                "אדר הראשון" => "אדר השני",
                "אדר השני" => "ניסן",
                "ניסן" => "אייר",
                "אייר" => "סיון",
                "סיון" => "תמוז",
                "תמוז" => "אב",
                "אב" => "אלול",
                "אלול" => "תשרי"
            };
        public static string GetYear(string year) =>
            year switch
            {
                "התשפ'ד" => "חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם",
                "התשפ'ה" => "חמשת אלפים ושבע מאות ושמנים חמש לבריאת העולם",
                "התשפ'ו" => "חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם",
                "התשפ'ז" => "חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם",
                "התשפ'ח" => "חמשת אלפים ושבע מאות ושמנים ושמנה לבריאת העולם",
                "התשפ'ט" => "חמשת אלפים ושבע מאות ושמנים ותשעלבריאת העולם",
                "התש'צ'" => "חמשת אלפים ושבע מאות ותשעים לבריאת העולם",
                "התשצ'א" => "חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם",
                "התשפצ'ב" => "חמשת אלפים ושבע מאות ותשעים ושנים לבריאת העולם",
                "התשצ'ג" => "חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם"
            };

        public static string GetResult(
            string day, string dayOfMonth, string month, string year
            ) =>
            $"{GetDay(day)} {GetDayOfMonth(dayOfMonth ,month)} {GetYear(year)}";
    }
}

