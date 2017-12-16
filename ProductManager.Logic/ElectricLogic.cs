using System;
using System.Linq;
using ProductManager.Entity;
using ProductManager.Model.ItemModel;

namespace ProductManager.Logic {
    public class ElectricLogic {
        private readonly ProductManagerContext _context;
        public ElectricLogic() {
            _context = new ProductManagerContext();
        }

        public bool Add(ElectricItem electricItem) {
            var companyLogic = new CompanyLogic();
            var companyId = companyLogic.GetCompanyId(electricItem.CompanyName);
            var electric = _context.Electrics.FirstOrDefault(item => item.CompanyId == companyId && item.Year == electricItem.Year && item.Month == electricItem.Month);
            if (electric != null) {
                electric.Electricity = electricItem.Electricity;
                electric.BuyElectricity = electricItem.BuyElectricity;
                electric.BuyAvgPrice = electricItem.BuyAvgPrice;
                electric.SellElectricity = electricItem.SellElectricity;
                electric.SellAvgPrice = electricItem.SellAvgPrice;
                electric.ModifyTime = DateTime.Now;
            }
            else {
                var entity = new Electric {
                    CompanyId = companyId,
                    Year = electricItem.Year,
                    Month = electricItem.Month,
                    Electricity = electricItem.Electricity,
                    BuyElectricity = electricItem.BuyElectricity,
                    BuyAvgPrice = electricItem.BuyAvgPrice,
                    SellElectricity = electricItem.SellElectricity,
                    SellAvgPrice = electricItem.SellAvgPrice,
                    CreateTime = DateTime.Now,
                    ModifyTime = DateTime.Now
                };
                _context.Electrics.Add(entity);
            }
            _context.SaveChanges();
            return true;
        }
    }
}