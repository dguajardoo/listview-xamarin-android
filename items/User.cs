﻿using System;
namespace items
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string ImageUrl { get; set; }  
        public string Department { get; set; }  
        public string Details { get; set; }  
  
        public override string ToString()  
        {  
            return Name + " " + Department;  
        }  
    }
}
