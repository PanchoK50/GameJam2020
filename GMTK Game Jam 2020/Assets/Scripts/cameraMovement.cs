
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = .125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 wantedPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(target.position, wantedPosition, smoothSpeed);
        transform.position = smoothPosition;
    }

}
