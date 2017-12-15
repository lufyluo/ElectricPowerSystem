namespace ProductManager.Model.ParamModel {
    public class BaseParam {
        public int? CompanyId { set; get; }
        public int? Year { set; get; }
        public int? Month { set; get; }
        public int? Quarter { set; get; }
        public string TargetKey { set; get; }
    }
}