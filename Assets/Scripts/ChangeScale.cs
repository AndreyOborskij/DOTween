using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private float _zoom = 2f;
    private float _duration = 3f;
    private int _repeats = -1;
    private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOScale(_zoom, _duration)
            .SetLoops(_repeats, _loopType);
    }
}
