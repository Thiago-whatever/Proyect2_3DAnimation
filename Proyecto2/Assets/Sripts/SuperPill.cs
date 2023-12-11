using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuperPill : MonoBehaviour
{
    //Va a guardar el componente PlayerScript del jugador
    private PlayerController playerScript;

    public int time; 
    private float timeTrans;

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
        if(other.CompareTag("Player")){// revisar que el objeto con el que este colisionando sea el jugador
            playerScript.isInv = true;
            // Comienza la coroutine que espera 5 segundos y luego cambia la escena
            StartCoroutine(WaitAndLoadScene());
             gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

     // Coroutine para esperar y cargar la escena
    IEnumerator WaitAndLoadScene()
    {
        // Espera 5 segundos
        yield return new WaitForSeconds(5f);

        // Carga la escena "FinalScene"
        SceneManager.LoadScene("FinalScene");
    }
}
