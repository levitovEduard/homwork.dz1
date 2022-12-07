// Написать программу которая принимает на вход число (N), а на выходе показывает все четные числа от 1 до N.
{  
    {
         int num;
         int ind =2;
         
         num = Convert.ToInt32(Console.ReadLine());

         while (ind <= num)
    {
         Console.WriteLine (ind);
         ind= ind+2;
    }
        
    }
}
