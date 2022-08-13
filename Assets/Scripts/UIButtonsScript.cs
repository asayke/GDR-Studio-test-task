using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonsScript : MonoBehaviour
{
    public void RestartGame() => SceneManager.LoadScene("SampleScene");
}