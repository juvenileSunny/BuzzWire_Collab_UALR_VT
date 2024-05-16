

using UnityEngine;


public class LoopRespawn : MonoBehaviour
{
    public GameObject loop;
    // public GameObject spawnedLoop;
    public Transform spawnPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LoopBoundary"))
        {
            // Destroy the current object
            Destroy(gameObject);

            // Instantiate a new "loop" object at the spawn point
            // Assuming you have a reference to the loop prefab
            
            // GameObject spawnedLoop = Instantiate(loop);
            // spawnedLoop.transform.position = spawnPoint.position;
        }
    }


}
