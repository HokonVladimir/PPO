using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency_Price_List
{
    class DataBase {

        private string                  path = "dataBase.txt";
        private static DataBase         dataBase;
        private BindingList<Service>    priceList = new BindingList<Service>();

        internal BindingList<Service> PriceList { get => priceList; }
        public string Path { get => path; set => path = value; }

        private DataBase() {}

        public static DataBase getInstance() {
            if (dataBase == null) {
                dataBase = new DataBase();
                return dataBase;
            } else {
                return dataBase;
            }
        }

        public bool loadData() {
            priceList.Clear();

            try {
                Service     buffer;
                string[]    content = File.ReadAllLines(path);

                for (int i = 0; i < content.Length; i += 5) {
                    try {
                        buffer = new Service(
                            int.Parse(content[i].Substring(4)),
                            content[i + 1].Substring(8),
                            content[i + 2].Substring(10),
                            double.Parse(content[i + 3].Substring(6))
                        );

                        priceList.Add(buffer);
                    } catch (FormatException) {
                        priceList.Clear();
                        return false;
                    }
                } return true;

            } catch (ArgumentException) {
                return false;
            }
        }

        public bool saveData() {
            string content = "";

            IEnumerator<Service> iter = priceList.GetEnumerator();

            int i = 0;
            while (iter.MoveNext()) {
                iter.Current.ID = i++;
            }

            foreach (Service service in priceList)
                content += service.ToString();

            try {
                File.WriteAllText(path, content);
                return true;
            } catch (IOException) {
                MessageBox.Show("Вы ввели неверный путь к файлу!");
                return false;
            }
        }

        public bool addData(int ID, string serviceName, string description, decimal price) {
            Service service = new Service(ID, serviceName, description.Replace('\n', ' '), Convert.ToDouble(price));

            if (!priceList.Contains(service)) {
                priceList.Add(service);
                return true;
            } else {
                return false;
            }
        }

        public bool changeData(Service changable, int ID, string serviceName, string description, decimal price) {
            Service service = new Service(ID, serviceName, description, Convert.ToDouble(price));

            if (service.ServiceName != serviceName && priceList.Contains(service)) {
                MessageBox.Show("Такой элемент уже существует!");
                return false;
            } else {
                priceList.Remove(changable);
                priceList.Add(service);
                return true;
            }
        }

        public void deleteData(Service deleteable) {
            if (priceList.Remove(deleteable)) {
                MessageBox.Show("Запись успешно удалена!");
            } else {
                MessageBox.Show("Возникли ошибки в удалении записи!");
            }
        }
    }
}
