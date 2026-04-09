using UnityEngine;

/// <summary>
/// Attiva un testo breve quando il player entra in un'area.
/// Pensato per interazioni essenziali e non invasive.
/// </summary>
public class InteractionTrigger : MonoBehaviour
{
    [TextArea(2, 4)]
    [SerializeField] private string message = "La materia si muove. Non consola. Non ricorda. Non ama.";

    [SerializeField] private DialogueBox dialogueBox;
    [SerializeField] private bool oneShot = true;

    private bool hasBeenTriggered;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasBeenTriggered && oneShot)
        {
            return;
        }

        if (other.GetComponent<PlayerController>() == null)
        {
            return;
        }

        if (dialogueBox != null)
        {
            dialogueBox.Show(message);
            hasBeenTriggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == null)
        {
            return;
        }

        dialogueBox?.Hide();
    }
}
