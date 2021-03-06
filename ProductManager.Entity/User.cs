﻿using System;

namespace ProductManager.Entity {

    public class User {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { set; get; }
        public DateTime ModifyTime { set; get; }
    }
}