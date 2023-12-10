using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//la usaremos para que los fantasmas sigan a PacMan de manera dinamica
using UnityEngine.AI;
using UnityEngine.SceneManagement; // importar una libreria para hacer uso de metodos
                                   // relacionados con IA

public class EnemyController : MonoBehaviour
{
    public Transform player; //Va a guardar la posicion de nuestro jugador
    public NavMeshAgent enemy; //Nos ayudara a emular el comportamiento del enemigo
    // Start is called before the first frame update

    public Transform home; //vamos a colocar aqui la posicion a la que tienen que regresar

    private PlayerController playerScript;
    void Start()
    {
        //Nuestro objeto guardara el componente que le dara IA
        enemy = GetComponent<NavMeshAgent>();
        playerScript = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove(); //para que revise constantemente la posicion del jugador
    }

    //logica del comportamiento enemigo
    void EnemyMove(){
        //Busca ser igual a la posicion del jugador
        if(playerScript.isInv == false){
            enemy.destination = player.position;
        }

        //Cuando el jugador es invencible
        if(playerScript.isInv){
            enemy.destination = home.position;
        }
    }

    //Para que detecte la colision con el otro objeto
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){// revisar que el objeto con el que este colisionando sea el jugador
            SceneManager.LoadScene("LabrinthScene");
        }
    }
}
