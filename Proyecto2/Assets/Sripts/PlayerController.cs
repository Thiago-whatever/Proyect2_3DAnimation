using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed; //Para definir la velocidad con la que se va a mover

    private Rigidbody playerRb;//Nuestro objeto de Unity con el que vamos a poder mover PacMan
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Asi va a estar actualizando el movimiento conforme pulsemos las teclas
        PlayerMove();
    }

    void PlayerMove(){
        //Para el que "cache" las teclas para su movimiento horizontal
        float mh = Input.GetAxis("Horizontal");
        //Para el que "cache" las teclas para su movimiento vertical
        float mv = Input.GetAxis("Vertical");

        //Va a guardar el valor del vector 3 por donde se movera el jugador
        //Vector3 recibe 3 parametros; x, y, z
        //va a detectar mh en el eje x cuando pulsemos sobre el eje horizontal
        //va a detectar mv en el eye z cuando pulsemos sobre el eje vertical
        //y = 0f dado que no va a "volar"
        Vector3 move = new Vector3(mh,0f,mv);

        //Accedemos al atributo velocidad y el valor de esa velocidad va a ser
        //el resultado de la operacion move * playerSpeed
        playerRb.velocity = move * playerSpeed;
    }
}
