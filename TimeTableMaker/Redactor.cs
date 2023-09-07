namespace TimeTableMaker
{
    public partial class Redactor : Form
    {
        private new Place Parent;

        public Redactor(Place parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            GenerationThemes.SetLessonsList();
            var keys = GenerationThemes.NameDays;
            var values = GenerationThemes.Lessons;
            groupBox1.Text = keys[0]; //присвоение заголовкам GroupBox имена
            groupBox2.Text = keys[1]; //ключей из словаря Generationthemes.TimeTable
            groupBox3.Text = keys[2];
            groupBox4.Text = keys[3];
            groupBox5.Text = keys[4];
            textMonday.Text = String.Join(Environment.NewLine, values[0]); //вместо '\n' использовать Environment.Newline
            textTuesday.Text = String.Join(Environment.NewLine, values[1]); //для обеспечения совместимости с клавиатурой
            textWednesday.Text = String.Join(Environment.NewLine, values[2]);
            textThursday.Text = String.Join(Environment.NewLine, values[3]);
            textFriday.Text = String.Join(Environment.NewLine, values[4]);
        }

        private void saveTable_Click(object sender, EventArgs e) //сохраняет данные в файл Appdata и закрывает форму
        {
            var directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TimeTableMaker";
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath); //папка будет создаваться только, если ее не существует
            File.WriteAllLines(directoryPath + "\\Monday.dat", textMonday.Text.Split(Environment.NewLine)); //запись массива в файл данных
            File.WriteAllLines(directoryPath + "\\Tuesday.dat", textTuesday.Text.Split(Environment.NewLine));
            File.WriteAllLines(directoryPath + "\\Wednesday.dat", textWednesday.Text.Split(Environment.NewLine));
            File.WriteAllLines(directoryPath + "\\Thursday.dat", textThursday.Text.Split(Environment.NewLine));
            File.WriteAllLines(directoryPath + "\\Friday.dat", textFriday.Text.Split(Environment.NewLine));
            GenerationThemes.SetLessonsList();
            Close();
        }

        private void textChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            var sels = tb.SelectionStart;
            var lessons = tb.Text.Split(Environment.NewLine).ToList(); //получение текста и преобразование его в список
            if (lessons.Count > 8) lessons.RemoveRange(8, lessons.Count - 8); //должно быть максимум 8 строк
            for (int i = 0; i < lessons.Count; i++) if (lessons[i].Length > 20)
                    lessons[i] = lessons[i].Remove(20, lessons[i].Length - 20); //и не больше 20 символов в строке
            tb.Text = String.Join(Environment.NewLine, lessons); //изменение текста
            tb.SelectionStart = sels; //перемещение каретки в прошлое место
        }

        private void Redactor_FormClosing(object sender, FormClosingEventArgs e) {
            Parent.Opacity = 1;
            GenerationThemes.MakeImage(GenerationThemes.ThemesList[Parent.selectTheme.SelectedIndex], GenerationThemes.SizesList[Parent.selectSize.SelectedIndex]);
            Parent.representsImage.Image = GenerationThemes.TableImage; //обновление картинки
        }
    }
}