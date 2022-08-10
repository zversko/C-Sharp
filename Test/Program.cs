    Console.WriteLine("Введите натуральное число");
    int NatNum = int.Parse(Console.ReadLine());
    int digitCount = (int)Math.Log10(NatNum) + 1;
    int[] array = new int[digitCount];
    int index = 0;
    int index2 = digitCount -1;
    while(index < digitCount)
    {
        array[digitCount - index - 1] = NatNum % 10;
        NatNum = NatNum / 10;
        Console.WriteLine($"a[{digitCount - index - 1}] = {array[digitCount - index - 1]}", index + 1);
        index++;
    }