// Zadanie 2
using System;

class Matrix
{
    private int[,] data;
    private int rows;
    private int cols;

    public int Rows => rows;
    public int Cols => cols;

    public Matrix(int rows, int cols, int[,] input = null)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];

        if (input != null)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    data[i, j] = input[i, j];
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols)
            throw new InvalidOperationException("Macierze muszą mieć ten sam rozmiar do dodawania.");

        Matrix result = new Matrix(a.rows, a.cols);
        for (int i = 0; i < a.rows; i++)
            for (int j = 0; j < a.cols; j++)
                result.data[i, j] = a.data[i, j] + b.data[i, j];

        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.rows != b.rows || a.cols != b.cols)
            throw new InvalidOperationException("Macierze muszą mieć ten sam rozmiar do odejmowania.");

        Matrix result = new Matrix(a.rows, a.cols);
        for (int i = 0; i < a.rows; i++)
            for (int j = 0; j < a.cols; j++)
                result.data[i, j] = a.data[i, j] - b.data[i, j];

        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.cols != b.rows)
            return null;

        Matrix result = new Matrix(a.rows, b.cols);

        for (int i = 0; i < result.rows; i++)
        {
            for (int j = 0; j < result.cols; j++)
            {
                int sum = 0;
                for (int k = 0; k < a.cols; k++)
                    sum += a.data[i, k] * b.data[k, j];
                result.data[i, j] = sum;
            }
        }

        return result;
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

        if (a.rows != b.rows || a.cols != b.cols)
            return false;

        for (int i = 0; i < a.rows; i++)
            for (int j = 0; j < a.cols; j++)
                if (a.data[i, j] != b.data[i, j])
                    return false;

        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public Matrix Transpose()
    {
        Matrix result = new Matrix(cols, rows);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result.data[j, i] = data[i, j];

        return result;
    }

    public void Display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{data[i, j],4}");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public override bool Equals(object obj)
    {
        return obj is Matrix m && this == m;
    }

    public override int GetHashCode()
    {
        return data.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } }; // 2x3
        int[,] data2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } }; // 3x2

        Matrix A = new Matrix(2, 3, data1);
        Matrix B = new Matrix(3, 2, data2);

        Console.WriteLine("Macierz A (2x3):");
        A.Display();

        Console.WriteLine("Macierz B (3x2):");
        B.Display();

        Console.WriteLine("A * B (wynik 2x2):");
        Matrix E = A * B;
        if (E is not null)
            E.Display();
        else
            Console.WriteLine("Nie można wykonać mnożenia macierzy (niezgodne wymiary).\n");

        Console.WriteLine("Transpozycja A:");
        A.Transpose().Display();

        Console.WriteLine("Porównanie A i A:");
        Console.WriteLine(A == A ? "Macierze są równe.\n" : "Macierze są różne.\n");

        Console.WriteLine("Porównanie A i B:");
        Console.WriteLine(A == B ? "Macierze są równe.\n" : "Macierze są różne.\n");
    }
}
