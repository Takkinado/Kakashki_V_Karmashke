namespace ПК_сборка
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDКонфигурацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПокупателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDМенеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСборщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итоговаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database31DataSet = new ПК_сборка.Database31DataSet();
            this.заказыTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.ЗаказыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idКомплектующегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комплектующиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.комплектующиеTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.КомплектующиеTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idМенеджераDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.МенеджерыTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDПокупателяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресдоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.ПокупателиTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idСборщикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квалификацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сборщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сборщикиTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.СборщикиTableAdapter();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idДоставкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.трекНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.службаДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.служба_ДоставкиTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.Служба_ДоставкиTableAdapter();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.iDКонфигурацииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКомплектующегоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составКонфигаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состав_конфигаTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.Состав_конфигаTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.комплектующиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сборщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.службаДоставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составКонфигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сборщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.службаДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составКонфигаBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКонфигурацииDataGridViewTextBoxColumn,
            this.iDПокупателяDataGridViewTextBoxColumn,
            this.iDМенеджераDataGridViewTextBoxColumn,
            this.iDСборщикаDataGridViewTextBoxColumn,
            this.iDДоставкиDataGridViewTextBoxColumn,
            this.датасозданияDataGridViewTextBoxColumn,
            this.итоговаяСтоимостьDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDКонфигурацииDataGridViewTextBoxColumn
            // 
            this.iDКонфигурацииDataGridViewTextBoxColumn.DataPropertyName = "ID_Конфигурации";
            this.iDКонфигурацииDataGridViewTextBoxColumn.HeaderText = "ID_Конфигурации";
            this.iDКонфигурацииDataGridViewTextBoxColumn.Name = "iDКонфигурацииDataGridViewTextBoxColumn";
            // 
            // iDПокупателяDataGridViewTextBoxColumn
            // 
            this.iDПокупателяDataGridViewTextBoxColumn.DataPropertyName = "ID_Покупателя";
            this.iDПокупателяDataGridViewTextBoxColumn.HeaderText = "ID_Покупателя";
            this.iDПокупателяDataGridViewTextBoxColumn.Name = "iDПокупателяDataGridViewTextBoxColumn";
            // 
            // iDМенеджераDataGridViewTextBoxColumn
            // 
            this.iDМенеджераDataGridViewTextBoxColumn.DataPropertyName = "ID_Менеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.HeaderText = "ID_Менеджера";
            this.iDМенеджераDataGridViewTextBoxColumn.Name = "iDМенеджераDataGridViewTextBoxColumn";
            // 
            // iDСборщикаDataGridViewTextBoxColumn
            // 
            this.iDСборщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_Сборщика";
            this.iDСборщикаDataGridViewTextBoxColumn.HeaderText = "ID_Сборщика";
            this.iDСборщикаDataGridViewTextBoxColumn.Name = "iDСборщикаDataGridViewTextBoxColumn";
            // 
            // iDДоставкиDataGridViewTextBoxColumn
            // 
            this.iDДоставкиDataGridViewTextBoxColumn.DataPropertyName = "ID_Доставки";
            this.iDДоставкиDataGridViewTextBoxColumn.HeaderText = "ID_Доставки";
            this.iDДоставкиDataGridViewTextBoxColumn.Name = "iDДоставкиDataGridViewTextBoxColumn";
            // 
            // датасозданияDataGridViewTextBoxColumn
            // 
            this.датасозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.HeaderText = "Дата_создания";
            this.датасозданияDataGridViewTextBoxColumn.Name = "датасозданияDataGridViewTextBoxColumn";
            // 
            // итоговаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Итоговая_Стоимость";
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Итоговая_Стоимость";
            this.итоговаяСтоимостьDataGridViewTextBoxColumn.Name = "итоговаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.database31DataSet;
            // 
            // database31DataSet
            // 
            this.database31DataSet.DataSetName = "Database31DataSet";
            this.database31DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idКомплектующегоDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.названиеДеталиDataGridViewTextBoxColumn,
            this.характеристикиDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.комплектующиеBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView2.TabIndex = 1;
            // 
            // idКомплектующегоDataGridViewTextBoxColumn
            // 
            this.idКомплектующегоDataGridViewTextBoxColumn.DataPropertyName = "Id_Комплектующего";
            this.idКомплектующегоDataGridViewTextBoxColumn.HeaderText = "Id_Комплектующего";
            this.idКомплектующегоDataGridViewTextBoxColumn.Name = "idКомплектующегоDataGridViewTextBoxColumn";
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            // 
            // названиеДеталиDataGridViewTextBoxColumn
            // 
            this.названиеДеталиDataGridViewTextBoxColumn.DataPropertyName = "Название_Детали";
            this.названиеДеталиDataGridViewTextBoxColumn.HeaderText = "Название_Детали";
            this.названиеДеталиDataGridViewTextBoxColumn.Name = "названиеДеталиDataGridViewTextBoxColumn";
            // 
            // характеристикиDataGridViewTextBoxColumn
            // 
            this.характеристикиDataGridViewTextBoxColumn.DataPropertyName = "Характеристики";
            this.характеристикиDataGridViewTextBoxColumn.HeaderText = "Характеристики";
            this.характеристикиDataGridViewTextBoxColumn.Name = "характеристикиDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // комплектующиеBindingSource
            // 
            this.комплектующиеBindingSource.DataMember = "Комплектующие";
            this.комплектующиеBindingSource.DataSource = this.database31DataSet;
            // 
            // комплектующиеTableAdapter
            // 
            this.комплектующиеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idМенеджераDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.менеджерыBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 24);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView3.TabIndex = 2;
            // 
            // idМенеджераDataGridViewTextBoxColumn1
            // 
            this.idМенеджераDataGridViewTextBoxColumn1.DataPropertyName = "Id_Менеджера";
            this.idМенеджераDataGridViewTextBoxColumn1.HeaderText = "Id_Менеджера";
            this.idМенеджераDataGridViewTextBoxColumn1.Name = "idМенеджераDataGridViewTextBoxColumn1";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataMember = "Менеджеры";
            this.менеджерыBindingSource.DataSource = this.database31DataSet;
            // 
            // менеджерыTableAdapter
            // 
            this.менеджерыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПокупателяDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn1,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.адресдоставкиDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.покупателиBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 24);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView4.TabIndex = 3;
            // 
            // iDПокупателяDataGridViewTextBoxColumn1
            // 
            this.iDПокупателяDataGridViewTextBoxColumn1.DataPropertyName = "ID_Покупателя";
            this.iDПокупателяDataGridViewTextBoxColumn1.HeaderText = "ID_Покупателя";
            this.iDПокупателяDataGridViewTextBoxColumn1.Name = "iDПокупателяDataGridViewTextBoxColumn1";
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_Телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_Телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            // 
            // адресдоставкиDataGridViewTextBoxColumn
            // 
            this.адресдоставкиDataGridViewTextBoxColumn.DataPropertyName = "Адрес_доставки";
            this.адресдоставкиDataGridViewTextBoxColumn.HeaderText = "Адрес_доставки";
            this.адресдоставкиDataGridViewTextBoxColumn.Name = "адресдоставкиDataGridViewTextBoxColumn";
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.database31DataSet;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСборщикаDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn2,
            this.квалификацияDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.сборщикиBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 24);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView5.TabIndex = 4;
            // 
            // idСборщикаDataGridViewTextBoxColumn1
            // 
            this.idСборщикаDataGridViewTextBoxColumn1.DataPropertyName = "Id_Сборщика";
            this.idСборщикаDataGridViewTextBoxColumn1.HeaderText = "Id_Сборщика";
            this.idСборщикаDataGridViewTextBoxColumn1.Name = "idСборщикаDataGridViewTextBoxColumn1";
            // 
            // фИОDataGridViewTextBoxColumn2
            // 
            this.фИОDataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.Name = "фИОDataGridViewTextBoxColumn2";
            // 
            // квалификацияDataGridViewTextBoxColumn
            // 
            this.квалификацияDataGridViewTextBoxColumn.DataPropertyName = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.HeaderText = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.Name = "квалификацияDataGridViewTextBoxColumn";
            // 
            // сборщикиBindingSource
            // 
            this.сборщикиBindingSource.DataMember = "Сборщики";
            this.сборщикиBindingSource.DataSource = this.database31DataSet;
            // 
            // сборщикиTableAdapter
            // 
            this.сборщикиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idДоставкиDataGridViewTextBoxColumn1,
            this.тСDataGridViewTextBoxColumn,
            this.трекНомерDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.службаДоставкиBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(0, 24);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView6.TabIndex = 5;
            // 
            // idДоставкиDataGridViewTextBoxColumn1
            // 
            this.idДоставкиDataGridViewTextBoxColumn1.DataPropertyName = "Id_Доставки";
            this.idДоставкиDataGridViewTextBoxColumn1.HeaderText = "Id_Доставки";
            this.idДоставкиDataGridViewTextBoxColumn1.Name = "idДоставкиDataGridViewTextBoxColumn1";
            // 
            // тСDataGridViewTextBoxColumn
            // 
            this.тСDataGridViewTextBoxColumn.DataPropertyName = "ТС";
            this.тСDataGridViewTextBoxColumn.HeaderText = "ТС";
            this.тСDataGridViewTextBoxColumn.Name = "тСDataGridViewTextBoxColumn";
            // 
            // трекНомерDataGridViewTextBoxColumn
            // 
            this.трекНомерDataGridViewTextBoxColumn.DataPropertyName = "Трек_Номер";
            this.трекНомерDataGridViewTextBoxColumn.HeaderText = "Трек_Номер";
            this.трекНомерDataGridViewTextBoxColumn.Name = "трекНомерDataGridViewTextBoxColumn";
            // 
            // службаДоставкиBindingSource
            // 
            this.службаДоставкиBindingSource.DataMember = "Служба Доставки";
            this.службаДоставкиBindingSource.DataSource = this.database31DataSet;
            // 
            // служба_ДоставкиTableAdapter
            // 
            this.служба_ДоставкиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКонфигурацииDataGridViewTextBoxColumn1,
            this.iDКомплектующегоDataGridViewTextBoxColumn1,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.составКонфигаBindingSource;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(0, 24);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(1411, 426);
            this.dataGridView7.TabIndex = 6;
            // 
            // iDКонфигурацииDataGridViewTextBoxColumn1
            // 
            this.iDКонфигурацииDataGridViewTextBoxColumn1.DataPropertyName = "ID_Конфигурации";
            this.iDКонфигурацииDataGridViewTextBoxColumn1.HeaderText = "ID_Конфигурации";
            this.iDКонфигурацииDataGridViewTextBoxColumn1.Name = "iDКонфигурацииDataGridViewTextBoxColumn1";
            // 
            // iDКомплектующегоDataGridViewTextBoxColumn1
            // 
            this.iDКомплектующегоDataGridViewTextBoxColumn1.DataPropertyName = "ID_Комплектующего";
            this.iDКомплектующегоDataGridViewTextBoxColumn1.HeaderText = "ID_Комплектующего";
            this.iDКомплектующегоDataGridViewTextBoxColumn1.Name = "iDКомплектующегоDataGridViewTextBoxColumn1";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // составКонфигаBindingSource
            // 
            this.составКонфигаBindingSource.DataMember = "Состав конфига";
            this.составКонфигаBindingSource.DataSource = this.database31DataSet;
            // 
            // состав_конфигаTableAdapter
            // 
            this.состав_конфигаTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.комплектующиеToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1411, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // комплектующиеToolStripMenuItem
            // 
            this.комплектующиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менеджерыToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.менеджерыToolStripMenuItem1,
            this.сборщикиToolStripMenuItem,
            this.службаДоставкиToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.составКонфигаToolStripMenuItem});
            this.комплектующиеToolStripMenuItem.Name = "комплектующиеToolStripMenuItem";
            this.комплектующиеToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.комплектующиеToolStripMenuItem.Text = "Таблицы";
            this.комплектующиеToolStripMenuItem.Click += new System.EventHandler(this.комплектующиеToolStripMenuItem_Click);
            // 
            // менеджерыToolStripMenuItem
            // 
            this.менеджерыToolStripMenuItem.Name = "менеджерыToolStripMenuItem";
            this.менеджерыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.менеджерыToolStripMenuItem.Text = "Заказы";
            this.менеджерыToolStripMenuItem.Click += new System.EventHandler(this.менеджерыToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупателиToolStripMenuItem.Text = "Комплектующие";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // Reinforced hookup (no-op)
            // 
            // 
            // сборщикиToolStripMenuItem
            // 
            this.сборщикиToolStripMenuItem.Name = "сборщикиToolStripMenuItem";
            this.сборщикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сборщикиToolStripMenuItem.Text = "Покупатели";
            this.сборщикиToolStripMenuItem.Click += new System.EventHandler(this.сборщикиToolStripMenuItem_Click);
            // 
            // службаДоставкиToolStripMenuItem
            // 
            this.службаДоставкиToolStripMenuItem.Name = "службаДоставкиToolStripMenuItem";
            this.службаДоставкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.службаДоставкиToolStripMenuItem.Text = "Сборщики";
            this.службаДоставкиToolStripMenuItem.Click += new System.EventHandler(this.службаДоставкиToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заказыToolStripMenuItem.Text = "Служба Доставки";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // составКонфигаToolStripMenuItem
            // 
            this.составКонфигаToolStripMenuItem.Name = "составКонфигаToolStripMenuItem";
            this.составКонфигаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.составКонфигаToolStripMenuItem.Text = "Состав Конфига";
            this.составКонфигаToolStripMenuItem.Click += new System.EventHandler(this.составКонфигаToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // менеджерыToolStripMenuItem1
            // 
            this.менеджерыToolStripMenuItem1.Name = "менеджерыToolStripMenuItem1";
            this.менеджерыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.менеджерыToolStripMenuItem1.Text = "Менеджеры";
            this.менеджерыToolStripMenuItem1.Click += new System.EventHandler(this.менеджерыToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 450);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.комплектующиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сборщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.службаДоставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составКонфигаBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database31DataSet database31DataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Database31DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКонфигурацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПокупателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDМенеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСборщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итоговаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource комплектующиеBindingSource;
        private Database31DataSetTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКомплектующегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private Database31DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idМенеджераDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private Database31DataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПокупателяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресдоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource сборщикиBindingSource;
        private Database31DataSetTableAdapters.СборщикиTableAdapter сборщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСборщикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn квалификацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource службаДоставкиBindingSource;
        private Database31DataSetTableAdapters.Служба_ДоставкиTableAdapter служба_ДоставкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДоставкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn тСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn трекНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource составКонфигаBindingSource;
        private Database31DataSetTableAdapters.Состав_конфигаTableAdapter состав_конфигаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКонфигурацииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКомплектующегоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem комплектующиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сборщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem службаДоставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составКонфигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem1;
    }
}

