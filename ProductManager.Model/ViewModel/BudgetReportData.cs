using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Model.ViewModel
{
    public class BudgetReportData
    {
        #region baseinfo
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { set; get; }
        #endregion

        #region electric
        /// <summary>
        /// 发电量
        /// </summary>
        public double? Electricity { set; get; }
        /// <summary>
        /// 购电量
        /// </summary>
        public double? BuyElectricity { set; get; }
        /// <summary>
        /// 购电均价
        /// </summary>
        public double? BuyAvgPrice { set; get; }
        /// <summary>
        /// 售电量
        /// </summary>
        public double? SellElectricity { set; get; }
        /// <summary>
        /// 售电均价
        /// </summary>
        public double? SellAvgPrice { set; get; }



        #endregion

        #region cost
        /// <summary>
        /// 人工成本(不含福利费）【工资】【L10】
        /// </summary>
        public double? Salary { set; get; }

        /// <summary>
        /// 职工福利费【L26】
        /// </summary>
        public double? WorkersWelfare { set; get; }

        /// <summary>
        /// 合计【L63】
        /// </summary>
        public double? TotalCost { set; get; }

        /// <summary>
        /// 其中：可控成本费用【L64】
        /// </summary>
        public double? ControllableCost { set; get; }

        /// <summary>
        /// 不可控成本：【可控成本-差旅费】
        /// </summary>
        public double? UnControllableCost { set; get; }

        /// <summary>
        /// 其它不可控成本：【TotalCost-UnControllableCost-Salary】
        /// </summary>
        public double? OtherUnControllableCost { set; get; }
        #endregion

        #region profit
        /// <summary>
        /// 委托运行维护费
        /// </summary>
        public double? ThirdMaintenanceFee { set; get; }

        /// <summary>
        /// 用户工程及租赁收入
        /// </summary>
        public double? EngineeringAndLeasehold { set; get; }

        /// <summary>
        /// 其他业务成本
        /// </summary>
        public double? OtherCost { set; get; }

        /// <summary>
        /// 营业税金及附加
        /// </summary>
        public double? TaxAndAdditional { set; get; }

        /// <summary>
        /// 财务费用
        /// </summary>
        public double? FinancialCost { set; get; }

        /// <summary>
        /// 资产减值损失
        /// </summary>
        public double? AssetsImpairmentLoss { set; get; }

        /// <summary>
        /// 利润
        /// </summary>
        public double? ProfitValue { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }


        #endregion
    }
}
