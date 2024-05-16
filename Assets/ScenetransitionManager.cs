// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class ScenetransitionManager : MonoBehaviour
// {
//     public FadeScreen fadeScreen;

//     public void GoToScene(int sceneIndex)
//     {
//         StartCoroutine(GoToSceneRoutine(sceneIndex));
//     }

//     IEnumerator GoToSceneRoutine(int sceneIndex)
//     {
//         fadeScreen.FadeOut();
//         yield return new WaitForSeconds(fadeScreen.fadeDuration);
//         SceneManager.LoadScene(sceneIndex);


//     }
// }
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class SceneSpawnPoint
{
    public int sceneIndex;
    public Vector3 spawnPoint;
}

public class ScenetransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public List<SceneSpawnPoint> sceneSpawnPoints; // List to hold scene index and corresponding spawn points

    private Dictionary<int, Vector3> spawnPointMap; // Dictionary to map scene index to spawn point

    private void Awake()
    {
        // Initialize the spawn point map from the serialized list
        spawnPointMap = new Dictionary<int, Vector3>();
        foreach (var sceneSpawnPoint in sceneSpawnPoints)
        {
            spawnPointMap[sceneSpawnPoint.sceneIndex] = sceneSpawnPoint.spawnPoint;
        }
    }

    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        
        // Load the scene
        SceneManager.LoadScene(sceneIndex);
    }

    // Function to spawn the XROpen rig at the specific spawn point for the scene
    public void SpawnPlayerAtSpawnPoint(int sceneIndex, GameObject player)
    {
        if (spawnPointMap.ContainsKey(sceneIndex))
        {
            player.transform.position = spawnPointMap[sceneIndex];
        }
        else
        {
            Debug.LogError("No spawn point found for scene index: " + sceneIndex);
        }
    }

    void Start()
    {
        // Spawn the player at the initial spawn point when the scene loads
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            // Get the current scene index
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Spawn the player at the spawn point for the current scene
            SpawnPlayerAtSpawnPoint(currentSceneIndex, player);
        }
        else
        {
            Debug.LogError("Player GameObject not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}