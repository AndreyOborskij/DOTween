using DG.Tweening;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float _duration = 3f;
    private int _repeats = -1;

    private void Start()
    {
        transform.DORotate(new Vector3(360f, 0f, 0f), _duration, RotateMode.FastBeyond360)
            .SetLoops(_repeats)
            .SetEase(Ease.Linear);
    }
}
