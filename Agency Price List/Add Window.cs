using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency_Price_List
{
    public partial class AddWindow : Form {

        private DataBase dataBase = DataBase.getInstance();

        private Service service;

        public AddWindow() {
            InitializeComponent();

            // Загрузка в DataGridView
            data.AutoGenerateColumns = true;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            data.DataSource = dataBase.PriceList;

            // Имена столбцов
            data.Columns[0].HeaderText = "ID УСЛУГИ";
            data.Columns[1].HeaderText = "НАЗВАНИЕ УСЛУГИ";
            data.Columns[2].HeaderText = "ОПИСАНИЕ";
            data.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            data.Columns[3].HeaderText = "ЦЕНА";

            // Событие двойного щелчка (для поиска позиций)
            data.CellDoubleClick += Data_CellDoubleClick;

            // Поиск по позициям
            serviceNameFind.TextChanged += ServiceNameFind_TextChanged;

            // Обработка события кнопки "Добавить"
            addButton.Click += AddButton_Click;

            // Обработка события кнопки "Изменить"
            changeButton.Click += ChangeButton_Click;

            // Обработка события "Очистить"
            clearButton.Click += ClearButton_Click;
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            clear();
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            change();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (checkCorrect()) {
                if (dataBase.addData(dataBase.PriceList.Count, serviceName.Text, description.Text, price.Value)) {
                    MessageBox.Show("Запись добавлена!");
                } else {
                    MessageBox.Show("Такая запись уже существует!");
                }
            }
        }

        private void Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            idTextBox.Text = data.Rows[e.RowIndex].Cells[0].Value.ToString();
            serviceName.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
            description.Text = data.Rows[e.RowIndex].Cells[2].Value.ToString();
            price.Value = decimal.Parse(data.Rows[e.RowIndex].Cells[3].Value.ToString());

            service = new Service(int.Parse(idTextBox.Text), serviceName.Text, description.Text, Convert.ToDouble(price.Value));

            MessageBox.Show("Запись загружена!");
        }

        private void ServiceNameFind_TextChanged(object sender, EventArgs e) {
            if (data.DataSource != null) {
                if (!string.IsNullOrWhiteSpace(serviceNameFind.Text)) {
                    data.DataSource = dataBase.PriceList.Where(x => x.ServiceName.Contains(serviceNameFind.Text)).ToList();
                } else {
                    data.DataSource = dataBase.PriceList;
                }
            }
        }

        private void change() {
            if (service != null) {
                if (dataBase.changeData(service, int.Parse(idTextBox.Text), serviceName.Text, description.Text, price.Value)) {
                    service = null;
                } else {
                    MessageBox.Show("Вы пытаетесь изменить объект на уже имеющийся!");
                }
            } else {
                MessageBox.Show("Сначала найдите объект с помощью двойного щелчка по нему в таблице!");
            }
        }

        private void clear() {
            idTextBox.Text = "";
            serviceName.Text = "";
            description.Text = "";
            price.Value = 0.0M;

            service = null;
        }

        private bool checkCorrect() {
            if (serviceName.Text.Length > 3) {
                if (description.Text.Length > 10) {
                    if (price.Value > 0) {
                        return true;
                    } else {
                        MessageBox.Show("Цена должна быть больше нуля!");
                        return false;
                    }
                } else {
                    MessageBox.Show("Описание должно быть больше 10 символов!");
                    return false;
                }
            } else {
                MessageBox.Show("Название услуги должно быть больше 3 символов!");
                return false;
            }
        }
    }
}
