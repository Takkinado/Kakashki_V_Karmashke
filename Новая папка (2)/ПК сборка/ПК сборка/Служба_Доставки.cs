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
    public partial class Служба_Доставки : Form
    {
        private Database31DataSet database31DataSet = new Database31DataSet();
        private Database31DataSetTableAdapters.Служба_ДоставкиTableAdapter служба_ДоставкиTableAdapter = new Database31DataSetTableAdapters.Служба_ДоставкиTableAdapter();

        public Служба_Доставки()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int updated = this.служба_ДоставкиTableAdapter.Insert(
                    string.IsNullOrWhiteSpace(this.textBox2.Text) ? null : this.textBox2.Text,
                    string.IsNullOrWhiteSpace(this.textBox3.Text) ? null : this.textBox3.Text);
                MessageBox.Show($"Сохранено записей: {updated}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm != null) mainForm.RefreshAllTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Заказы f3 = new Заказы();
            f3.Show();
            this.Close();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Комплектующие f4 = new Комплектующие();
            f4.Show();
            this.Close();
        }

        private void менеджерыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Менеджеры f5 = new Менеджеры();
            f5.Show();
            this.Close();
        }

        private void сборщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Покупатели f6 = new Покупатели();
            f6.Show();
            this.Close();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Служба_Доставки f8 = new Служба_Доставки();
            f8.Show();
            this.Close();
        }

        private void службаДоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сборщики f3 = new Сборщики();
            f3.Show();
            this.Close();
        }

        private void составКонфигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Состав_Конфига f7 = new Состав_Конфига();
            f7.Show();
            this.Close();
        }
    }
}
