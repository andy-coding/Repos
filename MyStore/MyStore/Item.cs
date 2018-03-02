using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public class Item
    {
        /// <summary>
        /// 
        ///
        /// </summary>
        /// <param name="name">Name given to item</param>
        /// <param name="price">price of item</param>
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
            ID = 1;
        }

        #region props Name, ID, Price
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Warehouse itemWarehouse;

        public Warehouse ItemWarehouse
        {
            get { return itemWarehouse; }
            set { itemWarehouse = value; }
        }

        private string warehouseName;

        public string WarehouseName
        {
            get { return warehouseName; }
            set { warehouseName = itemWarehouse.Name; }
        }



        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion


        public void UpdatePrice(decimal price)
        {
            this.Price = price;

        } // end method

    }
}
