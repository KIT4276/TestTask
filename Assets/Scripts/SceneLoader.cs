using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class SceneLoader : MonoBehaviour
{
    [Inject]
    private DataHolder _dataHolder;
    
    public void LoadRedScene1()
    {
        _dataHolder.AddColor(Color.red);
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadGreedScene1()
    {
        _dataHolder.AddColor(Color.green);
        SceneManager.LoadSceneAsync(1);
    }

    public void BackToStart()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
