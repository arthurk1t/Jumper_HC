using Zenject;

namespace Assets.Scripts
{
    public class BallInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<BallView>().FromComponentInHierarchy(false).AsSingle();
            Container.BindInterfacesTo<Ball>().AsSingle();
            Container.Bind<TriggerBallController>().AsSingle().NonLazy();
        }
    }
}