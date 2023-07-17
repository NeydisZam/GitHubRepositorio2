using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

/// <summary>
/// Clase que maneja la navegación entre escenas mediante un botón.
/// </summary>
public class NavScript : MonoBehaviour
{
    /// <summary>
    /// Texto del botón que muestra la escena a la que navegará.
    /// </summary>
    public Text btnNavegacion;
     /// <summary>
    /// Nombre de la escena a la que navegará al hacer clic en el botón.
    /// </summary>
    public string escena;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Método que se ejecuta al hacer clic en el botón para cambiar a la escena especificada.
    /// </summary>
    public void gotoScene(){
        SceneManager.LoadScene(escena);
    } 
}
