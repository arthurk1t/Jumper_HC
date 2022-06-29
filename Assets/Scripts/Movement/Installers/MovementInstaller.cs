using Zenject;

namespace Assets.Scripts
{
    public class MovementInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<CylinderView>().FromComponentInHierarchy(false).AsSingle();
            Container.BindInterfacesTo<Cylinder>().AsSingle();
            
            Container.BindInterfacesTo<MovementController>().AsSingle();
            Container.BindInterfacesTo<UpdateMediator>().AsSingle().NonLazy();
        }
    }
}