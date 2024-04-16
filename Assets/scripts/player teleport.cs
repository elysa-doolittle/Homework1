using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
            
            // Debug.Log(player.position);
        }
    }
}

// public class PlayerTeleport : MonoBehaviour
// {
//     public GameObject Player;
//     public GameObject TeleportTo;

//     private void OnTriggerEnter(Collider collision)
//     {
//         if(collision.gameObject.CompareTag("Teleporter"))
//         {
//             Player.transform. position = TeleportTo.transform.position;
//         }
//     }
// }