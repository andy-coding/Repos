using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABProj
{
    public class Device
    {
        private int deviceId;

        public int DeviceId
        {
            get { return deviceId; }
            set { deviceId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool SellDevice()
        {
            var sold = false;


            return sold;
        }

    }
}
