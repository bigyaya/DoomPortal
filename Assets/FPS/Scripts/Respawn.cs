using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] public Transform Player;
    [SerializeField] public Transform respawnPoint;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
}
