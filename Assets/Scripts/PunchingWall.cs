using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingWall : MonoBehaviour
{
    [SerializeField] float delaySeconds = 1f;
    [SerializeField] float distance = 1f;
    [SerializeField] float speed = 1f;

    float timer;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveForward", 2f, delaySeconds);
    }

    // Update is called once per frame
    void MoveForward()
    {
        transform.position = Vector3.forward * Time.deltaTime;
    }
}
