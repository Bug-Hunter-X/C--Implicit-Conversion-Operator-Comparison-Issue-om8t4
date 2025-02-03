# C# Implicit Conversion Operator Comparison Issue
This example demonstrates an uncommon issue related to implicit conversion operators in C#.  The code defines implicit conversions between an integer and a custom class `MyClass`. While implicit conversion allows seamless assignment between `MyClass` and `int`, direct comparison using `==` between a `MyClass` instance and an integer leads to a compiler error.  This is because the compiler doesn't automatically apply the implicit operator for comparisons.  The solution showcases a proper way to handle this comparison by explicitly converting one of the operands.