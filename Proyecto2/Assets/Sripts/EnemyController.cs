using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//la usaremos para que los fantasmas sigan a PacMan de manera dinamica
using UnityEngine.AI; // importar una libreria para hacer uso de metodos
                      // relacionados con IA

public class EnemyController : MonoBehaviour
{
    
    public Transform player; //Va a guardar la posicion de nuestro jugador
    public NavMeshAgent enemy; //Nos ayudara a emular el comportamiento del enemigo
    // Start is called before the first frame update
    void Start()
    {
        //Nuestro objeto guardara el componente que le dara IA
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove(); //para que revise constantemente la posicion del jugador
    }

    //logica del comportamiento enemigo
    void EnemyMove(){
        //Busca ser igual a la posicion del jugador
        enemy.destination = player.position; 

    }
}
