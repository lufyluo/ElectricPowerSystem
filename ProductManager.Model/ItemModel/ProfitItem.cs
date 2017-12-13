using System;

namespace ProductManager.Model.ItemModel {

    public class ProfitItem {
        public double Id { set; get; }

        /// <summary>
        /// 所属年
        /// </summary>
        public int Year { set; get; }

        /// <summary>
        /// 所属月
        /// </summary>
        public int? Month { set; get; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string CompanyName { set; get; }

        /// <summary>
        /// 委托运行维护费
        /// </summary>
        public double ThirdMaintenanceFee { set; get; }

        /// <summary>
        /// 用户工程及租赁收入
        /// </summary>
        public double EngineeringAndLeasehold { set; get; }

        /// <summary>
        /// 其他业务成本
        /// </summary>
        public double OtherCost { set; get; }

        /// <summary>
        /// 营业税金及附加
        /// </summary>
        public double TaxAndAdditional { set; get; }

        /// <summary>
        /// 财务费用
        /// </summary>
        public double FinancialCost { set; get; }

        /// <summary>
        /// 资产减值损失
        /// </summary>
        public double AssetsImpairmentLoss { set; get; }

        /// <summary>
        /// 利润
        /// </summary>
        public double Profit { set; get; }
    }
}