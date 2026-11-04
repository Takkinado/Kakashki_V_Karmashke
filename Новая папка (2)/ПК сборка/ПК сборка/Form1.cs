using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПК_сборка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Expose DataSet and TableAdapters for other forms to use the same connection/instance
        public Database31DataSet DatabaseInstance => this.database31DataSet;
        public Database31DataSetTableAdapters.МенеджерыTableAdapter МенеджерыAdapter => this.менеджерыTableAdapter;
        public Database31DataSetTableAdapters.ПокупателиTableAdapter ПокупателиAdapter => this.покупателиTableAdapter;
        public Database31DataSetTableAdapters.КомплектующиеTableAdapter КомплектующиеAdapter => this.комплектующиеTableAdapter;
        public Database31DataSetTableAdapters.СборщикиTableAdapter СборщикиAdapter => this.сборщикиTableAdapter;
        public Database31DataSetTableAdapters.Служба_ДоставкиTableAdapter СлужбаДоставкиAdapter => this.служба_ДоставкиTableAdapter;
        public Database31DataSetTableAdapters.Состав_конфигаTableAdapter СоставКонфигаAdapter => this.состав_конфигаTableAdapter;
        public Database31DataSetTableAdapters.ЗаказыTableAdapter ЗаказыAdapter => this.заказыTableAdapter;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Состав_конфига". При необходимости она может быть перемещена или удалена.
            this.состав_конфигаTableAdapter.Fill(this.database31DataSet.Состав_конфига);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Служба_Доставки". При необходимости она может быть перемещена или удалена.
            this.служба_ДоставкиTableAdapter.Fill(this.database31DataSet.Служба_Доставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Сборщики". При необходимости она может быть перемещена или удалена.
            this.сборщикиTableAdapter.Fill(this.database31DataSet.Сборщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.database31DataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.database31DataSet.Менеджеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.database31DataSet.Комплектующие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database31DataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.database31DataSet.Заказы);

        }

        // Обновить все таблицы на главной форме
        public void RefreshAllTables()
        {
            this.состав_конфигаTableAdapter.Fill(this.database31DataSet.Состав_конфига);
            this.служба_ДоставкиTableAdapter.Fill(this.database31DataSet.Служба_Доставки);
            this.сборщикиTableAdapter.Fill(this.database31DataSet.Сборщики);
            this.покупателиTableAdapter.Fill(this.database31DataSet.Покупатели);
            this.менеджерыTableAdapter.Fill(this.database31DataSet.Менеджеры);
            this.комплектующиеTableAdapter.Fill(this.database31DataSet.Комплектующие);
            this.заказыTableAdapter.Fill(this.database31DataSet.Заказы);
        }

        private void комплектующиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Close(); 
        }

        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;

        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
        }

        private void сборщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
        }

        private void службаДоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = true;
            dataGridView7.Visible = false;
        }

        private void менеджерыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = false;
        }

        private void составКонфигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            dataGridView7.Visible = true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Менеджеры f2 = new Менеджеры();
            f2.Show();
        }
    }
}
