using System;

namespace ProductManager.Entity {

    public class Cost {
        public int Id { set; get; }

        /// <summary>
        /// 所属公司Id
        /// </summary>
        public int CompanyId { set; get; }

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

        /// <summary>
        /// 其它可控成本：【ControllableCost-WorkersWelfare】
        /// </summary>
        public double? OtherControllableCost { set; get; }

        /// <summary>
        /// 其它不可控成本：【TotalCost-ControllableCost-Salary】
        /// </summary>
        public double? OtherUnControllableCost { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { set; get; }

        /// <summary>
        /// 修改时间
        /// </summary>

        public DateTime ModifyTime { set; get; }
    }
}