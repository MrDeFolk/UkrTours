using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukr_TourOp
{
    public partial class About_form : Form
    {
        public About_form()
        {
            InitializeComponent();
        }

        private void About_form_Load(object sender, EventArgs e)
        {
            string filePath = "D:\\436_OBD_Ukrainets\\UDS\\Ukr_TourOP\\other_stuff\\Довідка.rtf";

            // Перевірка наявності файлу
            if (File.Exists(filePath))
            {
                // Зчитуємо вміст файлу та встановлюємо його як текст для richTextBox
                richTextBoxAbout.LoadFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }
        }
    }
}
