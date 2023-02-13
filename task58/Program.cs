//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18



int[,] MultyMatrix(int[,] array1, int[,] array2) {
    if(array1.GetLength(0) != array2.GetLength(1)) {
        System.Console.WriteLine("Размеры матриц не позволяют выполнить произведение!");
        return new int[,] {{},{}};
    }
    int[,] result = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1); j++) {
            result[i,j] = CalculateSingle(array1,array2,i,j);
        }
    }
    return result;
}

int CalculateSingle(int[,] array1, int[,] array2, int x, int y){
    int result = 0;
    for (int i = 0; i < array1.GetLength(1); i++) {
        result += array1[x,i] * array2[i,y];
    }
    return result;   
}

void PrintMatrix(int[,] matr) {
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++) {
            System.Console.Write(matr[i, j] + "\t");
        }
    System.Console.WriteLine();
    }
}

int[,] array = {{2,4},{3,2}};
int[,] array2 = {{3,4},{3,3}};

PrintMatrix(MultyMatrix(array,array2));
