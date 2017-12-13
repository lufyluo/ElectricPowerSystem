namespace ProductManager.Model.ItemModel {

    public class CostItem {
        public int Id { set; get; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public string CompanyName { set; get; }

        /// <summary>
        /// 所属年
        /// </summary>
        public int Year { set; get; }

        /// <summary>
        /// 所属月
        /// </summary>
        public int? Month { set; get; }

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
    }
}