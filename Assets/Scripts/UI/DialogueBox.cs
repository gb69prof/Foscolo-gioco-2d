using UnityEngine;

/// <summary>
/// Box testo minimale disegnato a schermo con OnGUI.
/// Evita UI complessa in questa prima iterazione.
/// </summary>
public class DialogueBox : MonoBehaviour
{
    [SerializeField] private bool visible;
    [SerializeField] private string currentMessage = string.Empty;
    [SerializeField] private Vector2 size = new Vector2(760f, 90f);

    public void Show(string message)
    {
        currentMessage = message;
        visible = true;
    }

    public void Hide()
    {
        visible = false;
    }

    private void OnGUI()
    {
        if (!visible || string.IsNullOrWhiteSpace(currentMessage))
        {
            return;
        }

        float x = (Screen.width - size.x) * 0.5f;
        float y = Screen.height - size.y - 20f;
        GUI.Box(new Rect(x, y, size.x, size.y), currentMessage);
    }
}
