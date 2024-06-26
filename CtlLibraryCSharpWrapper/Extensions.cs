﻿
using CtlLibraryBindings;
using System;

public static class Extensions
{
    public static ctl_result_t ThrowIfError(this ctl_result_t result, string context)
    {
        if (result != ctl_result_t.CTL_RESULT_SUCCESS)
        {
            throw new Exception($"{context} Error: {result}");
        }

        return result;
    }

    public static T DisposeWith<T>(this T disposable, CompositeDisposable compositeDisposable)
        where T : IDisposable
    {
        compositeDisposable.Add(disposable);
        return disposable;
    }

    public static T DisposeWith<T>(this T disposable, CompositeDisposable compositeDisposable, Action<T> disposeMethod)
    {
        compositeDisposable.Add(new DisposeAction(() => disposeMethod(disposable)));
        return disposable;
    }
}
