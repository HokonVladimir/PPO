using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Price_List
{
    class Service {
        private string              description;
        private string              serviceName;

        private double              price;
        private int                 id;

        internal Service(int ID, string serviceName, string description, double price) {
            this.ID = ID;
            this.serviceName    = serviceName;
            this.description    = description;
            this.price          = price;
        }

        public int ID { get => id; set => id = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }

        public override bool Equals(object obj) {
            if (obj == null || obj.GetType() != this.GetType()) {
                return false;
            } if ((obj as Service).serviceName == serviceName ||
                  (obj as Service).ID == ID) {
                return true;
            } return false;
        }

        public override string ToString() {
            return "ID: " + ID + "\nУслуга: " + serviceName + "\nОписание: " + description + "\nЦена: " + price.ToString() + "\n*\n";
        }
    }
}
