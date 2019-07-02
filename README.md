# CaseInsensitiveStringCompare
This is a quick C# .NET Standard extension method for case-insensitive string comparison.
The method was copied from https://github.com/shaynevanasperen/Quarks/blob/master/Quarks/StringExtensions/Contains.cs. That repo is not .NET standard, and has not seen attention in years.

The method that Quarks built, and which I copied, is based off of an example found here: https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?redirectedfrom=MSDN&view=netframework-4.8#System_String_Contains_System_String_


You would use the method thus for case-insensitive comparison:

```csharp
using CaseInsensitiveStringCompare;

var input = "I want pizza";
var rslt = input.Contains("PiZzA", false);
// rslt will be "true"
```

Or, for traditional case-sensitive comparison, you could do this:

```csharp
using CaseInsensitiveStringCompare;

var input = "I want pizza";
var rslt = input.Contains("PiZzA", false);
//rslt will be "false"
```
