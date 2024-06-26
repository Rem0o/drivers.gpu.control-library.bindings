﻿using System;

public class DisposeAction : IDisposable
{
    private Action _disposeAction;

    public DisposeAction( Action disposeAction )
    {
        _disposeAction = disposeAction;
    }

    public void Dispose()
    {
        _disposeAction.Invoke();
    }
}
