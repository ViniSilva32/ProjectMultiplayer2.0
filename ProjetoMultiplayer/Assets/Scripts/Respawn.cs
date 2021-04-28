using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject RespawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(RespawnPoint.transform.position.x, RespawnPoint.transform.position.y, RespawnPoint.transform.position.z);
        }
    }

}
