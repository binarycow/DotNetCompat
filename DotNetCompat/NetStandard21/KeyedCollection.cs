using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

#if !(NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER)

// ReSharper disable once CheckNamespace
namespace System.Collections.Generic;

public static partial class KeyedCollection
{
    public static bool TryGetValue<TKey, TItem> (
        this KeyedCollection<TKey, TItem> dict,
        TKey key,
        [MaybeNullWhen(false)] out TItem item
    )
    {
        if (dict.Contains(key))
        {
            item = dict[key];
            return true;
        }
        item = default;
        return false;
    }
}

#endif