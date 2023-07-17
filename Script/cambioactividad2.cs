using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Clase que representa un cambio de actividad cuando un objeto entra en colision con este objeto.
/// </summary>
public class cambioactividad2 : MonoBehaviour
{
   /// <summary>
   /// Método llamado cuando otro objeto entra en colision con este objeto.
   /// </summary>
   /// <param name="collision">Información de la colisión, incluyendo el objeto que colisionó con este objeto</param>
      private void OnTriggerEnter2D(Collider2D collision) 
    {
      //Verifica si el objeto que colisionó tiene la etiqueta "Player"
       if(collision.gameObject.tag == "Player")
       //Carga la escena con el índice 10.
       {
        SceneManager.LoadScene(10);
       } 
    } 
}
