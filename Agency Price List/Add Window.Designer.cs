namespace Agency_Price_List
{
    partial class AddWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nameTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupTSLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.serviceNameFind = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.nameServiceLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip.TabIndex = 2;
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
            // mainLabel
            // 
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(810, 105);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Добавление/изменение услуг рекламного агенства";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 54);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(181, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(21, 84);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(181, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Location = new System.Drawing.Point(12, 167);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(574, 266);
            this.data.TabIndex = 6;
            // 
            // serviceNameFind
            // 
            this.serviceNameFind.Location = new System.Drawing.Point(12, 117);
            this.serviceNameFind.Name = "serviceNameFind";
            this.serviceNameFind.Size = new System.Drawing.Size(190, 20);
            this.serviceNameFind.TabIndex = 7;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findLabel.Location = new System.Drawing.Point(208, 118);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(196, 15);
            this.findLabel.TabIndex = 8;
            this.findLabel.Text = "<- ПОИСК ПО НАЗВАНИЮ УСЛУГИ";
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(311, 56);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(193, 20);
            this.serviceName.TabIndex = 9;
            // 
            // nameServiceLabel
            // 
            this.nameServiceLabel.AutoSize = true;
            this.nameServiceLabel.Location = new System.Drawing.Point(208, 59);
            this.nameServiceLabel.Name = "nameServiceLabel";
            this.nameServiceLabel.Size = new System.Drawing.Size(97, 13);
            this.nameServiceLabel.TabIndex = 10;
            this.nameServiceLabel.Text = "Название услуги";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(629, 56);
            this.description.MaxLength = 512;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(193, 182);
            this.description.TabIndex = 11;
            this.description.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(526, 59);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(97, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Описание услуги";
            // 
            // price
            // 
            this.price.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(629, 244);
            this.price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(193, 20);
            this.price.TabIndex = 13;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(592, 246);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Цена";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(595, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(227, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(286, 89);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 13);
            this.id.TabIndex = 16;
            this.id.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(311, 86);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.id);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nameServiceLabel);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.serviceNameFind);
            this.Controls.Add(this.data);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "AddWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/изменение записи";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel nameTSLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel groupTSLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox serviceNameFind;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.Label nameServiceLabel;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idTextBox;
    }
}