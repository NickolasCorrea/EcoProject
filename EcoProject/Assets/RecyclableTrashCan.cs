using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclableTrashCan : MonoBehaviour
{
    [SerializeField] float packageDisappears = 0.2f;

    public void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Lixo reciclado!");
        if (other.tag == "Trash"){
            Destroy(other.gameObject, packageDisappears);
        }
    }
}
