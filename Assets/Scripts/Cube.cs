using UnityEngine;
using Zenject;


public class Cube : MonoBehaviour
{
    [Inject]
    private DataHolder _dataHolder;

    private void Start()
    {
       gameObject.GetComponent<MeshRenderer>().materials[0].color = _dataHolder.GetColor();
    }
}
