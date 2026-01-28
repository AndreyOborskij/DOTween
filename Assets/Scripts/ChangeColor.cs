using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    private Color _secondColor = Color.red;
    private float _duration = 3f;
    private int _repeats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _meshRenderer.material.DOColor(_secondColor, _duration).SetLoops(_repeats, _loopType);
    }
}
