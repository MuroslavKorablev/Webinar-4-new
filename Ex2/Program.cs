int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,},
    {0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,},
    {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,},
    {0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,},
    {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,},
    {0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,},
    {0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,},
    {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,},
    {0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,},
    {0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,},
    {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,},
};

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
        // System.Console.Write($"{image[i, j] } "); 
        if (image[i,j] == 0)
            {
                System.Console.Write($" ");
            }
            else 
            {
                Console.Write($"+");
            }
        }
        System.Console.WriteLine();
    }
}

void FillImage(int x, int y)
{
    if(pic[x, y] == 0)
    {
        pic[x, y] = 1;
        FillImage(x - 1, y);
        FillImage(x, y - 1);
        FillImage(x + 1, y);
        FillImage(x, y + 1);
    }
}

PrintImage(pic);
FillImage(6,2);
System.Console.WriteLine();
PrintImage(pic);
