using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Trigger minimale per il passaggio di scena.
/// Viene usato, in questa iterazione, per la transizione Scene1 -> Scene2.
/// </summary>
public class SceneTransition : MonoBehaviour
{
    [SerializeField] private string targetSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(targetSceneName))
        {
            Debug.LogWarning("SceneTransition: targetSceneName non impostato.");
            return;
        }

        SceneManager.LoadScene(targetSceneName);
    }
}
