using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeesawRotation : MonoBehaviour
{
    // Start is called before the first frame update
    // float startY = 90; // horizontal 
    [SerializeField] float rotationSpeed = 60f;
    [SerializeField] float yAngle = 45f;

    // float smooth = 5.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * rotationSpeed, yAngle), 0);
        // Quaternion target = Quaternion.Euler(0, 110, 0);
        // transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * ySpin);

        // Debug.Log(transform.rotation);



        // if(transform.rotation.z >= 70 && transform.rotation.z <= 90) {
            // transform.Rotate(0, Mathf.PingPong(Time.time, 8), 0);
        // }
        // if(transform.rotation.z == 70 && transform.rotation.z < 110) {
        //     transform.Rotate(0, zSpin, 0);
        // }
    }
}
