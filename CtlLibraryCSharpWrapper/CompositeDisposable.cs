using System;
using System.Collections.Generic;

public class CompositeDisposable : IDisposable
{
    private List<IDisposable> _disposables = new List<IDisposable>();

    public void Add( IDisposable disposable )
    {
        _disposables.Add( disposable );
    }

    public void Dispose()
    {
        foreach ( var disposable in _disposables )
        {
            disposable.Dispose();
        }

        _disposables.Clear();
    }
}