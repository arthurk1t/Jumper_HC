using Engine.Mediators;
using Engine.UnityEvent;
using Zenject;

namespace Game.Common.Installers
{
    public class SharedInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            //Container.BindInterfacesTo<UnityEventRegisterMediator>().AsSingle();
            Container.BindInterfacesTo<EngineEventSceneMediator>().AsSingle();
        }
    }
}