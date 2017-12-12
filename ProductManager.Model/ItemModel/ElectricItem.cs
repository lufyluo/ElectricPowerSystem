namespace ProductManager.Model.ItemModel {
    public class ElectricItem {
        /// <summary>
        /// 发电量
        /// </summary>
        public float Electricity { set; get; }
        /// <summary>
        /// 购电量
        /// </summary>
        public float BuyElectricity { set; get; }
        /// <summary>
        /// 购电均价
        /// </summary>
        public float BuyAvgPrice { set; get; }
        /// <summary>
        /// 售电量
        /// </summary>
        public float SellElectricity { set; get; }
        /// <summary>
        /// 售电均价
        /// </summary>
        public float SellAvgPrice { set; get; }
    }
}