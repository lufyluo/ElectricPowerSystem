using System;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class ElectricLogic {
        private readonly ProductManagerContext _context;
        public ElectricLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(ElectricItem item) {
            var entity = new Electric() {
                Year = item.Year,
                Month = item.Month,
                Electricity = item.Electricity,
                BuyElectricity = item.BuyElectricity,
                BuyAvgPrice = item.BuyAvgPrice,
                SellElectricity = item.SellElectricity,
                SellAvgPrice = item.SellAvgPrice,
                CreateTime = DateTime.Now,
                ModifyTime = DateTime.Now
            };

            var companyLogic = new CompanyLogic();
            entity.CompanyId = companyLogic.GetCompanyId(item.CompanyName);
            _context.Electrics.Add(entity);
            _context.SaveChanges();
            return true;
        }
    }
}