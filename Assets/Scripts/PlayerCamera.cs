using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);

    float time = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField]
    public Transform target;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref velocity, time);
    }
}
