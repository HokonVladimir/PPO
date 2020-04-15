namespace Agency_Price_List
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nameTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.data = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.formButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.chooseButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.status = new System.Windows.Forms.TextBox();
            this.clearDeletableButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(822, 77);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Рекламное агентсво. Прайс-лист.";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Enabled = false;
            this.toolStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameTSLabel,
            this.toolStripSeparator1,
            this.groupTSLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 436);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(834, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // nameTSLabel
            // 
            this.nameTSLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTSLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.nameTSLabel.Name = "nameTSLabel";
            this.nameTSLabel.Size = new System.Drawing.Size(77, 22);
            this.nameTSLabel.Text = "Хокон В.В.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupTSLabel
            // 
            this.groupTSLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTSLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupTSLabel.Name = "groupTSLabel";
            this.groupTSLabel.Size = new System.Drawing.Size(63, 22);
            this.groupTSLabel.Text = "ПКсп-117";
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 157);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(810, 276);
            this.data.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(641, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(21, 42);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(181, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(21, 13);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(181, 23);
            this.formButton.TabIndex = 5;
            this.formButton.Text = "Добавление/изменение записи";
            this.formButton.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 88);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(565, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(12, 114);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(181, 23);
            this.chooseButton.TabIndex = 7;
            this.chooseButton.Text = "Обзор...";
            this.chooseButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(199, 114);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(181, 23);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLabel.Location = new System.Drawing.Point(583, 89);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(56, 15);
            this.pathLabel.TabIndex = 9;
            this.pathLabel.Text = "<- ПУТЬ";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.Filter = "|*.txt";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Location = new System.Drawing.Point(208, 44);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(222, 20);
            this.status.TabIndex = 10;
            this.status.Text = "Удаляемого элемента нет!";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearDeletableButton
            // 
            this.clearDeletableButton.Location = new System.Drawing.Point(386, 114);
            this.clearDeletableButton.Name = "clearDeletableButton";
            this.clearDeletableButton.Size = new System.Drawing.Size(181, 23);
            this.clearDeletableButton.TabIndex = 11;
            this.clearDeletableButton.Text = "Очистить удаляемый элемент";
            this.clearDeletableButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.clearDeletableButton);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.data);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel nameTSLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel groupTSLabel;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button clearDeletableButton;
    }
}

