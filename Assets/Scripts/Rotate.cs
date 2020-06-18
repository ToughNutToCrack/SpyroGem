using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    public Vector3 axis;

    void Update()
    {
        transform.Rotate(axis * speed * Time.deltaTime);
    }
}
