using UnityEngine;

public class WinGameChecker : MonoBehaviour
{
    private void Update()
    {
        if (UICoinsScore.ActualCoinsCount == GameParameters.MaxCoinsCount)
        {
            UIWinGame.OnWinned?.Invoke();
        }
    }
}