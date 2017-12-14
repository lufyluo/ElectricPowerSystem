using System;

namespace ProductManager.Entity {

    public class Company {

        public int Id { set; get; }

        public string Name { set; get; }

        public DateTime CreateTime { set; get; }

        public DateTime ModifyTime { set; get; }
    }
}