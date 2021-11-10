// Console.ReadKey().Key == UpArrow, LeftArrow, RightArrow, DownArrow
// Chars  > = 16, < = 17, up = 30, down = 31

Console.Clear();
Console.WriteLine("\n Use arrow keys or \"WASD\" to control the snake");
Console.WriteLine("\n Press the 'Esc' key to quit.");
int curChar = 16;

int xstep = 2;
int ystep = 1;
int sizeX = 20;
int sizeY = 17;
int minX = 4;
int minY = 6;
char[,] playTable = new char[sizeX,sizeY];
int maxX = minX + (sizeX-1)*xstep;
int maxY = minY + (sizeY-1)*ystep;
int curHeadX = (maxX - minX) / xstep ;
int curHeadY = (maxY - minY) / ystep ;

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
        Console.SetCursorPosition(curHeadX, curHeadY);
        Console.Write((char)curChar);
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
        Thread.Sleep(500); // Loop until input is entered.
    }
    Console.CursorVisible = false;
    cki = Console.ReadKey(true);
    switch (cki.Key)
    {
        case ConsoleKey.UpArrow :
        case ConsoleKey.W:
            curChar = 30;
            break;
        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            curChar = 17;
            break;
        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            curChar = 16;
            break;
        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            curChar = 31;
            break;
        default:
            curChar = 16;
            break;
    }
} while (cki.Key != ConsoleKey.Escape);