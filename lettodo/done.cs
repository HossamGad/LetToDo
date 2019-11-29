
using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Done 
    {
      
        public void Items(string myItem, string status, string id)
        {this.myItem = myItem;
        this.status = status;
        this.id =id;    
        }

        public void ShowProducts()
        {               
        Console.WriteLine($"{myItem}, {id}");
        }
       
        public string myItem{get;set;}
        public string status {get;set;}   
        public string id {get;set;}
       
                   
    }

    
}