using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionChangeRing : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    // void OnCollisionEnter(Collision other) 
    // {
    //     GetComponent<MeshRenderer>().material.color = Color.black;
    // }
}
