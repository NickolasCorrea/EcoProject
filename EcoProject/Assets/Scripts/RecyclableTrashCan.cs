using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecyclableTrashCan : MonoBehaviour
{

    [SerializeField] float packageDisappears = 0.2f;

    void OnTriggerEnter2D(Collider2D other) {

        string objectTag = this.gameObject.tag;

        if (objectTag=="LixeiraPlastico" && other.tag == "Plastico"){
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("Lixo reciclado!");
        }
        else if(objectTag=="LixeiraPapel" && other.tag == "Papel")
        {
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("Lixo reciclado!");
        }
        else if(objectTag=="LixeiraVidro" && other.tag == "Vidro")
        {
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("Lixo reciclado!");
        }
        else if(objectTag=="LixeiraOrganico" && other.tag == "Organico")
        {
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("Lixo reciclado!");
        }
        else if(objectTag=="LixeiraMetal" && other.tag == "Metal")
        {
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("Lixo reciclado!");
        }
        else
        {
            Destroy(other.gameObject, packageDisappears);
            Debug.Log("LIXO INVÁLIDO!");
        }


    }
}
