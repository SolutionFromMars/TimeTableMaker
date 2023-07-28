using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableMaker
{
    /// <summary>
    /// Класс отвечает за создание тем
    /// </summary>
    internal class GenerationThemes {
        /// <summary>
        ///Постоянный список длительности уроков
        /// </summary>
        readonly List<string> timeLessons = new() { 
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
        Dictionary<string, List<string>?> TimeTable = new() {
            { "Понедельник", null },
            { "Вторник"    , null },
            { "Среда"      , null },
            { "Четверг"    , null },
            { "Пятница"    , null },
            { "Время"      , null }};

        ImageSizes standard = new();

        /// <summary>
        /// Подставляет циферки перед каждым элементом
        /// </summary>
        /// <param name="lessons"></param>
        /// <returns>Тот же список с уже подставленными циферками</returns>
        static List<string> AddNumbers(List<string> lessons) {
            var newList = new List<string>(); //создание нового списка
            for (int i = 0; i < lessons.Count; i++) //перебирает каждый элемент
                newList.Add($"{i + 1}. {lessons[i]}"); //для добавления новых в новом списке
            return newList; //возвращение нового списка
        }

        /// <summary>
        /// Определяет формат и размер для тем
        /// </summary>
        internal class ImageSizes {
            internal string name { get; private set; }
            internal int width, height;
            /// <param name="name">Название формата, показываемое пользователю</param>
            /// <param name="width">Ширина формата</param>
            /// <param name="height">Высота формата</param>
            ImageSizes(string name, int width, int height) {
                this.name = name;
                this.width = width;
                this.height = height;
            }
        }
    }
}