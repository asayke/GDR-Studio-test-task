using TMPro;
using UnityEngine;
using System;

public class UICoinsScore : MonoBehaviour
{
    private TextMeshProUGUI _coinsScoreTextMeshProUGUI;
    private int _coinsCount;
    public static Action OnCoinTriggered;
    public static int ActualCoinsCount { get; private set; }

    private void Awake()
    {
        _coinsScoreTextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        ActualCoinsCount = 0;
        _coinsScoreTextMeshProUGUI.SetText($"Coins : {_coinsCount}");
    }

    private void OnEnable()
    {
        OnCoinTriggered += UpdateCoinsScore;
    }

    private void OnDisable()
    {
        OnCoinTriggered -= UpdateCoinsScore;
    }

    private void UpdateCoinsScore()
    {
        _coinsCount++;
        ActualCoinsCount = _coinsCount;
        _coinsScoreTextMeshProUGUI.SetText($"Coins : {_coinsCount}");
    }
}