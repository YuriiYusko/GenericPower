using GenericPower;

var stack = new BasicStack<double>();
var stackString = new BasicStack<String>();

stack.Push(4.5);
stack.Push(43);
stack.Push(333.6);

stackString.Push("Yurii");
stackString.Push("Yusko");
stackString.Push("Test");

while(stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
}
Console.WriteLine();

while (stackString.Count > 0)
{
    Console.WriteLine($"Item: {stackString.Pop()}");
}
Console.WriteLine();