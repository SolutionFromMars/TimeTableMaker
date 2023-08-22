using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableMaker
{
    public partial class Redactor : Form
    {
        public Redactor()
        {
            InitializeComponent();
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            var arr = GenerationThemes.TimeTable.Keys.ToArray();
            groupBox1.Text = arr[0]; //присвоение заголовкам GroupBox имена
            groupBox2.Text = arr[1]; //ключей из словаря Generationthemes.TimeTable
            groupBox3.Text = arr[2];
            groupBox4.Text = arr[3];
            groupBox5.Text = arr[4];
        }

        private void saveTable_Click(object sender, EventArgs e) //сохраняет данные в реестр и закрывает форму
        {

        }

        private void noSaveTable_Click(object sender, EventArgs e) => Close(); //просто закрывает форму, ничего не сохраняя     

        private void textChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            var sels = tb.SelectionStart;
            var lessons = tb.Text.Split('\n').ToList(); //получение текста и преобразование его в список
            if (lessons.Count > 8) lessons.RemoveRange(8, lessons.Count - 8); //должно быть максимум 8 строк
            for (int i = 0; i < lessons.Count; i++) if (lessons[i].Length > 20)
                    lessons[i] = lessons[i].Remove(20, lessons[i].Length - 20); //и не больше 20 символов в строке
            tb.Text = String.Join("\n", lessons); //изменение текста
            tb.SelectionStart = sels; //перемещение каретки в прошлое место
        }
    }
}