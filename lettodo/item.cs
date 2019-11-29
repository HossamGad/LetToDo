using System;
using System.Collections.Generic;

namespace LeftToDo
{    
  

    public class NewTask
    {
        public void Items()  
        {}

        public void ShowAllProducts()
        {}  
    }


    public class Item 
    {
        public void Items(string myItem, string status, string id)
        {this.myItem =myItem;
        this.status = status;
        this.id =id;      
        }

        public void ShowProducts()
        {               
        Console.WriteLine($"{myItem}, {status} {id}");
        } 

        public string myItem{get;set;}
        public string status {get;set;}   
        public string id {get;set;}
       
        
    }

}