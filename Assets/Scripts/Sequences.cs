using DG.Tweening;
using UnityEngine;

public class Sequences : MonoBehaviour
{
    [SerializeField] private Vector3 _position;

    private Sequence _sequence;
    private float _duration = 3f;
    private int _repeats = -1;
    private float _zoom = 2f;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(transform.DOMove(_position, _duration));
        _sequence.Join(transform.DOScale(_zoom, _duration));
        _sequence.SetLoops(_repeats, _loopType);

        transform.DORotate(new Vector3(360f, 0f, 0f), _duration, RotateMode.FastBeyond360)
            .SetLoops(_repeats)
            .SetEase(Ease.Linear);
    }
}
