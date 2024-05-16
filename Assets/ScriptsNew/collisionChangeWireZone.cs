using UnityEngine;

public class collisionChangeWireZone : MonoBehaviour
{
    public bool wireZoneFlag { get; private set; }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            wireZoneFlag = true;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            wireZoneFlag = true;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "wire")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            wireZoneFlag = false;
        }
    }

    
}