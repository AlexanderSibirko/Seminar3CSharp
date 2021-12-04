//установка все диоды в карсный
int[,] ledRGB = new int[60, 3];
for (int i = 0; i < 60; i++)
{
    ledRGB[i, 0] = 255;
    ledRGB[i, 1] = 0;
    ledRGB[i, 2] = 0;
}

//скорость и грубость пульсации
int step = 5;
int speed = 10;

while (true)
{
    for (int led = 0; led < 60; led++)
    {
        (ledRGB[led, 0], ledRGB[led, 1], ledRGB[led, 2]) = PulseRYGBR(ledRGB[led, 0],
                                                                      ledRGB[led, 1],
                                                                      ledRGB[led, 2],
                                                                      step);
    }
    Console.WriteLine($"({ledRGB[0, 0]},{ledRGB[0, 1]},{ledRGB[0, 2]})");
    Thread.Sleep(speed);
}

(int, int, int) PulseRYGBR(int R, int G, int B, int step) //пульсируем Красный, Жёлтый, Зелёный, Синий
{
    switch (R, G, B)
    {
        case (255, < 255, 0):   //from Red to Yellow
            G += step;
            if (G>255) G = 255;
            break;
        case ( > 0, 255, 0):    //from Yellow to Green
            R -= step;
            if (R<0) R = 0;
            break;
        case (0, > 0, < 255):   //from Green to Blue
            G -= step;
            if (G<0) G = 0;
            B += step;
            if (B>255) B = 255;
            break;
        case ( < 255, 0, > 0):   //from Green to Red
            R += step;
            if (R>255) R = 255;
            B -= step;
            if (B<0) B = 0;
            break;
        default:
            break;
    }
    return (R, G, B);
}
