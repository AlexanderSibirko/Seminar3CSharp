// Console.ReadKey().Key == UpArrow, LeftArrow, RightArrow, DownArrow
// Chars  > = 16, < = 17, up = 30, down = 31

Console.Clear();
Console.WriteLine("\n Use arrow keys or \"WASD\" to control the snake");
Console.WriteLine("\n Press the 'Esc' key to quit.");
int curChar = 16;

int xstep = 2; // скалирование по координаты Х, для лучшего визуального восприятия (так как символы в консоли у нас не квадратные)
int ystep = 1; // скалирование по координате У
int sizeX = 20; // общий размер поля Х
int sizeY = 17; // общий размер поля Y, меньше Х для восприятия поля как квадратного =)
int minX = 4; // отступ игровой области по координате Х (в будущем добавить в область отступа данные о счёте?)
int minY = 6; // отступ игровой области по координате У (для того чтобы отобразить текст об управлении)
int Speed = 500; //скорость милисекунд между движениями головы
char[,] playTable = new char[sizeX,sizeY]; // запоминать всё поле ? для проверки в будущем на кого наступили в следующем шаге 
// int[,] snakeBody = new int[1,1]; //нужно ли запоминать координаты змеи если всё будем рисовать на карте?, нужно для понимания продолжения хвоста?
int maxX = minX + (sizeX-1)*xstep;
int maxY = minY + (sizeY-1)*ystep;
int curHeadX = (maxX - minX) / xstep;
int curHeadY = (maxY - minY) / ystep;
int curTailX = 0; //как понять где продолжение хвоста
int curTailY = 0; //как понять где продолжение хвоста
ConsoleKeyInfo cki;

// for (int i = 0; i < 17; i++  )
// {
//     for (int j =0 ;j < 20;j++)
//     {
//         playTable[j,i] = (char)16;
//         Console.Write(playTable[j,i] + " ");
//     }
//     Console.WriteLine();
// }

do
{
    //code made after key pressed
    while (Console.KeyAvailable == false)
    {
        //loop code here

        //Snake head moving
        curTailX = curHeadX;
        curTailY = curHeadY;

        switch (curChar)
        {
            case 16:
                if (curHeadX < maxX) { curHeadX = curHeadX + xstep; } else { curHeadX = minX; }
                break;
            case 17:
                if (curHeadX > minX) { curHeadX = curHeadX - xstep; } else { curHeadX = maxX; }
                break;
            case 30:
                if (curHeadY > minY) { curHeadY = curHeadY - ystep; } else { curHeadY = maxY; }
                break;
            case 31:
                if (curHeadY < maxY) { curHeadY = curHeadY + ystep; } else { curHeadY = minY; }
                break;
        }
        Console.SetCursorPosition(curHeadX, curHeadY);
        Console.Write((char)curChar);

        Console.SetCursorPosition(curTailX, curTailY);
        Console.Write(" ");
        Thread.Sleep(Speed); // Loop until input is entered.
    }
    Console.CursorVisible = false;
    cki = Console.ReadKey(true);
    switch (cki.Key, curChar)
    {
        case (ConsoleKey.UpArrow, 16 or 17):
        case (ConsoleKey.W, 16 or 17):
            curChar = 30;
            break;
        case (ConsoleKey.LeftArrow, 30 or 31):
        case (ConsoleKey.A, 30 or 31):
            curChar = 17;
            break;
        case (ConsoleKey.RightArrow, 30 or 31):
        case (ConsoleKey.D, 30 or 31):
            curChar = 16;
            break;
        case (ConsoleKey.DownArrow, 16 or 17) :
        case (ConsoleKey.S, 16 or 17) :
            curChar = 31;
            break;
        default:
            break;
    }
} while (cki.Key != ConsoleKey.Escape);