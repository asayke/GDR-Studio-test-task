using UnityEngine;

public class ThornPlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject, 0.1f);
        
    }
}
