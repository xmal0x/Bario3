namespace bario3
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelScanPosition = new System.Windows.Forms.Panel();
            this.labelScanposition = new System.Windows.Forms.Label();
            this.labelSerialScan = new System.Windows.Forms.Label();
            this.labelWeightScan = new System.Windows.Forms.Label();
            this.textBoxSerialScan = new System.Windows.Forms.TextBox();
            this.textBoxWeightScan = new System.Windows.Forms.TextBox();
            this.buttonScanPosition = new System.Windows.Forms.Button();
            this.dataGridViewStorage = new System.Windows.Forms.DataGridView();
            this.panelAddPosition = new System.Windows.Forms.Panel();
            this.labelAddPosition = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddSerial = new System.Windows.Forms.Label();
            this.labelAddType = new System.Windows.Forms.Label();
            this.labelAddWeightFull = new System.Windows.Forms.Label();
            this.labelAddWeightEmpty = new System.Windows.Forms.Label();
            this.labelAddWeightNow = new System.Windows.Forms.Label();
            this.labelAddCapacityFull = new System.Windows.Forms.Label();
            this.labelAddCapacityNow = new System.Windows.Forms.Label();
            this.labelAddPrice = new System.Windows.Forms.Label();
            this.labelAddSize = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddSerial = new System.Windows.Forms.TextBox();
            this.textBoxAddType = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightFull = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightEmpty = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightNow = new System.Windows.Forms.TextBox();
            this.textBoxAddCapacityFull = new System.Windows.Forms.TextBox();
            this.textBoxAddCapacityNow = new System.Windows.Forms.TextBox();
            this.textBoxAddPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddSize = new System.Windows.Forms.TextBox();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelScanPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).BeginInit();
            this.panelAddPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelScanPosition);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Инвентаризация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelAddPosition);
            this.tabPage3.Controls.Add(this.dataGridViewStorage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1154, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "БД наименований";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.buttonConnect);
            this.panelMain.Location = new System.Drawing.Point(924, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(224, 130);
            this.panelMain.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(113, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(108, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(113, 32);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 628);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelScanPosition
            // 
            this.panelScanPosition.Controls.Add(this.buttonScanPosition);
            this.panelScanPosition.Controls.Add(this.textBoxWeightScan);
            this.panelScanPosition.Controls.Add(this.textBoxSerialScan);
            this.panelScanPosition.Controls.Add(this.labelWeightScan);
            this.panelScanPosition.Controls.Add(this.labelSerialScan);
            this.panelScanPosition.Controls.Add(this.labelScanposition);
            this.panelScanPosition.Location = new System.Drawing.Point(844, 7);
            this.panelScanPosition.Name = "panelScanPosition";
            this.panelScanPosition.Size = new System.Drawing.Size(304, 117);
            this.panelScanPosition.TabIndex = 1;
            // 
            // labelScanposition
            // 
            this.labelScanposition.AutoSize = true;
            this.labelScanposition.Location = new System.Drawing.Point(16, 14);
            this.labelScanposition.Name = "labelScanposition";
            this.labelScanposition.Size = new System.Drawing.Size(123, 13);
            this.labelScanposition.TabIndex = 0;
            this.labelScanposition.Text = "Сканировать позицию:";
            // 
            // labelSerialScan
            // 
            this.labelSerialScan.AutoSize = true;
            this.labelSerialScan.Location = new System.Drawing.Point(31, 37);
            this.labelSerialScan.Name = "labelSerialScan";
            this.labelSerialScan.Size = new System.Drawing.Size(59, 13);
            this.labelSerialScan.TabIndex = 1;
            this.labelSerialScan.Text = "Серийник:";
            // 
            // labelWeightScan
            // 
            this.labelWeightScan.AutoSize = true;
            this.labelWeightScan.Location = new System.Drawing.Point(16, 60);
            this.labelWeightScan.Name = "labelWeightScan";
            this.labelWeightScan.Size = new System.Drawing.Size(74, 13);
            this.labelWeightScan.TabIndex = 2;
            this.labelWeightScan.Text = "Вес позиции:";
            // 
            // textBoxSerialScan
            // 
            this.textBoxSerialScan.Location = new System.Drawing.Point(96, 34);
            this.textBoxSerialScan.Name = "textBoxSerialScan";
            this.textBoxSerialScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialScan.TabIndex = 3;
            // 
            // textBoxWeightScan
            // 
            this.textBoxWeightScan.Location = new System.Drawing.Point(96, 57);
            this.textBoxWeightScan.Name = "textBoxWeightScan";
            this.textBoxWeightScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightScan.TabIndex = 4;
            // 
            // buttonScanPosition
            // 
            this.buttonScanPosition.Location = new System.Drawing.Point(96, 83);
            this.buttonScanPosition.Name = "buttonScanPosition";
            this.buttonScanPosition.Size = new System.Drawing.Size(100, 23);
            this.buttonScanPosition.TabIndex = 5;
            this.buttonScanPosition.Text = "Сканировать";
            this.buttonScanPosition.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStorage
            // 
            this.dataGridViewStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorage.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewStorage.Name = "dataGridViewStorage";
            this.dataGridViewStorage.Size = new System.Drawing.Size(810, 634);
            this.dataGridViewStorage.TabIndex = 0;
            // 
            // panelAddPosition
            // 
            this.panelAddPosition.Controls.Add(this.buttonAddPosition);
            this.panelAddPosition.Controls.Add(this.textBoxAddSize);
            this.panelAddPosition.Controls.Add(this.textBoxAddPrice);
            this.panelAddPosition.Controls.Add(this.textBoxAddCapacityNow);
            this.panelAddPosition.Controls.Add(this.textBoxAddCapacityFull);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightNow);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightEmpty);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightFull);
            this.panelAddPosition.Controls.Add(this.textBoxAddType);
            this.panelAddPosition.Controls.Add(this.textBoxAddSerial);
            this.panelAddPosition.Controls.Add(this.textBoxAddName);
            this.panelAddPosition.Controls.Add(this.labelAddSize);
            this.panelAddPosition.Controls.Add(this.labelAddPrice);
            this.panelAddPosition.Controls.Add(this.labelAddCapacityNow);
            this.panelAddPosition.Controls.Add(this.labelAddCapacityFull);
            this.panelAddPosition.Controls.Add(this.labelAddWeightNow);
            this.panelAddPosition.Controls.Add(this.labelAddWeightEmpty);
            this.panelAddPosition.Controls.Add(this.labelAddWeightFull);
            this.panelAddPosition.Controls.Add(this.labelAddType);
            this.panelAddPosition.Controls.Add(this.labelAddSerial);
            this.panelAddPosition.Controls.Add(this.labelAddName);
            this.panelAddPosition.Controls.Add(this.labelAddPosition);
            this.panelAddPosition.Location = new System.Drawing.Point(821, 4);
            this.panelAddPosition.Name = "panelAddPosition";
            this.panelAddPosition.Size = new System.Drawing.Size(330, 339);
            this.panelAddPosition.TabIndex = 1;
            // 
            // labelAddPosition
            // 
            this.labelAddPosition.AutoSize = true;
            this.labelAddPosition.Location = new System.Drawing.Point(4, 4);
            this.labelAddPosition.Name = "labelAddPosition";
            this.labelAddPosition.Size = new System.Drawing.Size(155, 13);
            this.labelAddPosition.TabIndex = 0;
            this.labelAddPosition.Text = "Добавить позицию на склад:";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(4, 31);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(60, 13);
            this.labelAddName.TabIndex = 1;
            this.labelAddName.Text = "Название:";
            // 
            // labelAddSerial
            // 
            this.labelAddSerial.AutoSize = true;
            this.labelAddSerial.Location = new System.Drawing.Point(4, 56);
            this.labelAddSerial.Name = "labelAddSerial";
            this.labelAddSerial.Size = new System.Drawing.Size(59, 13);
            this.labelAddSerial.TabIndex = 2;
            this.labelAddSerial.Text = "Серийник:";
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.Location = new System.Drawing.Point(4, 81);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(29, 13);
            this.labelAddType.TabIndex = 3;
            this.labelAddType.Text = "Тип:";
            // 
            // labelAddWeightFull
            // 
            this.labelAddWeightFull.AutoSize = true;
            this.labelAddWeightFull.Location = new System.Drawing.Point(4, 108);
            this.labelAddWeightFull.Name = "labelAddWeightFull";
            this.labelAddWeightFull.Size = new System.Drawing.Size(132, 13);
            this.labelAddWeightFull.TabIndex = 4;
            this.labelAddWeightFull.Text = "Вес полной бутылки, мг:";
            // 
            // labelAddWeightEmpty
            // 
            this.labelAddWeightEmpty.AutoSize = true;
            this.labelAddWeightEmpty.Location = new System.Drawing.Point(4, 133);
            this.labelAddWeightEmpty.Name = "labelAddWeightEmpty";
            this.labelAddWeightEmpty.Size = new System.Drawing.Size(130, 13);
            this.labelAddWeightEmpty.TabIndex = 5;
            this.labelAddWeightEmpty.Text = "Вес пустой бутылки, мг:";
            // 
            // labelAddWeightNow
            // 
            this.labelAddWeightNow.AutoSize = true;
            this.labelAddWeightNow.Location = new System.Drawing.Point(3, 156);
            this.labelAddWeightNow.Name = "labelAddWeightNow";
            this.labelAddWeightNow.Size = new System.Drawing.Size(95, 13);
            this.labelAddWeightNow.TabIndex = 6;
            this.labelAddWeightNow.Text = "Текущий вес, мг:";
            // 
            // labelAddCapacityFull
            // 
            this.labelAddCapacityFull.AutoSize = true;
            this.labelAddCapacityFull.Location = new System.Drawing.Point(3, 181);
            this.labelAddCapacityFull.Name = "labelAddCapacityFull";
            this.labelAddCapacityFull.Size = new System.Drawing.Size(148, 13);
            this.labelAddCapacityFull.TabIndex = 7;
            this.labelAddCapacityFull.Text = "Обьем полной бутылки, мл:";
            // 
            // labelAddCapacityNow
            // 
            this.labelAddCapacityNow.AutoSize = true;
            this.labelAddCapacityNow.Location = new System.Drawing.Point(4, 208);
            this.labelAddCapacityNow.Name = "labelAddCapacityNow";
            this.labelAddCapacityNow.Size = new System.Drawing.Size(110, 13);
            this.labelAddCapacityNow.TabIndex = 8;
            this.labelAddCapacityNow.Text = "Текущий обьем, мл:";
            // 
            // labelAddPrice
            // 
            this.labelAddPrice.AutoSize = true;
            this.labelAddPrice.Location = new System.Drawing.Point(4, 236);
            this.labelAddPrice.Name = "labelAddPrice";
            this.labelAddPrice.Size = new System.Drawing.Size(115, 13);
            this.labelAddPrice.TabIndex = 9;
            this.labelAddPrice.Text = "Цена за порцию, руб:";
            // 
            // labelAddSize
            // 
            this.labelAddSize.AutoSize = true;
            this.labelAddSize.Location = new System.Drawing.Point(4, 263);
            this.labelAddSize.Name = "labelAddSize";
            this.labelAddSize.Size = new System.Drawing.Size(108, 13);
            this.labelAddSize.TabIndex = 10;
            this.labelAddSize.Text = "Размер порции, мл:";
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(149, 28);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddName.TabIndex = 11;
            // 
            // textBoxAddSerial
            // 
            this.textBoxAddSerial.Location = new System.Drawing.Point(149, 53);
            this.textBoxAddSerial.Name = "textBoxAddSerial";
            this.textBoxAddSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSerial.TabIndex = 12;
            // 
            // textBoxAddType
            // 
            this.textBoxAddType.Location = new System.Drawing.Point(149, 78);
            this.textBoxAddType.Name = "textBoxAddType";
            this.textBoxAddType.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddType.TabIndex = 13;
            // 
            // textBoxAddWeightFull
            // 
            this.textBoxAddWeightFull.Location = new System.Drawing.Point(149, 105);
            this.textBoxAddWeightFull.Name = "textBoxAddWeightFull";
            this.textBoxAddWeightFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightFull.TabIndex = 14;
            // 
            // textBoxAddWeightEmpty
            // 
            this.textBoxAddWeightEmpty.Location = new System.Drawing.Point(149, 130);
            this.textBoxAddWeightEmpty.Name = "textBoxAddWeightEmpty";
            this.textBoxAddWeightEmpty.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightEmpty.TabIndex = 15;
            // 
            // textBoxAddWeightNow
            // 
            this.textBoxAddWeightNow.Location = new System.Drawing.Point(149, 153);
            this.textBoxAddWeightNow.Name = "textBoxAddWeightNow";
            this.textBoxAddWeightNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightNow.TabIndex = 16;
            // 
            // textBoxAddCapacityFull
            // 
            this.textBoxAddCapacityFull.Location = new System.Drawing.Point(149, 178);
            this.textBoxAddCapacityFull.Name = "textBoxAddCapacityFull";
            this.textBoxAddCapacityFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCapacityFull.TabIndex = 17;
            // 
            // textBoxAddCapacityNow
            // 
            this.textBoxAddCapacityNow.Location = new System.Drawing.Point(149, 205);
            this.textBoxAddCapacityNow.Name = "textBoxAddCapacityNow";
            this.textBoxAddCapacityNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCapacityNow.TabIndex = 18;
            // 
            // textBoxAddPrice
            // 
            this.textBoxAddPrice.Location = new System.Drawing.Point(149, 233);
            this.textBoxAddPrice.Name = "textBoxAddPrice";
            this.textBoxAddPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPrice.TabIndex = 19;
            // 
            // textBoxAddSize
            // 
            this.textBoxAddSize.Location = new System.Drawing.Point(149, 260);
            this.textBoxAddSize.Name = "textBoxAddSize";
            this.textBoxAddSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSize.TabIndex = 20;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(149, 287);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(100, 38);
            this.buttonAddPosition.TabIndex = 21;
            this.buttonAddPosition.Text = "Добавить позицию";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 691);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bario3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelScanPosition.ResumeLayout(false);
            this.panelScanPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).EndInit();
            this.panelAddPosition.ResumeLayout(false);
            this.panelAddPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelScanPosition;
        private System.Windows.Forms.Button buttonScanPosition;
        private System.Windows.Forms.TextBox textBoxWeightScan;
        private System.Windows.Forms.TextBox textBoxSerialScan;
        private System.Windows.Forms.Label labelWeightScan;
        private System.Windows.Forms.Label labelSerialScan;
        private System.Windows.Forms.Label labelScanposition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelAddPosition;
        private System.Windows.Forms.Button buttonAddPosition;
        private System.Windows.Forms.TextBox textBoxAddSize;
        private System.Windows.Forms.TextBox textBoxAddPrice;
        private System.Windows.Forms.TextBox textBoxAddCapacityNow;
        private System.Windows.Forms.TextBox textBoxAddCapacityFull;
        private System.Windows.Forms.TextBox textBoxAddWeightNow;
        private System.Windows.Forms.TextBox textBoxAddWeightEmpty;
        private System.Windows.Forms.TextBox textBoxAddWeightFull;
        private System.Windows.Forms.TextBox textBoxAddType;
        private System.Windows.Forms.TextBox textBoxAddSerial;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Label labelAddSize;
        private System.Windows.Forms.Label labelAddPrice;
        private System.Windows.Forms.Label labelAddCapacityNow;
        private System.Windows.Forms.Label labelAddCapacityFull;
        private System.Windows.Forms.Label labelAddWeightNow;
        private System.Windows.Forms.Label labelAddWeightEmpty;
        private System.Windows.Forms.Label labelAddWeightFull;
        private System.Windows.Forms.Label labelAddType;
        private System.Windows.Forms.Label labelAddSerial;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Label labelAddPosition;
        private System.Windows.Forms.DataGridView dataGridViewStorage;
    }
}

