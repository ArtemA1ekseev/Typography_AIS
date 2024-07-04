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

namespace WindowsFormsApp1
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
            Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        PictureBox org;

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.maket". При необходимости она может быть перемещена или удалена.
            this.maketTableAdapter.Fill(this.typographyDataSet4.maket);


            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true;

            //

            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView1.Nodes.Add(node);

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                maketBindingSource.Filter = "data_sozdania = '" + textBox1.Text + "'";
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Ошибка! Проверьте правильность своих действий!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                textBox1.Text = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                maketBindingSource.Filter = "data_izmenenia = '" + textBox2.Text + "'";
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Ошибка! Проверьте правильность своих действий!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                textBox2.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maketBindingSource.Filter = "";
            textBox1.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maketBindingSource.Filter = "";
            textBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 1; i < dataGridView1.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i - 1].Cells[j].Value;
                    }
                }
                ExcelApp.Cells[1, 1] = "Наименование";
                ExcelApp.Cells[1, 2] = "Тип файла";
                ExcelApp.Cells[1, 3] = "Размер";
                ExcelApp.Cells[1, 4] = "Разрешение";
                ExcelApp.Cells[1, 5] = "Глубина цвета";
                ExcelApp.Cells[1, 6] = "Дата создания";
                ExcelApp.Cells[1, 7] = "Дата изменения";
                ExcelApp.Columns.AutoFit();
                ExcelApp.Rows.AutoFit();
                saveFileDialog1.FileName = "Макеты.xlsx";
                saveFileDialog1.Filter = "Файл Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExcelWorkBook.SaveAs(saveFileDialog1.FileName);
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка Экспорта!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog od = new OpenFileDialog();
            // фильтр форматов файлов
            od.Filter = "Image Files(*.JPG;*.BMP;*.GIF;*.PNG)|*.JPG;*.BMP;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (od.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listBox1.Items.Add(od.FileName);
                    // загружаем изображение
                    org = new PictureBox();
                    org.Load(od.FileName);
                    pictureBox1.Load(od.FileName);
                    trackBar1.Enabled = true;
                    //
                    button8.Enabled = true;
                    grayButton.Enabled = true;
                    button11.Enabled = true;
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show(
                   "Невозможно открыть выбранный файл!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                // фильтр форматов файлов
                sfd.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.BMP)|*.BMP|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show(
                        "Невозможно сохранить изображение!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) // если изображение в pictureBox1 имеется
            {
                // создаём Bitmap из изображения, находящегося в pictureBox1
                Bitmap input = new Bitmap(pictureBox1.Image);
                // создаём Bitmap для черно-белого изображения
                Bitmap output = new Bitmap(input.Width, input.Height);
                // перебираем в циклах все пиксели исходного изображения
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        // получаем (i, j) пиксель
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        // получаем компоненты цветов пикселя
                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий
                                                               // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        R = G = B = (R + G + B) / 3.0f;
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        // добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                // выводим черно-белый Bitmap в pictureBox2
                pictureBox2.Image = output;
                //
                button9.Enabled = true;
                saveButton.Enabled = true;
                button7.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            trackBar1.Enabled = false;
            trackBar1.Value = 1;
            pictureBox1.BackColor = DefaultBackColor;
            //
            button8.Enabled = false;
            grayButton.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            saveButton.Enabled = false;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            trackBar1.Enabled = false;
            trackBar1.Value = 1;
            pictureBox1.BackColor = DefaultBackColor;
            //
            button8.Enabled = false;
            grayButton.Enabled = false;
            button11.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            //
            button9.Enabled = false;
            saveButton.Enabled = false;
            button7.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.Owner = this;
            button10.Enabled = false;
            form27.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    //add files of rootdirectory
                    DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                    foreach (var file in rootDir.GetFiles())
                    {
                        TreeNode n = new TreeNode(file.Name, 13, 13);
                        e.Node.Nodes.Add(n);
                    }

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);

                            foreach (var file in di.GetFiles())
                            {
                                TreeNode n = new TreeNode(file.Name, 13, 13);
                                node.Nodes.Add(n);
                            }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0;
            button2.Enabled = textBox1.Text.Length != 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = textBox2.Text.Length != 0;
            button6.Enabled = textBox2.Text.Length != 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maketBindingSource.EndEdit();
            this.maketTableAdapter.Update(this.typographyDataSet4.maket);
            dataGridView1.Refresh();
        }
    }
}
