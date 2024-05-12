using Zenject;

namespace Common.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller
    {
        public SceneDataContainer SceneDataContainer;
        public SceneLoader SceneLoader;
        
        public override void InstallBindings()
        {
            BindSceneDataContainer();
            BindSceneLoader();
        }

        
        
        private void BindSceneDataContainer()
        {
            Container.Bind<SceneDataContainer>().FromComponentInNewPrefab(SceneDataContainer).AsSingle();
        }
        
        private void BindSceneLoader()
        {
            Container.Bind<SceneLoader>().FromComponentInNewPrefab(SceneLoader).AsSingle();
        }
        
    }
}
