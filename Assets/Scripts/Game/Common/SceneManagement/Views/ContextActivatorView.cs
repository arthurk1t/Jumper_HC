using UnityEngine;
using Zenject;

public class ContextActivatorView : MonoBehaviour
{
    [SerializeField] private SceneContext _sceneContext;

    private void Awake()
    {
        if (!_sceneContext.Initialized)
        {
                _sceneContext.Run();
        }
    }
}