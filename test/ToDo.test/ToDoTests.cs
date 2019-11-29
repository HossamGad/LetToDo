using System;
using Xunit;
using System.Collections.Generic;

namespace lefttodo.test
{
    public class ToDoTests
    {
        [TestMethod]
        public void Test()
        {
            //Arrange
            List<Item> ItemList= new List<Item>(); 
            var item = new Item();
            
            //act
            item.Items("Task", "1", "2");
            ItemList.add(item);
            int lentgh = ItemList.Count;

            //assert
            Assert.Equal(1,length); 
        }

        public void TaskToDone()
        {

        }

        public void File_Done()
        {

        }
    }
}
