using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    class Stock
    {
        public Stock(Warehouse inWarehouse, Item inItem)
        {
            warehouse =inWarehouse;
            item = inItem;

        }

        private Warehouse warehouse;

        public Warehouse Warehouse
        {
            get { return warehouse; }
            set { warehouse = value; }
        }

        private Item item;

        public Item Item
        {
            get { return item; }
            set { item = value; }
        }


    }
}
