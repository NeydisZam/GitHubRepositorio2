using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Clase pública que representa el comportamiento cuando el personaje entra en colisión con este objeto.
/// </summary>
public class dead : MonoBehaviour
{
    /// <summary>
    /// Método llamado cuando el personaje entra en colisión con este objeto
    /// </summary>
    /// <param name="collision">Informacion de la colisión, incluyendo el objeto que colisionó con este objeto</param>
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //verifica si el objeto que colisionó tiene la etiqueta "Player".
       if(collision.gameObject.tag == "Player")
       {
        //Carga la scenacon el índice 9.
        SceneManager.LoadScene(9);
       } 
    } 
}
