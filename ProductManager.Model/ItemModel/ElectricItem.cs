﻿namespace ProductManager.Model.ItemModel {
    public class ElectricItem {
        /// <summary>
        /// Id
        /// </summary>
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
    }
}