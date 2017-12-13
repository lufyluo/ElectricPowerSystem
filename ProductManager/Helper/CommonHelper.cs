using ProductManager.Model.ItemModel;
using System;
using System.Text.RegularExpressions;

namespace ProductManager.Helper {

    public class CommonHelper {

        public static bool IsNumberOrNull(dynamic value) {
            if (value == null) {
                return true;
            }
            var str = value.ToString();
            return string.IsNullOrEmpty(str) || Regex.IsMatch(str, @"^[-]?\d+[.]?\d*$");
        }

        public static UnderDateTime GetUnderDateTime(dynamic value) {
            var str = value.ToString();
            DateTime dt;
            if (!DateTime.TryParse(str, out dt)) {
                return null;
            }

            var result = new UnderDateTime {
                Year = dt.Year
            };

            if (str.Contains("月")) {
                result.Month = dt.Month;
            }
            return result;
        }

        public static string GetCompanyName(dynamic value) {
            var str = value.ToString();
            return str.Replace("编制单位：", "");
        }
    }
}