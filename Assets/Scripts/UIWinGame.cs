using System;
using TMPro;
using UnityEngine;

public class UIWinGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _winGameTextMeshProUGUI;
    [SerializeField] private GameObject _restartButton;
    public static Action OnWinned;

    private void Start()
    {
        _winGameTextMeshProUGUI.enabled = false;
        _restartButton.SetActive(false);
    }

    private void OnEnable()
    {
        OnWinned += ShowGameOverText;
        OnWinned += ShowRestartButton;
    }

    private void OnDisable()
    {
        OnWinned -= ShowGameOverText;
        OnWinned -= ShowRestartButton;
    }

    private void ShowGameOverText() => _winGameTextMeshProUGUI.enabled = true;

    private void ShowRestartButton() => _restartButton.SetActive(true);
}