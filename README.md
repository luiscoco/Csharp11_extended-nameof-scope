# Csharp11_extended-nameof-scope

In C# 11, the extended nameof operator was introduced as a new language feature. The nameof operator allows you to obtain the name of a variable, type, or member at compile-time as a string. The extended nameof operator enhances this functionality by allowing you to get the name of a member from an outer scope, including the containing type.

Here's an example to illustrate how the extended nameof operator works:

```csharp
using System;

class MyClass
{
    private int myField;

    public void MyMethod()
    {
        Console.WriteLine(nameof(myField));  // Output: myField
        Console.WriteLine(nameof(MyMethod)); // Output: MyMethod
        Console.WriteLine(nameof(MyClass));  // Output: MyClass

        Console.WriteLine(GetOuterMemberName()); // Output: MyMethod
    }

    private string GetOuterMemberName() => nameof(MyMethod);
}

class Program
{
    static void Main()
    {
        MyClass myObj = new MyClass();
        myObj.MyMethod();
    }
}
```

In the above example, the nameof operator is used to obtain the names of the myField field, MyMethod method, and MyClass class. These names are resolved at compile-time, so if you were to change the actual names of these members, the nameof expressions would still refer to the original names.

Additionally, the GetOuterMemberName method demonstrates how to use the extended nameof operator to retrieve the name of a member from an outer scope. In this case, it retrieves the name of the MyMethod method from within the MyClass type.

The extended nameof operator is useful in scenarios where you need to refer to members by name as strings, such as when working with reflection, debugging, or implementing certain patterns.
