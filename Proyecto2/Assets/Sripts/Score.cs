using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Para que detecte la colision con el otro objeto
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){// revisar que el objeto con el que este colisionando sea el jugador
            //gameObject.SetActive(false); //se va a desactivar cuando lo toque
            Destroy(gameObject);// cuando el jugador atraviese el objeto, este sea destruido por completo de la escena
        }
    }
}
