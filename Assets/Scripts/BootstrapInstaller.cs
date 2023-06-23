using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject _dataHolderprefab;
    [SerializeField]
    private GameObject _sceneLoaderPrefab;

    public override void InstallBindings()
    {
        InstallDataHolder();
        InstallSceneLoader();
    }

    private void InstallDataHolder()
    {
        DataHolder dataHolderInstance = Container.InstantiatePrefabForComponent<DataHolder>
            (_dataHolderprefab, new Vector3(0, 0, 0), Quaternion.identity, null);
        Container.Bind<DataHolder>().FromInstance(dataHolderInstance).AsSingle().NonLazy();
    }

    private void InstallSceneLoader()
    {
        SceneLoader sceneLoaderInstance = Container.InstantiatePrefabForComponent<SceneLoader>
            (_sceneLoaderPrefab, new Vector3(0, 0, 0), Quaternion.identity, null);
        Container.Bind<SceneLoader>().FromInstance(sceneLoaderInstance).AsSingle().NonLazy();
    }
}