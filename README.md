Library that (conditionally) adds methods to older versions of .NET

For example, .NET Standard 2.1 adds `Stack.TryPop` and `Queue.TryDequeue`.  

This library adds extension methods for those methods, but only if you're using .NET Standard 2.0 or the .NET Framework.
