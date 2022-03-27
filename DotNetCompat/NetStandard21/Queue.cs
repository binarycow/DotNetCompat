﻿#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER)

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DotNetCompat.InternalExtensions;

namespace DotNetCompat.NetStandard21;

public static class Queue
{
    public static bool TryDequeue<T>(this Queue<T> stack, [MaybeNullWhen(false)] out T result) 
        => (stack.Count is 0
                ? (false, default)
                : (true, stack.Dequeue())
            ).Try(out result);
    
    public static bool TryPeek<T>(this Queue<T> stack, [MaybeNullWhen(false)] out T result)
        => (stack.Count is 0
                ? (false, default)
                : (true, stack.Peek())
            ).Try(out result);
}

#endif