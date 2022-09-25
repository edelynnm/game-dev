using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(0f, 104f, 159f);
            Debug.Log("Hit the wall!");
        }
    }
}
