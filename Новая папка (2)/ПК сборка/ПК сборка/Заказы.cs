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
    public partial class Заказы : Form
    {
        private Database31DataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter = new Database31DataSetTableAdapters.ЗаказыTableAdapter();

        public Заказы()
        {
            InitializeComponent();
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

        private void менеджерыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(this.textBox2.Text, out var idConfig) ||
                    !int.TryParse(this.textBox3.Text, out var idBuyer) ||
                    !int.TryParse(this.textBox4.Text, out var idManager) ||
                    !int.TryParse(this.textBox5.Text, out var idBuilder) ||
                    !int.TryParse(this.textBox6.Text, out var idDelivery))
                {
                    MessageBox.Show("Введите корректные числовые идентификаторы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(this.textBox1.Text, out var totalCost))
                {
                    MessageBox.Show("Введите корректную итоговую стоимость.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int updated = this.заказыTableAdapter.Insert(
                    idConfig,
                    idBuyer,
                    idManager,
                    idBuilder,
                    idDelivery,
                    this.dateTimePicker1.Value,
                    totalCost,
                    "Новый");

                MessageBox.Show($"Сохранено записей: {updated}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (mainForm != null) mainForm.RefreshAllTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
