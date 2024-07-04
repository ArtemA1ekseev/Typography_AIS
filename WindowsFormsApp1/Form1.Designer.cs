
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сосToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыЗаказчиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованияПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видПечатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыОплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляДизайнераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.макетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеГотовностиЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбчатаяДиаграмма1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбчатаяДиаграмма2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОГотовыхЗаказахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реквизитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузкаПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.основнаяИнформацияToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.AutoToolTip = true;
            this.справочникиToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сосToolStripMenuItem,
            this.видыЗаказчиковToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.наименованияПродукцииToolStripMenuItem,
            this.видПечатиToolStripMenuItem,
            this.материалыToolStripMenuItem,
            this.видыОплатыToolStripMenuItem,
            this.дляДизайнераToolStripMenuItem,
            this.продукцияToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.состояниеГотовностиЗаказаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники и Учёт";
            this.справочникиToolStripMenuItem.ToolTipText = "Основные тблицы базы данных";
            // 
            // сосToolStripMenuItem
            // 
            this.сосToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.sos_zakaza;
            this.сосToolStripMenuItem.Name = "сосToolStripMenuItem";
            this.сосToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.сосToolStripMenuItem.Text = "Состояние заказов";
            this.сосToolStripMenuItem.Click += new System.EventHandler(this.сосToolStripMenuItem_Click);
            // 
            // видыЗаказчиковToolStripMenuItem
            // 
            this.видыЗаказчиковToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.zakazchik;
            this.видыЗаказчиковToolStripMenuItem.Name = "видыЗаказчиковToolStripMenuItem";
            this.видыЗаказчиковToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.видыЗаказчиковToolStripMenuItem.Text = "Виды заказчиков";
            this.видыЗаказчиковToolStripMenuItem.Click += new System.EventHandler(this.видыЗаказчиковToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.yslygi;
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // наименованияПродукцииToolStripMenuItem
            // 
            this.наименованияПродукцииToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.na_prod;
            this.наименованияПродукцииToolStripMenuItem.Name = "наименованияПродукцииToolStripMenuItem";
            this.наименованияПродукцииToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.наименованияПродукцииToolStripMenuItem.Text = "Наименования продукции";
            this.наименованияПродукцииToolStripMenuItem.Click += new System.EventHandler(this.наименованияПродукцииToolStripMenuItem_Click);
            // 
            // видПечатиToolStripMenuItem
            // 
            this.видПечатиToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.vid_pechati;
            this.видПечатиToolStripMenuItem.Name = "видПечатиToolStripMenuItem";
            this.видПечатиToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.видПечатиToolStripMenuItem.Text = "Виды печати";
            this.видПечатиToolStripMenuItem.Click += new System.EventHandler(this.видПечатиToolStripMenuItem_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.material;
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.материалыToolStripMenuItem.Text = "Материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // видыОплатыToolStripMenuItem
            // 
            this.видыОплатыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Vid_oplat;
            this.видыОплатыToolStripMenuItem.Name = "видыОплатыToolStripMenuItem";
            this.видыОплатыToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.видыОплатыToolStripMenuItem.Text = "Виды оплаты";
            this.видыОплатыToolStripMenuItem.Click += new System.EventHandler(this.видыОплатыToolStripMenuItem_Click);
            // 
            // дляДизайнераToolStripMenuItem
            // 
            this.дляДизайнераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.макетToolStripMenuItem});
            this.дляДизайнераToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.dizainer;
            this.дляДизайнераToolStripMenuItem.Name = "дляДизайнераToolStripMenuItem";
            this.дляДизайнераToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.дляДизайнераToolStripMenuItem.Text = "Для дизайнера";
            // 
            // макетToolStripMenuItem
            // 
            this.макетToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.maket;
            this.макетToolStripMenuItem.Name = "макетToolStripMenuItem";
            this.макетToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.макетToolStripMenuItem.Text = "Макеты";
            this.макетToolStripMenuItem.Click += new System.EventHandler(this.макетToolStripMenuItem_Click);
            // 
            // продукцияToolStripMenuItem
            // 
            this.продукцияToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.PROD;
            this.продукцияToolStripMenuItem.Name = "продукцияToolStripMenuItem";
            this.продукцияToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.продукцияToolStripMenuItem.Text = "Продукция";
            this.продукцияToolStripMenuItem.Click += new System.EventHandler(this.продукцияToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Kli;
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.zakaziz;
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // состояниеГотовностиЗаказаToolStripMenuItem
            // 
            this.состояниеГотовностиЗаказаToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.GOT;
            this.состояниеГотовностиЗаказаToolStripMenuItem.Name = "состояниеГотовностиЗаказаToolStripMenuItem";
            this.состояниеГотовностиЗаказаToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.состояниеГотовностиЗаказаToolStripMenuItem.Text = "Состояние готовности заказа";
            this.состояниеГотовностиЗаказаToolStripMenuItem.Click += new System.EventHandler(this.состояниеГотовностиЗаказаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбчатаяДиаграмма1ToolStripMenuItem,
            this.столбчатаяДиаграмма2ToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.статистикаToolStripMenuItem.Text = "Статистика в диаграммах";
            // 
            // столбчатаяДиаграмма1ToolStripMenuItem
            // 
            this.столбчатаяДиаграмма1ToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.graph_pr;
            this.столбчатаяДиаграмма1ToolStripMenuItem.Name = "столбчатаяДиаграмма1ToolStripMenuItem";
            this.столбчатаяДиаграмма1ToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.столбчатаяДиаграмма1ToolStripMenuItem.Text = "Динамика заказанной продукции за все время";
            this.столбчатаяДиаграмма1ToolStripMenuItem.Click += new System.EventHandler(this.столбчатаяДиаграмма1ToolStripMenuItem_Click);
            // 
            // столбчатаяДиаграмма2ToolStripMenuItem
            // 
            this.столбчатаяДиаграмма2ToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.pie;
            this.столбчатаяДиаграмма2ToolStripMenuItem.Name = "столбчатаяДиаграмма2ToolStripMenuItem";
            this.столбчатаяДиаграмма2ToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.столбчатаяДиаграмма2ToolStripMenuItem.Text = "Стоимость продаваемой продукции";
            this.столбчатаяДиаграмма2ToolStripMenuItem.Click += new System.EventHandler(this.столбчатаяДиаграмма2ToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem,
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem,
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem,
            this.отчетОГотовыхЗаказахToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.отчетыToolStripMenuItem.Text = "Документация ";
            // 
            // отчетОЗаказахВРазрезеКлиентаToolStripMenuItem
            // 
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.otch;
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem.Name = "отчетОЗаказахВРазрезеКлиентаToolStripMenuItem";
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem.Text = "Реквизиты компании";
            this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem.Click += new System.EventHandler(this.отчетОЗаказахВРазрезеКлиентаToolStripMenuItem_Click);
            // 
            // отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem
            // 
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.otch;
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem.Name = "отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem";
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem.Text = "Прайс-лист";
            this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem.Click += new System.EventHandler(this.отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem_Click);
            // 
            // отчетОСостоянииКонкретногоЗаказаToolStripMenuItem
            // 
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.otch;
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem.Name = "отчетОСостоянииКонкретногоЗаказаToolStripMenuItem";
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem.Text = "Квитанция об оплате";
            this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem.Click += new System.EventHandler(this.отчетОСостоянииКонкретногоЗаказаToolStripMenuItem_Click);
            // 
            // отчетОГотовыхЗаказахToolStripMenuItem
            // 
            this.отчетОГотовыхЗаказахToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.otch;
            this.отчетОГотовыхЗаказахToolStripMenuItem.Name = "отчетОГотовыхЗаказахToolStripMenuItem";
            this.отчетОГотовыхЗаказахToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.отчетОГотовыхЗаказахToolStripMenuItem.Text = "Договор";
            this.отчетОГотовыхЗаказахToolStripMenuItem.Click += new System.EventHandler(this.отчетОГотовыхЗаказахToolStripMenuItem_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.входToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.администрированиеToolStripMenuItem.Text = "Администрирование БД";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.reg1;
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.регистрацияToolStripMenuItem.Text = "Пользователи БД и Регистрация ";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.регистрацияToolStripMenuItem_Click);
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.polz;
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(352, 26);
            this.входToolStripMenuItem.Text = "Управление правами пользователей";
            this.входToolStripMenuItem.Click += new System.EventHandler(this.входToolStripMenuItem_Click);
            // 
            // основнаяИнформацияToolStripMenuItem
            // 
            this.основнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оНасToolStripMenuItem,
            this.реквизитыToolStripMenuItem,
            this.контактыToolStripMenuItem});
            this.основнаяИнформацияToolStripMenuItem.Name = "основнаяИнформацияToolStripMenuItem";
            this.основнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.основнаяИнформацияToolStripMenuItem.Text = "Информация для справки";
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.info2;
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оНасToolStripMenuItem.Text = "О программе";
            this.оНасToolStripMenuItem.Click += new System.EventHandler(this.оНасToolStripMenuItem_Click);
            // 
            // реквизитыToolStripMenuItem
            // 
            this.реквизитыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.rekv;
            this.реквизитыToolStripMenuItem.Name = "реквизитыToolStripMenuItem";
            this.реквизитыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.реквизитыToolStripMenuItem.Text = "Реквизиты";
            this.реквизитыToolStripMenuItem.Click += new System.EventHandler(this.реквизитыToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.help;
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.контактыToolStripMenuItem.Text = "Помощь";
            this.контактыToolStripMenuItem.Click += new System.EventHandler(this.контактыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузкаПОToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // перезагрузкаПОToolStripMenuItem
            // 
            this.перезагрузкаПОToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.restart;
            this.перезагрузкаПОToolStripMenuItem.Name = "перезагрузкаПОToolStripMenuItem";
            this.перезагрузкаПОToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.перезагрузкаПОToolStripMenuItem.Text = "Перезапуск ПО";
            this.перезагрузкаПОToolStripMenuItem.Click += new System.EventHandler(this.перезагрузкаПОToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Picture_for_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1057, 635);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС типографии ООО «PolyCraft»";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОСостоянииКонкретногоЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОЗаказахВРазрезеКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОГотовыхЗаказахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляДизайнераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem макетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видПечатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сосToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыЗаказчиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыОплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реквизитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованияПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеГотовностиЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезагрузкаПОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продукцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбчатаяДиаграмма1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбчатаяДиаграмма2ToolStripMenuItem;
    }
}

