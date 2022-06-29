using UnityEngine;
using Zenject;
namespace Assets.Scripts
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
           // Container.Bind<IUpdatable>().FromResolve(); 
           // Container.BindInterfacesTo<UpdateMediator>().AsSingle().NonLazy();
        }
    }
}