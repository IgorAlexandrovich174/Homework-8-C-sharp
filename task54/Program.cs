//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

void PrintMatrix(int[,] matr) {
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++) {
            System.Console.Write(matr[i, j] + "\t");
        }
    System.Console.WriteLine();
    }
}




int[,] ArraySort(int[,] inputArray) {

    int[,] result = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++) {
        for (int j = 0; j < inputArray.GetLength(1); j++) {
            result[i,j] = inputArray[i,j];
        }
    }

    for (int i = 0; i < result.GetLength(0); i++) {
        for (int j = 0; j < result.GetLength(1) - 1; j++) {
            if (result[i,j] < result[i,j + 1]) {
                int temp = result[i,j + 1];
                result[i,j + 1] = result[i,j];
                result[i, j] = temp;
           }
        }
    }
    if(result[0,0] < result[0,1]) {
        int temp = result[0,0];
        result[0,0] =  result[0,1];
        result[0,1] = temp;
    }
    PrintMatrix(result);
    return result;
}


int[,] array = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};

ArraySort(array);