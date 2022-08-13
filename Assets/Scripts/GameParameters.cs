using UnityEngine;

public class GameParameters : MonoBehaviour
{
    [SerializeField] private int _coinsCount;
    [SerializeField] private int _thornsCount;

    public static int MaxCoinsCount { get; private set; }
    public static int MaxThornsCount { get; private set; }

    private void Awake()
    {
        MaxCoinsCount = _coinsCount;
        MaxThornsCount = _thornsCount;
    }
}