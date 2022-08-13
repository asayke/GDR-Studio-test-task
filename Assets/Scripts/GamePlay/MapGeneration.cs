using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _thornPrefab;
    private float minX = -8f;
    private float minY = -5.8f;
    
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    private void Start()
    {
        SpawnThorns();
        SpawnCoins();
    }

    private bool IsSpawnNotAvalible(Vector2 point)
    {
        return point.x < minX && point.y < minY;
    }

    private void SpawnThorns()
    {
        for (int i = 1; i <= GameParameters.MaxThornsCount; i++)
        {
            Vector2 randomPointOnScreen = _mainCamera.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            if (IsSpawnNotAvalible(randomPointOnScreen)) i--;
            Instantiate(_thornPrefab, randomPointOnScreen, Quaternion.identity);
        }
    }

    private void SpawnCoins()
    {
        for (int i = 1; i <= GameParameters.MaxCoinsCount; i++)
        {
            Vector2 randomPointOnScreen = _mainCamera.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            if (IsSpawnNotAvalible(randomPointOnScreen)) i--;
            Instantiate(_coinPrefab, randomPointOnScreen, Quaternion.identity);
        }
    }
}