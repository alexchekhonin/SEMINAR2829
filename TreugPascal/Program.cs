// Треугольник Паскаля
int[,] CreateTriangle(int row)
{
    int[,] triangle = new int[row, row];
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] =
            triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintTriangle(int[,] triangle)
{
    int row = triangle.GetLength(0);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                if (triangle[i, j] % 2 != 0) Console.Write($"{triangle[i, j],4}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[] GetKoeff(int[,] tr, int pow)
{
    int[] row = new int[pow + 1];
    for (int i = 0; i <= pow; i++)
    {
        row[i] = tr[pow, i];
    }
    return row;
}

int[,] tr = CreateTriangle(10);
PrintTriangle(tr);
int[] koeff = GetKoeff(tr, 5);

System.Console.WriteLine(String.Join(' ', koeff));

for (int i = 0; i < koeff.Length; i++)
{
    Console.Write($"{koeff[i]}*a^{koeff.Length - i}*b^{i} + ");
}