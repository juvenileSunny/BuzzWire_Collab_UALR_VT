using UnityEngine;

public class collisionChangePlayZone : MonoBehaviour
{
    public bool playZoneFlag { get; private set; }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "rightPlayZone")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            playZoneFlag = true;
            // Debug.Log("Collided");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "rightPlayZone")
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            playZoneFlag = true;
            // Debug.Log("Collisionkept");
        }
    }

    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "rightPlayZone")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            playZoneFlag = false;
            // Debug.Log("No");
        }
    }

    
}