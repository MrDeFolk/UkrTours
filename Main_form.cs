using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukr_TourOp
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }
        
        // При завантаженні форми
        private void Main_form_Load(object sender, EventArgs e)
        {
        }

        #region ToolStripMenu

        // Відкриття форми Про програму
        private About_form About_formInstance;
        private void Open_About_form(object sender, EventArgs e)
        {
            // Перевіряємо, чи вже є відкрита форма
            if (About_formInstance == null || About_formInstance.IsDisposed)
            {
                // Якщо форма не відкрита або закрита, створюємо новий екземпляр
                About_formInstance = new About_form();
            }

            // Перевіряємо, чи форма вже є відображеною
            if (About_formInstance.Visible)
            {
                // Якщо вона вже відображена, активуємо її
                About_formInstance.Activate();
            }
            else
            {
                // Якщо вона не відображена, показуємо її
                About_formInstance.Show();
            }
        }

        // Відкриття форми Про автора
        private Author_form Author_formInstance;
        private void Open_Author_form(object sender, EventArgs e)
        {
            // Перевіряємо, чи вже є відкрита форма
            if (Author_formInstance == null || Author_formInstance.IsDisposed)
            {
                // Якщо форма не відкрита або закрита, створюємо новий екземпляр
                Author_formInstance = new Author_form();
            }

            // Відображаємо або активуємо форму
            if (Author_formInstance.Visible)
            {
                Author_formInstance.Activate();
            }
            else
            {
                Author_formInstance.Show();
            }
        }

        // Відкриття форми Друк
        private Print_form Print_formInstance;
        private void ToolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи вже є відкрита форма
            if (Print_formInstance == null || Print_formInstance.IsDisposed)
            {
                // Якщо форма не відкрита або закрита, створюємо новий екземпляр
                Print_formInstance = new Print_form();
            }

            // Відображаємо або активуємо форму
            if (Print_formInstance.Visible)
            {
                Author_formInstance.Activate();
            }
            else
            {
                Print_formInstance.Show();
            }
        }

        // Закриття програми
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // При натискані на пункт меню Тури
        private void ToolStripMenuItemTours_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = true;
            dataGridViewCustomers.Visible = false;
            dataGridViewLocations.Visible = false;
            dataGridViewToursDetails.Visible = false;

            // Заповнення та оновлення DataGridView
            this.toursTableAdapter.Update(this.ukrainets_tour_opDataSet.Tours);
            this.toursTableAdapter.Fill(this.ukrainets_tour_opDataSet.Tours);

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = toursBindingSource;
            bindingNavigator1.Visible = true;

            // Виведення назви таблиці
            labelInf.Text = "Тури";
            // Виведення к-сті записів
            textBoxCount.Text = toursBindingSource.Count.ToString();
        }

        // При натискані на пункт меню Деталі про тури
        private void ToolStripMenuItemToursDetails_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewLocations.Visible = false;
            dataGridViewToursDetails.Visible = true;

            // Заповнення та оновлення DataGridView
            this.tours_DetailsTableAdapter.Update(this.ukrainets_tour_opDataSet.Tours_Details);
            this.tours_DetailsTableAdapter.Fill(this.ukrainets_tour_opDataSet.Tours_Details);

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = toursDetailsBindingSource;
            bindingNavigator1.Visible = true;

            // Виведення назви таблиці
            labelInf.Text = "Деталі про тури";
            // Виведення к-сті записів
            textBoxCount.Text = toursDetailsBindingSource.Count.ToString();
        }

        // При натискані на пункт меню Замовники
        private void ToolStripMenuItemCustomers_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = false;
            dataGridViewCustomers.Visible = true;
            dataGridViewLocations.Visible = false;
            dataGridViewToursDetails.Visible = false;

            // Заповнення та оновлення DataGridView
            this.customersTableAdapter.Update(this.ukrainets_tour_opDataSet.Customers);
            this.customersTableAdapter.Fill(this.ukrainets_tour_opDataSet.Customers);

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = customersBindingSource;
            bindingNavigator1.Visible = true;

            // Виведення назви таблиці
            labelInf.Text = "Замовники";
            // Виведення к-сті записів
            textBoxCount.Text = customersBindingSource.Count.ToString();
        }

        // При натискані на пункт меню Локації
        private void ToolStripMenuItemLocations_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewLocations.Visible = true;
            dataGridViewToursDetails.Visible = false;

            // Заповнення та оновлення DataGridView
            this.locationTableAdapter.Update(this.ukrainets_tour_opDataSet.Location);
            this.locationTableAdapter.Fill(this.ukrainets_tour_opDataSet.Location);

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = locationBindingSource;
            bindingNavigator1.Visible = true;

            // Виведення назви таблиці
            labelInf.Text = "Локації";
            // Виведення к-сті записів
            textBoxCount.Text = locationBindingSource.Count.ToString();
        }


        // При натисканні на пункт меню "Тури за ID"
        private void ToolStripMenuItemToursByID_Click(object sender, EventArgs e)
        {
            toursByIDToolStrip.Visible = true;
        }
        // При натискані на кнопку Exit - Приховати меню пошуку Турів
        private void toolStripButtonExitTourByID_Click(object sender, EventArgs e)
        {
            toursByIDToolStrip.Visible = false;
        }
        // При натискані на кнопку Пошук за ID Тура
        private void toolStripButtonSearchToursByID_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = true;
            dataGridViewCustomers.Visible = false;
            dataGridViewLocations.Visible = false;
            dataGridViewToursDetails.Visible = false;

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = toursBindingSource;
            bindingNavigator1.Visible = true;

            labelInf.Text = "Пошук турів за ID Тура";
            // Спробуємо сконвертувати значення введене користувачем до типу short
            if (short.TryParse(enterParameterToolStripTextBox.Text, out short tourID))
            {
                // Якщо конвертація пройшла успішно, передаємо значення tourID у метод ToursByID
                toursTableAdapter.ToursByID(this.ukrainets_tour_opDataSet.Tours, tourID);
            }
            else
            {
                // Вивести повідомлення про помилку введеного значення користувачем
                MessageBox.Show("Некоректний ідентифікатор туру. Будь ласка, введіть коректне значення.", "Помилка пошуку.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBoxCount.Text = toursBindingSource.Count.ToString();
        }
        

        // При натисканні на пункт меню "Замовники за ID"
        private void ToolStripMenuItemCustomersByID_Click(object sender, EventArgs e)
        {
            customersByIDToolStrip.Visible = true;
        }
        // При натискані на кнопку Exit - Приховати меню пошуку Замовників
        private void toolStripButtonExitCustomersByID_Click(object sender, EventArgs e)
        {
            customersByIDToolStrip.Visible = false;
        }
        // При натискані на кнопку Пошук за ID Замовника
        private void toolStripButtonSearchCustomersByID_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = false;
            dataGridViewCustomers.Visible = true;
            dataGridViewLocations.Visible = false;
            dataGridViewToursDetails.Visible = false;

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = customersBindingSource;
            bindingNavigator1.Visible = true;

            labelInf.Text = "Пошук замовників за ID Замовника";
            try
            {
                this.customersTableAdapter.CustomersByID(this.ukrainets_tour_opDataSet.Customers, enterCustomerIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBoxCount.Text = customersBindingSource.Count.ToString();
        }

        

        // При натисканні на пункт меню "Локації за ID"
        private void ToolStripMenuItemLocationByID_Click(object sender, EventArgs e)
        {
            locationByIDToolStrip.Visible = true;
        }
        // При натискані на кнопку Exit - Приховати меню пошуку Локацій
        private void toolStripButtonExitLocationByID_Click(object sender, EventArgs e)
        {
            locationByIDToolStrip.Visible = false;
        }
        // При натискані на кнопку Пошук за ID Локації
        private void toolStripButtonSearchLocationByID_Click(object sender, EventArgs e)
        {
            // Відображення та скриття dataGridView
            dataGridViewTours.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewLocations.Visible = true;
            dataGridViewToursDetails.Visible = false;

            // Адаптація навігатора до Таблиці
            bindingNavigator1.BindingSource = locationBindingSource;
            bindingNavigator1.Visible = true;

            labelInf.Text = "Пошук локацій за ID Локації";
            try
            {
                this.locationTableAdapter.LocationByID(this.ukrainets_tour_opDataSet.Location, enterLocationIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBoxCount.Text = locationBindingSource.Count.ToString();
        }

        #endregion

        // Подія з додаванням рядків
        private void RowsAddedUpdate(object sender, DataGridViewRowsAddedEventArgs e)
        {
            toursTableAdapter.Update(ukrainets_tour_opDataSet);
            textBoxCount.Text = toursBindingSource.Count.ToString();
        }
        // Подія з вилученням рядків
        private void RowsRemovedUpdate(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toursTableAdapter.Update(ukrainets_tour_opDataSet);
            textBoxCount.Text = toursBindingSource.Count.ToString();
        }

    }
}