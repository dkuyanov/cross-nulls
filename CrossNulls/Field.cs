using System;

namespace CrossNulls
{
    class Field
    {
        private readonly char[][] field;

        public Field()
        {
            field = new char[3][];
            for(int i = 0; i < 3; i++)
            {
                field[i] = new char[3];
                for(int j = 0; j < 3; j++)
                {
                    field[i][j] = ' ';
                }
            }
        }

        public char GetSymbol(int i, int j)
        {
            return field[i][j];
        }

        public void SetSymbol(int i, int j, char symbol)
        {
            if(field[i][j] == ' ')
            {
                field[i][j] = symbol;
            }
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine("_______");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(field[i][j].ToString() + "|");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("*******");
        }
    }
}
