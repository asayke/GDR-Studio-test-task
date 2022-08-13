using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _thornPrefab;

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

    private void SpawnThorns()
    {
        for (int i = 1; i <= GameParameters.MaxThornsCount; i++)
        {
            Vector2 randomPointOnScreen = _mainCamera.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(_thornPrefab, randomPointOnScreen, Quaternion.identity);
        }
    }

    private void SpawnCoins()
    {
        for (int i = 1; i <= GameParameters.MaxCoinsCount; i++)
        {
            Vector2 randomPointOnScreen = _mainCamera.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(_coinPrefab, randomPointOnScreen, Quaternion.identity);
        }
    }
}