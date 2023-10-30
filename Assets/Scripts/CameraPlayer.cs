using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public float velocity = 100f;
    float rotationX = 0f;

    public Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        float mouX = Input.GetAxis("Mouse X") * velocity * Time.deltaTime;
        float mouY = Input.GetAxis("Mouse Y") * velocity * Time.deltaTime;

        rotationX -= mouY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        player.Rotate(Vector3.up * mouX);

    }
}
