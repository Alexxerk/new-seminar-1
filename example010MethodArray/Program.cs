int[] array = { 1, 22, 3, 94, 5, 36, 7, 48, 9 };

int n = array.Length;
int find = 5;

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