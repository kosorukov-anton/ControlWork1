Console.Clear();
//{"Russia", "Denmark", "Kazan"}
//{"1234", "1567", "-2", "computer science"}
//{"hello","2","world",":-)"}

//Initial data
string[] arraySource={"1234", "1567", "-2", "computer science"};
int size=3;

//Method.Show array
void ShowArray(string[] array)
{
    for (int i=0;i<array.Length;i++)  {Console.Write(array[i]+" ");}
    Console.WriteLine();
}

//Method.Find number of elements wich length is less then 3 in array
int FindNumberOfElemnts(string[] array, int size)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) {j++;}
    }
    return j;
}

//Method.Create new array from initial array
string[] CreteStringArray(string[] array, int j, int size)
{
    string[] rezultArray=new string[j];
    if (j>0)
    {
        int k=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= size) {rezultArray[k]=array[i]; k++;}
        }
        return rezultArray;
    }
    else {return rezultArray;}
}

//Calculation
ShowArray(arraySource);
int j = FindNumberOfElemnts(arraySource, size);
string[] rezult = CreteStringArray(arraySource, j, size);
ShowArray(rezult); 