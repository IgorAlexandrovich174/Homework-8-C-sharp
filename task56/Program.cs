//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//
//Например, задан массив:
//
//1 4 7 2
//
//5 9 2 3
//
//8 4 2 4
//
//5 2 6 7
//
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//Метод подсчёта суммы элементов первой строки
int SumElementsFirstRow(int[,] inputArray) {
    int result = 0;

    for (int i = 0; i < inputArray.GetLength(1); i++) {
        result += inputArray[0,i];
    }
    return result;
}

//Метод поиска строки с минимальным суммарным числом элементов
int RowSumMinElements(int[,] inputArray) {
    int result = SumElementsFirstRow(inputArray);
    int numberRow = 1;

    for (int i = 1; i < inputArray.GetLength(0); i++) {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++) {
            sum += inputArray[i,j];
        }
        if(sum < result) {
            result = sum;
            numberRow = ++i;
        }
    }
    
    System.Console.WriteLine($"{numberRow} строка: сумма элементов равна {result}");
    return result;
}

int[,] array = {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};

RowSumMinElements(array);