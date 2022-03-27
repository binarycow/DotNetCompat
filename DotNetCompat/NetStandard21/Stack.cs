#if !NETSTANDARD2_1_OR_GREATER

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetCompat.InternalExtensions;

namespace DotNetCompat.NetStandard21;

public static class Stack
{
    public static bool TryPop<T>(this Stack<T> stack, [MaybeNullWhen(false)] out T item) 
        => (stack.Count is 0
            ? (false, default)
            : (true, stack.Pop())
        ).Try(out item);
}

#endif