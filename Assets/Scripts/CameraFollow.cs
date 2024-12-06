using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Karakterin transform'u
    public float smoothSpeed = 0.125f; // Yumuşak geçiş hızı
    public Vector3 offset; // Kameranın karakterden ne kadar uzak olacağı

    void LateUpdate()
    {
        // Kamera hedef pozisyonu, karakterin pozisyonu + offset
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
