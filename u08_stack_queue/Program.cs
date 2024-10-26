Queue<int> kuyruk = new Queue<int>();

kuyruk.Enqueue(3);
kuyruk.Enqueue(8);
kuyruk.Enqueue(2);

Console.WriteLine("Queue:");
while(kuyruk.Count>0)
{
    Console.WriteLine(kuyruk.Dequeue());
}
Console.WriteLine("Stack:");
Stack<int> yigin = new Stack<int>();

yigin.Push(3);
yigin.Push(8);
yigin.Push(2);

while(yigin.Count>0)
{
    Console.WriteLine(yigin.Pop());
}