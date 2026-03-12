using System;
using System.Collections.Generic;
using System.Text;

class MyStack<T>
{
    T[] stack;
    int count;
    public int Count { get => count; }
    public bool IsEmpty { get => count == 0; }
    public MyStack(int capacity)
    {
        stack = new T[capacity];
        count = 0;
    }
    public void Push(T item)
    {
        stack[count++] = item;
    }
    public T Pop()
    {
        return stack[--count];
    }
    public T Peek()
    {
        return stack[count - 1];
    }

}