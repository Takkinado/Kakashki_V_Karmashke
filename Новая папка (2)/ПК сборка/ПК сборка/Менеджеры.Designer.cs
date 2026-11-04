namespace ПК_сборка
{
    partial class Менеджеры
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.комплектующиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менеджерыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сборщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.службаДоставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составКонфигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.database31DataSet = new ПК_сборка.Database31DataSet();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter = new ПК_сборка.Database31DataSetTableAdapters.МенеджерыTableAdapter();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_менеджера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "роль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менеджерыBindingSource, "Id_Менеджера", true));
            this.textBox1.Location = new System.Drawing.Point(270, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менеджерыBindingSource, "ФИО", true));
            this.textBox2.Location = new System.Drawing.Point(270, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.менеджерыBindingSource, "Роль", true));
            this.textBox3.Location = new System.Drawing.Point(270, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.комплектующиеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(407, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
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
            this.комплектующиеToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.комплектующиеToolStripMenuItem.Text = "Перейти К";
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
            // 
            // менеджерыToolStripMenuItem1
            // 
            this.менеджерыToolStripMenuItem1.Name = "менеджерыToolStripMenuItem1";
            this.менеджерыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.менеджерыToolStripMenuItem1.Text = "Менеджеры";
            this.менеджерыToolStripMenuItem1.Click += new System.EventHandler(this.менеджерыToolStripMenuItem1_Click);
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
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // database31DataSet
            // 
            this.database31DataSet.DataSetName = "Database31DataSet";
            this.database31DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Менеджеры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Менеджеры";
            this.Text = "Менеждеры";
            this.Load += new System.EventHandler(this.Менеджеры_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem комплектующиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менеджерыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сборщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem службаДоставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составКонфигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private Database31DataSet database31DataSet;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private Database31DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
    }
}