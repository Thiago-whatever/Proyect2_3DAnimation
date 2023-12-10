using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperPill : MonoBehaviour
{
    //Va a guardar el componente PlayerScript del jugador
    private PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindObjectOfType<PlayerController>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para indicarle que cuando colisionen se cambie la variable invencible
    // a verdadero
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            playerScript.isInv = true;
        }

    }
}
