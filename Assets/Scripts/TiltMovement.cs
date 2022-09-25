using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float smooth = 5.0f;
    [SerializeField] float rotationSpeed = 0.15f;

    float tiltX;
    float tiltZ;
    float maxTiltAngle = 15f;


    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey("left") && tiltX > -maxTiltAngle)
        {
            tiltX -= rotationSpeed;
        }
        else if (Input.GetKey("right") && tiltX < maxTiltAngle)
        {
            tiltX += rotationSpeed;
        }
        else if (Input.GetKey("up") && tiltZ < maxTiltAngle)
        {
            tiltZ += rotationSpeed;
        }
        else if (Input.GetKey("down") && tiltZ > -maxTiltAngle)
        {
            tiltZ -= rotationSpeed;
        }

        Debug.Log(tiltX);

        Quaternion target = Quaternion.Euler(tiltX, 0, tiltZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

    }
}
