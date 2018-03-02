using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Item
    {
        /// <summary>
        /// item definition
        /// </summary>

        public Item()
        {

        }

        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private int itemId;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string MyMethod()
        {
            return "Boo " + ItemName + " " + ItemId;
        }
    }
}
