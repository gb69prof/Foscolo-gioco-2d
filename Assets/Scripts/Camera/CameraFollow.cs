using UnityEngine;

/// <summary>
/// Camera laterale morbida che segue il player solo sull'asse X.
/// Evita movimenti bruschi e preserva un ritmo contemplativo.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 0.2f;

    private Vector3 velocity;

    private void LateUpdate()
    {
        if (target == null)
        {
            return;
        }

        var targetPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
