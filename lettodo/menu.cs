using System;
using System.Collections.Generic;

namespace LeftToDo
{
    class Menu
    {   
        List<Done> Done_List = new List<Done>();   
        List<Item> ItemList= new List<Item>();  
        public void Start()
        {
            string myItem, status;
            int length;                 

            int choice;
            do 
            {
             Console.WriteLine("\n\t--------- Let To Do -----------");
             Console.WriteLine("=============== MENU =============");
             Console.WriteLine("[1] Listing all items");
             Console.WriteLine("[2] Add new task ");
             Console.WriteLine("[3] List all archived tasks");
             Console.WriteLine("[4] Archive all finished tasks");
             Console.WriteLine("[5] Exit Program");
             Console.Write("\tPlease enter your choice ");
                    
                    int.TryParse(Console.ReadLine(), out choice); 

                    switch (choice)
                        {
                            // Showing all items    
                            case 1:
                            Console.WriteLine("Listing all items");

                            foreach (Item listd in ItemList){                                                            
                                listd.ShowProducts(); 
                            } 

                                                                              
                            break;

                            // Adding an Item
                            case 2:
                            Console.WriteLine("Add new task");
                            myItem= Console.ReadLine();
                            Console.WriteLine("What is the status?");
                            Console.WriteLine("todo (1) or done (2)?");
                          
                            bool continuepar= false;
                            do
                            {
                                string task = Console.ReadLine();

                                if (task== "1" || task == "2")
                                {
                                continuepar = true;
                                status = task;                                     
                                      
                                length = ItemList.Count;//Showing the size of list
                                        
                                string id = (length + 1).ToString(); 
                                    
                                Item ltdList= new Item();
                                ltdList.Items(myItem, status, id);                                                         
                                ItemList.Add(ltdList); 

                                //print all items in Itemlist
                                foreach(Item tsk in ItemList)
                                {
                                Console.WriteLine(tsk.myItem, tsk.status, tsk.id );
                                }                         
                                    
                                }
                                else
                                {Console.WriteLine("Wrong choice, Please enter (1) or (2)");}
                                
                            } while (continuepar == false);                     
                                                        
                            break;
                            
                            
                            case 3:
                            Console.WriteLine("List all archived tasks");
                            FileAll();                          

                            break;

                            case 4:
                            Console.WriteLine("Archive all finished tasks\n");
                                                        
                            foreach (Done listd2 in Done_List){
                                listd2.ShowProducts();}                                                           
                            break;

                            case 5:
                            Console.WriteLine("Exiting Program");                            
                            break;

                            default:
                            Console.WriteLine("\n\tWrong choice - try again  ");
                            break;
                        }

            }while (choice != 5);

            
        }
        
        public void FileAll()
        {
            Done done_list = new Done();
                            
            List<Item> newList = new List<Item>(ItemList);        //copy of itemlist to a new list               

            foreach (Item ltd in newList){
            Console.WriteLine(ltd.myItem, ltd.status, ltd.id);
            if(ltd.status == "done")   
                {
                done_list.Items(ltd.myItem, ltd.status, ltd.id);                                
                Done_List.Add(done_list);
                ItemList.Remove(ltd);
                }                          

            foreach(Item itm in ItemList)
            {
            Console.WriteLine(itm.myItem, itm.status, itm.id);
            }                              
            }
        }
    }
}