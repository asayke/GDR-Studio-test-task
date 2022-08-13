using TMPro;
using UnityEngine;
using System;

public class UICoinsScore : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    private int _coinsCount;
    public static Action OnCoinTriggered;

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _textMeshProUGUI.SetText($"Coins : {_coinsCount}");
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
        _textMeshProUGUI.SetText($"Coins : {_coinsCount}");
    }
}