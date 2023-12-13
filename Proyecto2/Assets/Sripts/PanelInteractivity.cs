using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelInteractivity : MonoBehaviour
{

    public Light[] lights; // Array para las luces
    public TMP_Text lightsInfoText; // Texto UI para mostrar la información

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lightsInfoText.text = ""; // Limpiar el texto
        lightsInfoText.text = "Información de las luces: \n";

        foreach (Light light in lights)
        {
            // Añadir información de cada luz al texto
            lightsInfoText.text += light.name + " Position: " + light.transform.position.ToString() + "\n";
        }
    }
}
