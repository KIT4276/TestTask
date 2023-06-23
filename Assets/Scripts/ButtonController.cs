using UnityEngine;
using Zenject;

public class ButtonController : MonoBehaviour
{
    [Inject]
    private SceneLoader _sceneLoader;

    public void RedButton()
    {
        _sceneLoader.LoadRedScene1();
    }

    public void GreenButton()
    {
        _sceneLoader.LoadGreedScene1();
    }

    public void Back()
    {
        _sceneLoader.BackToStart();
    }
}
