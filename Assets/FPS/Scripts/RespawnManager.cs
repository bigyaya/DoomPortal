using UnityEngine;
using System.Collections;

public class RespawnManager : MonoBehaviour
{

    public Transform respawnPoint;
    public CharacterController characterController;
    public RespawnManager gameManager;

    void Start()
    {
        respawnPoint = GetComponent<Transform>();
        characterController = GetComponent<CharacterController>();
        gameManager = GameObject.FindObjectOfType<RespawnManager>();
    }

    public void Respawn()
    {
        characterController.enabled = false;
        characterController.transform.position = respawnPoint.position;
        characterController.enabled = true;
        characterController.SimpleMove(Vector3.zero);
    }

    void Update()
    {
        if (characterController.transform.position.y < -5f)
        {
            gameManager.Respawn();
        }
    }
}
