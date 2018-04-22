using System;

namespace CrossNulls
{
    class Player
    {
        private readonly Field field;
        private readonly char symbol;

        public Player(char symbol, Field field)
        {
            this.symbol = symbol;
            this.field = field;
        }

        public void Play()
        {
            Console.WriteLine("Игрок '" + symbol + "', Ваш ход");
            Console.WriteLine("Выберите номер ячейки игрового поля");
            Console.Write("Номер строки: ");
            int x = int.Parse(Console.ReadLine().Trim());
            Console.Write("Номер столбца: ");
            int y = int.Parse(Console.ReadLine().Trim());
            field.SetSymbol(x, y, symbol);
        }
    }
}
