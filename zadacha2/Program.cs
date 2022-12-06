// Написать программу которая на вход принимает три числа и выдает м эттих трех чисел.

int num1 =7, num2 = 23, num3= 71, max; 
   

        max = num1;

        if(max < num2)
        {
            max = num2;
        }
        if(max < num3)
        {
            max = num3;
        }
        Console.WriteLine(max);
