using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Model.Dictionary
{
    public class NormDictionary
    {
        private static Dictionary<string,string> _reportDictionary ;
        private static readonly object _lockObj =new object();

        public static Dictionary<string, string> GetReportDictionary()
        {
            if (_reportDictionary == null)
            {
                lock (_lockObj)
                {
                    if(_reportDictionary!=null)return _reportDictionary;
                    
                    _reportDictionary = new Dictionary<string, string>();
                    InitDictionaryData();
                    return _reportDictionary;
                }
               
            }
            return _reportDictionary;
        }

        private static void InitDictionaryData()
        {
            //electric
            _reportDictionary.Add("名称", "CompanyName");
            _reportDictionary.Add("发电量", "Electricity");
            _reportDictionary.Add("购电量", "BuyElectricity");
            _reportDictionary.Add("购电均价", "BuyAvgPrice");
            _reportDictionary.Add("售电量", "SellElectricity");
            _reportDictionary.Add("售电均价", "SellAvgPrice");
            _reportDictionary.Add("线损", "LineLoss");

            //profit
            _reportDictionary.Add("售电收入", "Income");
            _reportDictionary.Add("委托运行维护费", "ThirdMaintenanceFee");
            _reportDictionary.Add("用户工程及租赁收入", "EngineeringAndLeasehold");
            _reportDictionary.Add("购电成本", "");

            //cost
            _reportDictionary.Add("福利费", "WorkersWelfare");
            _reportDictionary.Add("其他可控", "ControllableCost");
            _reportDictionary.Add("可控成本小计", "ControllableCostTotal");
            _reportDictionary.Add("人工成本", "Salary");
            _reportDictionary.Add("其他不可控", "OtherUnControllableCost");
            _reportDictionary.Add("不可控成本小计", "OtherUnControllableCostTotal");

            //profit
            _reportDictionary.Add("其他业务成本", "OtherCost");
            _reportDictionary.Add("营业税金及附加", "TaxAndAdditional");
            _reportDictionary.Add("财务费用", "FinancialCost");
            _reportDictionary.Add("资产减值损失", "AssetsImpairmentLoss");
            _reportDictionary.Add("利润", "ProfitValue");
        }
    }
}
