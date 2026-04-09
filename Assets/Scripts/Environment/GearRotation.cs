using UnityEngine;

/// <summary>
/// Rotazione continua di un ingranaggio placeholder.
/// Velocità e direzione sono configurabili per creare ritmo meccanico disturbante.
/// </summary>
public class GearRotation : MonoBehaviour
{
    [SerializeField] private float speed = 35f;

    private void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
