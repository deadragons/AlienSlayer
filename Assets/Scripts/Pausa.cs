using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject pauseWindow; //Declarar cual será la ventana de pausa

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //Declarar con la tecla P para abrir la ventana
        {
            Resume();
        }
    }

    public void Resume()
    {
        pauseWindow.SetActive(!pauseWindow.active); //Mostrar u ocultar menú
    }
}
