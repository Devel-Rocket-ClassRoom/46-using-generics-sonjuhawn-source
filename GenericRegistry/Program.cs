using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    public TKey[] keyary { get; set; }
    public TValue[] valueary { get; set; }
    private int count = 0;

    public Registry(int capacity)
    {
        keyary = new TKey[capacity];
        valueary = new TValue[capacity];
    }
    public void Register(TKey key, TValue value)
    {
        keyary[count] = key;
        valueary[count++] = value;
    }

    public TValue Find(TKey key)
    {
        for(int i = 0; i < count; i++)
        {

        }
    }
    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"[{keyary[i]}] {valueary[i]}");
        }
    }
}