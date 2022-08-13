using System.Collections;
using UnityEngine;

public class ThornPlayerCollision : MonoBehaviour
{
    [SerializeField] private LayerMask _playerLayerMask;
    [SerializeField] private float _playerDisableTime;

    private IEnumerator DisablePlayer(GameObject other)
    {
        yield return new WaitForSeconds(_playerDisableTime);
        other.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.IsInLayerMask(_playerLayerMask))
        {
            StartCoroutine(DisablePlayer(other.gameObject));
            UIGameOver.OnDied?.Invoke();
        }
    }
}