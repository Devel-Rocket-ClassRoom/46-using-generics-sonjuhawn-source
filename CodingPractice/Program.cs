using System;
using System.Collections;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
{
    Stack objectStack = new Stack();
    objectStack.Push(100);
    objectStack.Push(200);

    int value1 = (int)objectStack.Pop();
    int value2 = (int)objectStack.Pop();

    Console.WriteLine($"값1: {value1}, 값2: {value2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Stack<int> objectStack = new Stack<int>();
    objectStack.Push(100);
    objectStack.Push(200);

    int value1 = objectStack.Pop();
    int value2 = objectStack.Pop();

    Console.WriteLine($"값1: {value1}, 값2: {value2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Cup<string> text = new Cup<string>();
    text.Value = "커피";
    Cup<int> ml = new Cup<int>();
    ml.Value = 500;

    Console.WriteLine($"음료: {text.Value}");
    Console.WriteLine($"용량: {ml.Value}ml");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Pair<string, int> hero = new Pair<string, int>("용사", 100);
    Pair<int, double> student = new Pair<int, double>(1, 95.5);

    Console.WriteLine($"이름: {hero.T1}, HP: {hero.T2}");
    Console.WriteLine($"순위: {student.T1}, 점수: {student.T2}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    int x = 10;
    int y = 20;
    Console.WriteLine($"교환 전: x={x}, y={y}");
    Swap<int>(ref x, ref y);
    Console.WriteLine($"교환 후: x={x}, y={y}");

    string first = "사과";
    string second = "바나나";
    Console.WriteLine($"교환 전: first={first}, second={second}");
    Swap<string>(ref first, ref second);
    Console.WriteLine($"교환 후: first={first}, second={second}");

    void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    NumberContainer<int> num1 = new NumberContainer<int>();
    num1.value = 100;
    Console.WriteLine($"정수값: {num1.value}");
    NumberContainer<double> num2 = new NumberContainer<double>();
    Console.WriteLine($"실수값: {num2.value}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Monster monster = CreateInstance<Monster>();

    Console.WriteLine($"생성된 몬스터: {monster.name}, HP: {monster.hp}");
    T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    int maxInt = GetMax(10, 25);
    Console.WriteLine($"더 큰 정수: {maxInt}");

    string maxString = GetMax("apple", "banana");
    Console.WriteLine($"사전순 뒤: {maxString}");

    T GetMax<T>(T x, T y) where T : IComparable
    {
        return x.CompareTo(y) > 0 ? x : y;
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    int i = GetDefaultValue<int>();
    Console.WriteLine($"int 기본값: {i}");
    bool b = GetDefaultValue<bool>();
    Console.WriteLine($"int 기본값: {b}");
    string s = GetDefaultValue<string>();
    Console.WriteLine($"int 기본값: {s ?? "(null)"}");

    T GetDefaultValue<T>()
    {
        return default(T);
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    List<string> student = new List<string>();
    student.Add("철수");
    student.Add("영희");
    student.Add("민수");

    Console.WriteLine("이름 목록:");
    foreach(string s in student)
    {
        Console.WriteLine($"- {s}");
    }

    Dictionary<string, int> scores = new Dictionary<string, int>();
    scores["철수"] = 95;
    scores["영희"] = 88;
    scores["민수"] = 92;

    Console.WriteLine("점수:");
    foreach (var s in scores)
    {
        Console.WriteLine($"{s.Key}: {s.Value}");
    }
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    var special = new SpecialContainer<string>();
    special.name = "특별한 아이템";
    special.special = "레어등급";
    Console.WriteLine($"{special.name} ({special.special})");
    var num = new IntContainer();
    num.name = 50;

    Console.WriteLine($"값: {num.name}, 두 배: {num.Double}");
}
Console.WriteLine("'''\n");

Console.WriteLine("'''");
{
    Counter<int>.count++;
    Counter<int>.count++;
    Counter<string>.count++;
    Console.WriteLine($"Counter<int>.Count: {Counter<int>.count}");
    Console.WriteLine($"Counter<int>.Count: {Counter<string>.count}");
}
Console.WriteLine("'''\n");

class Cup<T>
{
    public T Value { get; set; }
}

class Pair<TFirst, TSecond>
{
    public TFirst T1 { get; set; }
    public TSecond T2 { get; set; }
    public Pair(TFirst first, TSecond second)
    {
        T1 = first;
        T2 = second;
    }
}

class NumberContainer<T> where T : struct
{
    public T value { get; set; }
}

class Monster
{
    public string name { get; set; } = "슬라임";
    public int hp { get; set; } = 50;
}

class Container<T>
{
    public T name { get; set; }
}
class SpecialContainer<T> : Container<T>
{
    public string special { get; set;  }
}
class IntContainer : Container<int>
{
    public int Double => name * 2;
}

static class Counter<T>
{
    static public int count = 0;
}