using UnityEngine;
using DG.Tweening;

public class CoinShaking : MonoBehaviour
{
    [SerializeField] private float _shakeDuration;
    [SerializeField] private float _shakeStrength;

    private void Start()
    {
        transform.DOShakePosition(_shakeDuration, _shakeStrength).SetLoops(-1, LoopType.Yoyo);
    }
}