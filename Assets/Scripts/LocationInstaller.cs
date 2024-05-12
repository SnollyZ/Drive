using UnityEngine.Serialization;
using Zenject;


namespace Common.Infrastructure
{
    public class LocationInstaller : MonoInstaller
    {
        [FormerlySerializedAs("UIController")] public GarageUIController garageUIController;
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
            Container.Bind<GarageUIController>().FromInstance(garageUIController).AsSingle();
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
