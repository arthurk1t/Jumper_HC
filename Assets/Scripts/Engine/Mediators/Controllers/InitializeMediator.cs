using System;
using System.Collections.Generic;
using System.Linq;
using Zenject;

namespace Engine.Mediators
{
    public class InitializeMediator : Zenject.IInitializable, IInitializeMediator, IDisposable
    {
        public event Action OnDone;

        private readonly List<ICommonInitializable> _commonInitializables;
        private readonly List<IOrderedInitializable> _orderedInitializables;
        private readonly List<IDataInitializable> _dataInitializables;

        public InitializeMediator(
            [Inject(Optional = true, Source = InjectSources.Local)] List<ICommonInitializable> commonInitializables, 
            [Inject(Optional = true, Source = InjectSources.Local)] List<IOrderedInitializable> orderedInitializables,
            [Inject(Optional = true, Source = InjectSources.Local)] List<IDataInitializable> dataInitializables)
        {
            _commonInitializables = commonInitializables;
            _orderedInitializables = orderedInitializables;
            _dataInitializables = dataInitializables;
        }

        public void Initialize()
        {
            foreach (var item in _dataInitializables)
            {
                item.Initialize();
            }

            var ordered = _orderedInitializables.OrderBy(x => x.InitializationOrder);
            foreach (var item in ordered)
            {
                item.Initialize();
            }

            foreach (var item in _commonInitializables)
            {
                item.Initialize();
            }
            OnDone?.Invoke();
        }

        public void Dispose()
        {
            OnDone = null;
        }
    }
}