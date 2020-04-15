using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency_Price_List
{
    public partial class MainWindow : Form {

        private DataBase dataBase = DataBase.getInstance();
        private Service deletable;

        public MainWindow() {
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

            // Обработка события "Двойной клик по ячейке DataGridView"
            data.CellDoubleClick += Data_CellDoubleClick;

            // Кнопка "Обзор"
            chooseButton.Click += ChooseButton_Click;

            // Кнопка "Открыть"
            openButton.Click += OpenButton_Click;

            // Кнопка "Сохранить"
            saveButton.Click += SaveButton_Click;

            // Кнопка "Добавить/изменить запись"
            formButton.Click += FormButton_Click;

            // Кнопка "Удалить"
            deleteButton.Click += DeleteButton_Click;

            // Кнопка "Очистить удаляемый элемент"
            clearDeletableButton.Click += ClearDeletableButton_Click;

            // Попытка открытия файла по умолчанию в начале программы (событие на первое отображение формы)
            this.Shown += MainWindow_Shown;
        }

        private void MainWindow_Shown(object sender, EventArgs e) {
            tryOpen();
        }

        private void ClearDeletableButton_Click(object sender, EventArgs e) {
            deletable = null;
            status.Text = "Удаляемого элемента нет!";
        }

        private void Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            readyToDelete(e);
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            delete();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            dataBase.saveData();
            dataBase.loadData();
        }

        private void FormButton_Click(object sender, EventArgs e) {
            new AddWindow().Show();
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            if (dataBase.loadData()) {
                MessageBox.Show("Файл " + dataBase.Path + " был успешно открыт и прочитан!");
            } else {
                MessageBox.Show("Некорректные данные внутри файла, либо не удалось найти такой файл!");
            }
        }

        private void tryOpen() {
            if (File.Exists(dataBase.Path)) {
                if (dataBase.loadData()) {
                    MessageBox.Show("Файл " + dataBase.Path + " был найден и загружен! Также можно вручную выбрать другой файл и открыть его!");
                } else {
                    MessageBox.Show("Файл " + dataBase.Path + " имеет некорректные данные! Выберите другой исполяемый файл!");
                }
            } else {
                File.Create(dataBase.Path).Close();
                dataBase.loadData();

                MessageBox.Show("Файл " + dataBase.Path + " не был найден, поэтому был автоматически создан в каталоге с исполняемым файлом и загружен.");
            } pathTextBox.Text = dataBase.Path;
        }

        private void ChooseButton_Click(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                dataBase.Path = fileDialog.FileName;
                pathTextBox.Text = dataBase.Path;
            }
        }

        private void readyToDelete(DataGridViewCellEventArgs e) {
            deletable = new Service
                (
                    Convert.ToInt32(data.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    data.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    data.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Convert.ToDouble(data.Rows[e.RowIndex].Cells[3].Value.ToString())
                );

            status.Text = "Элемент готов к удалению!";
        }

        private void delete() {
            if (deletable != null) {
                dataBase.deleteData(deletable);
                dataBase.saveData();
                dataBase.loadData();

                deletable = null;
                status.Text = "Удаляемого элемента нет!";
            } else {
                MessageBox.Show("Сначала воспользутесь поиском и найдите элемент (двойной щелчок по записи в таблице)!");
            }
        }
    }
}
