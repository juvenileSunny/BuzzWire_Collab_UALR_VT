using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    [SerializeField]
    Transform resetTransform;

    [SerializeField]
    GameObject player;

    // [SerializeField]
    // Camera playerHead;

    void Start()
    {
        player.transform.position = resetTransform.transform.position;
        player.transform.rotation = resetTransform.transform.rotation;
    }

    
}
