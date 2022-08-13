using UnityEngine;

public class CoinPlayerCollsion : MonoBehaviour
{
    [SerializeField] private LayerMask _playerLayerMask;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == _playerLayerMask)
        {
            Destroy(gameObject, 0.1f);
            UICoinsScore.OnCoinTriggered?.Invoke();
        }
    }
}