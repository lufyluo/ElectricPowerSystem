using ProductManager.Model.ItemModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using ProductManager.Model.Dictionary;

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
        /// <summary>
        /// 将集合类转换成DataTable
        /// </summary>
        /// <param name="list">集合</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(IList<T> list)
        {
            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = SortPropertyInfosByReportDictionary(list[0].GetType().GetProperties());
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null)??0;
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        private static PropertyInfo[] SortPropertyInfosByReportDictionary(PropertyInfo[] propertyInfos)
        {
            PropertyInfo[] newPropertyInfos = new PropertyInfo[propertyInfos.Length];
            int index = 0;
            foreach (var item in NormDictionary.GetReportDictionary())
            {
                var property = propertyInfos.FirstOrDefault(n => n.Name == item.Key);
                newPropertyInfos[index] = property;
            }
            return newPropertyInfos;
        }
    }
}