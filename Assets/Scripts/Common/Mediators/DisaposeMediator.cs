using System.Collections.Generic;
using System;

namespace Assets.Scripts
{
    internal class DisposeMediator
    {
        private readonly List<IDisposable> _disposables;

        public DisposeMediator(List<IDisposable> disposables)
        {
            _disposables = new List<IDisposable>(disposables);
        }

        public void Dispose()
        {
            foreach (var entitie in _disposables)
            {
                entitie.Dispose();
            }
        }
    }
}