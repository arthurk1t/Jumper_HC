using UnityEngine;
using Zenject;
using System;

namespace Assets.Scripts
{
    public class MovementInstaller : MonoInstaller
    {
        //[SerializeField] private BallView _ballView;

        public override void InstallBindings()
        {
            //var ballViewInstance = Container.InstantiatePrefabForComponent<BallView>(_ballView); 
            //Container.BindInterfacesTo<BallView>().FromInstance(ballViewInstance);
            
            Container.BindInterfacesTo<BallView>().FromComponentInHierarchy(false).AsSingle();
            Container.BindInterfacesTo<Ball>().AsSingle();
            Container.Bind<TriggerBallController>().AsSingle().NonLazy();

            Container.BindInterfacesTo<CylinderView>().FromComponentInHierarchy(false).AsSingle();
            Container.BindInterfacesTo<Cylinder>().AsSingle();
            
            Container.BindInterfacesTo<MovementController>().AsSingle();
            Container.BindInterfacesTo<UpdateMediator>().AsSingle().NonLazy();
        }
    }
}