using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Common.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller
    {
        public UIController UIController;
        public CamPivotController CameraController;
        public PlayerController PlayerController;
        public InputService InputService;
        public override void InstallBindings()
        {
            BindUIController();
            BindCameraController();
            BindPlayerController();
            BindInputService();
        }

        private void BindUIController()
        {
            Container.Bind<UIController>().FromInstance(UIController).AsSingle();
        }
        private void BindCameraController()
        {
            Container.Bind<CamPivotController>().FromInstance(CameraController).AsSingle();
        }

        private void BindPlayerController()
        {
            Container.Bind<PlayerController>().FromInstance(PlayerController).AsSingle();
        }
        
        private void BindInputService()
        {
            Container.Bind<InputService>().FromInstance(InputService).AsSingle();
        }
    }
}
