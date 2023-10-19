using UnityEngine;


public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 45 * Time.deltaTime);

    }

}
