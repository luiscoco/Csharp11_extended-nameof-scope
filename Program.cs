using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

//----------------------------------------------------------------------------------------
//Sample code for C# version 11 and later (with Extended nameof):
//----------------------------------------------------------------------------------------

string? text = null;
Console.WriteLine(nameof(text)); // Output: text

// With extended nameof in C# 11
Console.WriteLine(nameof(text.Length)); // Output: Length
Console.WriteLine(nameof(Console.WriteLine)); // Output: WriteLine
Console.WriteLine('\n'); // Output: WriteLine

//----------------------------------------------------------------------------------------
//Sample code for C# versions before 11 (without Extended nameof):
//----------------------------------------------------------------------------------------

string? text1 = null;
Console.WriteLine(nameof(text1)); // Output: text

// Without extended nameof in C# versions before 11
Console.WriteLine(GetMemberName(() => text1.Length)); // Output: Length
//Console.WriteLine(GetMethodName(() => Main)); // Output: Main
//Console.WriteLine(GetMethodName(() => Console.WriteLine)); // Output: WriteLine

static string GetMemberName<T>(Expression<Func<T>> expression)
{
    if (expression.Body is MemberExpression memberExpression)
        return memberExpression.Member.Name;
    throw new ArgumentException("Expression is not a member access", nameof(expression));
}

static string GetMethodName(Expression<Action> expression)
{
    if (expression.Body is MethodCallExpression methodCallExpression)
        return methodCallExpression.Method.Name;
    throw new ArgumentException("Expression is not a method call", nameof(expression));
}