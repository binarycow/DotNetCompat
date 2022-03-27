using System.Diagnostics.CodeAnalysis;

namespace DotNetCompat.InternalExtensions;

internal static class TupleExtensions
{
    public static bool Try<T>(this (bool Success, T Result) tuple, out T result)
    {
        result = tuple.Result;
        return tuple.Success;
    }
}