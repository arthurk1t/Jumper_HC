using UnityEngine;
using Engine.UnityEvent;
using Zenject;
namespace Assets.Scripts
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<EngineEventProjectMediator>().AsSingle().NonLazy();
        }
    }
}