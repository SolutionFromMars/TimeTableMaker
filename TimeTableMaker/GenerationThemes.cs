using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMaker;

/// <summary>
    /// Класс отвечает за создание тем
    /// </summary>
internal class GenerationThemes {
    /// <summary>
        ///Постоянный список длительности уроков
        /// </summary>
    internal readonly List<string> timeLessons = new() { 
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
    internal Dictionary<string, List<string>> TimeTable = new() {
            { "Понедельник", null },
            { "Вторник"    , null },
            { "Среда"      , null },
            { "Четверг"    , null },
            { "Пятница"    , null },
            { "Время"      , null }};

    internal static readonly List<ImageSizes> SizesList = new()
    {
        new("4:3 480x360", 480, 360),
        new("9:16 720x1280", 720, 1280),
        new("9:21 720x1680", 720, 1680),
    };
    internal static readonly List<GenerationThemes> ThemesList = new()
    {
        new("Нормальная тема", (imageSizes) =>
        {
            switch (imageSizes)
            {
                case ImageSizes S480x360:
                    break;
            }
        }),
    };
    /// <summary>
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
    static protected List<string> AddNumbers(List<string> lessons) {
        var newList = new List<string>(); //создание нового списка
        for (int i = 0; i < lessons.Count; i++) //перебирает каждый элемент
            newList.Add($"{i + 1}. {lessons[i]}"); //для добавления новых в новом списке
        return newList; //возвращение нового списка
    }

    /// <summary>
    /// Меняет картинку экземпляра класса
    /// </summary>
    /// <param name="theme">Инструкция для рисования</param>
    /// <param name="size">Выбранный размер для инструкции</param>
    internal static void MakeImage(GenerationThemes theme, ImageSizes size) {
        TableImage = new(size.width, size.height);
        TableGraphics = Graphics.FromImage(TableImage);
        theme.drawer(size); //обращение к отрисовщику
    }

    /// <summary>
    /// Создание новой темы
    /// </summary>
    /// <param name="themeName">Название этой темы</param>
    /// <param name="drawer">Инструкция для прорисовки</param>
    internal GenerationThemes(string themeName, DrawerImage drawer) {
        this.themeName = themeName;
        this.drawer = drawer;
    }

    /// <summary>
    /// Определяет формат и размер для тем
    /// </summary>
    internal sealed class ImageSizes {
        internal string name { get; private set; }
        internal int width { get; private set; }
        internal int height{ get; private set; }
        /// <param name="name">Название формата, показываемое пользователю</param>
            /// <param name="width">Ширина формата</param>
            /// <param name="height">Высота формата</param>
        internal ImageSizes(string name, int width, int height) {
            this.name = name;
            this.width = width;
            this.height = height;
        }
    }
}