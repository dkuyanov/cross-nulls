using System;

namespace CrossNulls
{
    class Game
    {
        private readonly Player firstPlayer;
        private readonly Player secondPlayer;
        private readonly Field field;

        public Game()
        {
            field = new Field();
            firstPlayer = new Player('X', field);
            secondPlayer = new Player('0', field);
        }

        public void Play()
        {
            Player currentPlayer = null;
            field.Print();
            do
            {
                currentPlayer = currentPlayer != firstPlayer 
                    ? firstPlayer 
                    : secondPlayer;
                currentPlayer.Play();
                field.Print();
            } while (!IsGameOver());
            Console.WriteLine("Игра окончена. Спасибо за игру!");
        }

        private bool IsGameOver()
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckRow(i))
                {
                    Congratulate(field.GetSymbol(i, 0));
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (CheckColumn(j))
                {
                    Congratulate(field.GetSymbol(0, j));
                    return true;
                }
            }
            if (CheckDiagonals())
            {
                Congratulate(field.GetSymbol(1, 1));
                return true;
            }
            return false;
        }

        private bool CheckRow(int i)
        {
            return field.GetSymbol(i, 0) != ' ' 
                && field.GetSymbol(i, 0) == field.GetSymbol(i, 1) 
                && field.GetSymbol(i, 1) == field.GetSymbol(i, 2);
        }

        private bool CheckColumn(int j)
        {
            return field.GetSymbol(0, j) != ' '
                && field.GetSymbol(0, j) == field.GetSymbol(1, j)
                && field.GetSymbol(1, j) == field.GetSymbol(2, j);
        }

        private bool CheckDiagonals()
        {
            return field.GetSymbol(1, 1) != ' ' && 
                  (field.GetSymbol(0, 0) == field.GetSymbol(1, 1)
                && field.GetSymbol(1, 1) == field.GetSymbol(2, 2)
                || field.GetSymbol(0, 2) == field.GetSymbol(1, 1)
                && field.GetSymbol(1, 1) == field.GetSymbol(2, 0));
        }

        private void Congratulate(char symbol)
        {
            Console.WriteLine("Поздравляем! Победил игрок '" + symbol + "'!");
        }
    }
}
