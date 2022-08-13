using TMPro;
using UnityEngine;
using System;

public class UICoinsScore : MonoBehaviour
{
    private TextMeshProUGUI _coinsScoreTextMeshProUGUI;
    private int _coinsCount;
    public static Action OnCoinTriggered;

    private void Awake()
    {
        _coinsScoreTextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
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
        _coinsScoreTextMeshProUGUI.SetText($"Coins : {_coinsCount}");
    }
}