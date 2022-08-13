using System;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gameOverTextMeshProUGUI;
    [SerializeField] private GameObject _restartButton;
    public static Action OnDied;

    private void Start()
    {
        _gameOverTextMeshProUGUI.enabled = false;
        _restartButton.SetActive(false);
    }

    private void OnEnable()
    {
        OnDied += ShowGameOverText;
        OnDied += ShowRestartButton;
    }

    private void OnDisable()
    {
        OnDied -= ShowGameOverText;
        OnDied -= ShowRestartButton;
    }

    private void ShowGameOverText() => _gameOverTextMeshProUGUI.enabled = true;

    private void ShowRestartButton() => _restartButton.SetActive(true);
}