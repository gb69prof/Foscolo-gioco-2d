using UnityEngine;

/// <summary>
/// Controller essenziale per audio ambientale di scena.
/// In questa base gestisce volume e loop di una singola sorgente.
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class AmbientAudioController : MonoBehaviour
{
    [SerializeField] private float volume = 0.35f;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.volume = volume;
    }
}
