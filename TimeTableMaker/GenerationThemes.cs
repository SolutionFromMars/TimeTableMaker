using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using WinRT;

namespace TimeTableMaker;

#pragma warning disable CA1416 // Бесполезное предупреждение: это приложение должно работать только на Windows

/// <summary>
/// Класс отвечает за создание тем
/// </summary>
internal sealed class GenerationThemes {
    /// <summary>
    ///Постоянный список длительности уроков
    /// </summary>
    internal static readonly List<string> TimeLessons = new() {
            "09:00 - 09:40",
            "10:00 - 10:40",
            "10:55 - 11:35",
            "11:45 - 12:25",
            "12:45 - 13:25",
            "13:45 - 14:25",
            "14:35 - 15:15" };

    /// <summary>
    /// Основа для текстового представления расписания
    /// </summary>
    internal static Dictionary<string, List<string>> TimeTable { get; private set; } = new() {
            { "Понедельник", null },
            { "Вторник"    , null },
            { "Среда"      , null },
            { "Четверг"    , null },
            { "Пятница"    , null },
            { "Время"      , null }};

    /// <summary>
    /// Список с наименованиями позиций
    /// </summary>
    internal static readonly List<string> NameDays = new() {
        "Понедельник",
        "Вторник",
        "Среда",
        "Четверг",
        "Пятница",
        "Время"};

    /// <summary>
    /// Список уроков на каждый день
    /// </summary>
    internal static List<List<string>> strings { get; private set; } = new();

    internal static readonly List<ImageSizes> SizesList = new()
    {
        new("4:3 480x360", 480, 360),
        new("9:16 720x1280", 720, 1280),
        new("9:21 720x1680", 720, 1680),
        new("9:16 1080x1920", 1080, 1920),
        new("16:9 1920x1080", 1920, 1080),
    };
    internal static readonly List<GenerationThemes> ThemesList = new()
    {
        new("Нормальная тема", (imageSizes) =>{
            TableGraphics.Clear(Color.White);
            var keys = GenerationThemes.TimeTable.Keys.ToArray();
            var values = GenerationThemes.TimeTable.Values.ToArray();
            if (imageSizes == SizesList[0]){
               var MajorFont = new Font(FontFamily.GenericSerif, 16, System.Drawing.FontStyle.Italic);
               var MinorFont = new Font(FontFamily.GenericSansSerif, 9);
               for (int i = 0; i < keys.Length; i++){
                    TableGraphics.DrawString(keys[i], MajorFont, Brushes.Black, new PointF(imageSizes.width/3*(i%3)+15, imageSizes.height/2*(i/3)+5));
                    TableGraphics.DrawString(String.Join(Environment.NewLine, AddNumbers(i < 5 ? values[i]:TimeLessons)), MinorFont, Brushes.Black,
                        new PointF(imageSizes.width/3*(i%3)+10, imageSizes.height/2*(i/3)+40));
               }
            }
            if (imageSizes == SizesList[1]){
               var MajorFont = new Font(FontFamily.GenericSerif, 27, System.Drawing.FontStyle.Italic);
               var MinorFont = new Font(FontFamily.GenericSansSerif, 20);
               for (int i = 0; i < keys.Length; i++){
                    TableGraphics.DrawString(keys[i], MajorFont, Brushes.Black, new PointF(imageSizes.width/2*(i%2)+50, imageSizes.height/3*(i/2)+130 +(2-i/2)*100));
                    TableGraphics.DrawString(String.Join(Environment.NewLine, AddNumbers(i < 5 ? values[i]:TimeLessons)), MinorFont, Brushes.Black,
                        new PointF(imageSizes.width/2*(i%2)+30, imageSizes.height/3*(i/2)+170 +(2-i/2)*100));
               }
            }
            if (imageSizes == SizesList[2]){
               var MajorFont = new Font(FontFamily.GenericSerif, 28, System.Drawing.FontStyle.Italic);
               var MinorFont = new Font(FontFamily.GenericSansSerif, 21);
               for (int i = 0; i < keys.Length; i++){
                    TableGraphics.DrawString(keys[i], MajorFont, Brushes.Black, new PointF(imageSizes.width/2*(i%2)+45, imageSizes.height/3*(i/2)+230 +(2-i/2)*230));
                    TableGraphics.DrawString(String.Join(Environment.NewLine, AddNumbers(i < 5 ? values[i]:TimeLessons)), MinorFont, Brushes.Black,
                        new PointF(imageSizes.width/2*(i%2)+15, imageSizes.height/3*(i/2)+270 +(2-i/2)*230));
               }
            }
        }),
    };
    /// <summary>
    /// 
    /// Итоговое изображение расписания
    /// </summary>
    internal static Bitmap TableImage { get; private set; }
    /// <summary>
    /// Локальное обеспечение графики
    /// </summary>
    private static Graphics TableGraphics;
    /// <summary>
    /// Название темы
    /// </summary>
    internal string themeName { get; private set; }
    /// <summary>
    /// Делегат для создания прорисовщиков
    /// </summary>
    /// <param name="imageSizes">Параметр для определения размера</param>
    internal delegate void DrawerImage(ImageSizes imageSizes);
    /// <summary>
    /// Инструкция для прорисовки темы конкретного экземпляра
    /// </summary>
    private DrawerImage drawer;

    /// <summary>
    /// Подставляет циферки перед каждым элементом
    /// </summary>
    /// <param name="lessons"></param>
    /// <returns>Тот же список с уже подставленными циферками</returns>
    protected static List<string> AddNumbers(List<string> lessons) {
        var newList = new List<string>(); //создание нового списка
        for (int i = 0; i < lessons.Count; i++) //перебирает каждый элемент
            newList.Add($"{i + 1}. {lessons[i]}"); //для добавления новых в новом списке
        return newList; //возвращение нового списка
    }

    /// <summary>
    /// Меняет картинку класса
    /// </summary>
    /// <param name="theme">Инструкция для рисования</param>
    /// <param name="size">Выбранный размер для инструкции</param>
    internal static void MakeImage(GenerationThemes theme, ImageSizes size) {
        SetLessonsList();
        TableImage = new(size.width, size.height);
        TableGraphics = Graphics.FromImage(TableImage);
        TableGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        theme.drawer(size); //обращение к отрисовщику
    }

    /// <summary>
    /// Изменяет словарь TimeTable для обновления значений
    /// </summary>
    internal static void SetLessonsList() {
        var keys = TimeTable.Keys.ToArray();
        var directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TimeTableMaker";
        if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath); //проверка на существование папки
        if (!File.Exists(directoryPath + "\\Monday.dat")) File.Create(directoryPath + "\\Monday.dat").Close(); //проверка на существование файла
        if (!File.Exists(directoryPath + "\\Tuesday.dat")) File.Create(directoryPath + "\\Tuesday.dat").Close(); //Close нужно для избежания исключений
        if (!File.Exists(directoryPath + "\\Wednesday.dat")) File.Create(directoryPath + "\\Wednesday.dat").Close(); //связанных с файловыми потоками
        if (!File.Exists(directoryPath + "\\Thursday.dat")) File.Create(directoryPath + "\\Thursday.dat").Close();
        if (!File.Exists(directoryPath + "\\Friday.dat")) File.Create(directoryPath + "\\Friday.dat").Close();
        TimeTable[keys[0]] = File.ReadAllLines(directoryPath + "\\Monday.dat").ToList(); //преобразование данных в массив
        TimeTable[keys[1]] = File.ReadAllLines(directoryPath + "\\Tuesday.dat").ToList();
        TimeTable[keys[2]] = File.ReadAllLines(directoryPath + "\\Wednesday.dat").ToList();
        TimeTable[keys[3]] = File.ReadAllLines(directoryPath + "\\Thursday.dat").ToList();
        TimeTable[keys[4]] = File.ReadAllLines(directoryPath + "\\Friday.dat").ToList();
    }

    /// <summary>
    /// Создание новой темы
    /// </summary>
    /// <param name="themeName">Название этой темы</param>
    /// <param name="drawer">Инструкция для прорисовки</param>
    private GenerationThemes(string themeName, DrawerImage drawer) {
        this.themeName = themeName;
        this.drawer = drawer;
    }

    /// <summary>
    /// Определяет формат и размер для тем
    /// </summary>
    internal sealed class ImageSizes {
        internal String name { get; private set; }
        internal Int32 width { get; private set; }
        internal Int32 height{ get; private set; }
        /// <param name="name">Название формата, показываемое пользователю</param>
            /// <param name="width">Ширина формата</param>
            /// <param name="height">Высота формата</param>
        internal ImageSizes(String name, Int32 width, Int32 height) {
            this.name = name;
            this.width = width;
            this.height = height;
        }
    }
}