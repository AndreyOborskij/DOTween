using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private Sequence _sequence;
    private int _repeats = -1;
    private LoopType _loopType = LoopType.Restart;

    private void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText("Замененный текст", 3f));
        _sequence.Append(_text.DOText("Плюс дополнение", 3f).SetRelative());
        _sequence.Append(_text.DOText("Замена перебором", 3f, true, ScrambleMode.All));
        _sequence.SetLoops(_repeats, _loopType);
    }
}
