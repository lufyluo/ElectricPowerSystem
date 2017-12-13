namespace ProductManager.Model.ItemModel {
    public class CostItem {
        public int Id { set; get; }

        /// <summary>
        /// 所属公司
        /// </summary>
        public double CompanyName { set; get; }

        /// <summary>
        /// 所属年
        /// </summary>
        public int Year { set; get; }

        /// <summary>
        /// 所属月
        /// </summary>
        public int? Month { set; get; }

        /// <summary>
        /// 福利费
        /// </summary>
        public double? WelfareFunds { set; get; }

        /// <summary>
        /// 可控成本
        /// </summary>
        public double? ControllableCost { set; get; }

        /// <summary>
        /// 差旅费
        /// </summary>
        public double? TravelExpenses { set; get; }

        /// <summary>
        /// 不可控成本：【可控成本-差旅费】
        /// </summary>
        public double? UnControllableCost { set; get; }

        /// <summary>
        /// 人工成本(不含福利费）
        /// </summary>
        public double? ArtificialCost { set; get; }

        /// <summary>
        /// 工资
        /// </summary>
        public double? Salary { set; get; }

        /// <summary>
        /// --总计
        /// </summary>
        public double? TotalCost { set; get; }

        /// <summary>
        /// 其它不可控成本：【TotalCost-UnControllableCost-Salary】
        /// </summary>
        public double? OtherUnControllableCost { set; get; }
    }
}