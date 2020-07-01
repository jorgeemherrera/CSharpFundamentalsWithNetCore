using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void DrawLine(int lengthLine = 10)
        {
            var line = "".PadLeft(lengthLine, '-');
            WriteLine(line);
        }
        public static void WriteTitle(string title)
        {
            var lengthTitle = title.Length + 4;
            DrawLine(lengthTitle);
            WriteLine($"| {title} |");
            DrawLine(lengthTitle);
        }

        public static void Beep(int hz = 2000, int time = 500, int amounTime = 1)
        {
            while (amounTime-- > 0) {
                System.Console.Beep(hz, time);
            }
        }
    }
}