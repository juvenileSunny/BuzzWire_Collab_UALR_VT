using UnityEngine;

public class DeactivateByTag : MonoBehaviour
{
    // Tags to search for deactivation
    public string[] tagsToDeactivate;

    void Start()
    {
        // Check each tag in the array
        foreach (string tag in tagsToDeactivate)
        {
            // Find all game objects with the current tag
            GameObject[] objectsToDeactivate = GameObject.FindGameObjectsWithTag(tag);

            // Loop through each object and deactivate
            foreach (GameObject obj in objectsToDeactivate)
            {
                // This will deactivate the object and all its children
                obj.SetActive(false);
            }
        }
    }
}