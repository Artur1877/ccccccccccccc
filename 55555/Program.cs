﻿int[] array = { 1, 2, 322, 83, 15, 62, 73, 83 };

int n = array.Length;
int find = 83;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}