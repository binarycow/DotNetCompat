#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER)

using System.Diagnostics.CodeAnalysis;
using DotNetCompat.InternalExtensions;

// ReSharper disable once CheckNamespace
namespace System.Collections.Generic;

public static partial class Stack
{
    public static bool TryPop<T>(this Stack<T> stack, [MaybeNullWhen(false)] out T result) 
        => (stack.Count is 0
            ? (false, default)
            : (true, stack.Pop())
        ).Try(out result);
    
    public static bool TryPeek<T>(this Stack<T> stack, [MaybeNullWhen(false)] out T result)
        => (stack.Count is 0
                ? (false, default)
                : (true, stack.Peek())
            ).Try(out result);
}

#endif