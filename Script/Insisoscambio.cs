using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Clase pública que representa el comportamiento cuando un objeto entra en colision con este objeto.
/// </summary>
public class Insisoscambio : MonoBehaviour
{
    /// <summary>
    /// Este Método es llamado cuando otro objeto entra en colisión con este objeto.
    /// </summary>
    /// <param name="collision">Información de la colisión, incluyendo el objeto que colisiona con este objeto </param>
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //verifica si el objeto que colisiona tiene la etiqueta player.
       if(collision.gameObject.tag == "Player")
       {
        //Carga la escena con el índice 6.
        SceneManager.LoadScene(6);
       } 
    } 
}
