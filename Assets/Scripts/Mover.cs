using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;

    private float _duration = 3f;
    private int _repeats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOMove(_position, _duration)
            .SetLoops(_repeats, _loopType);
    }
}
