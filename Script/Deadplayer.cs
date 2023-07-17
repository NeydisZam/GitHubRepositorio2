using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase que representa el comportamiento cuando un objeto entra en colisión
/// </summary>
public class Deadplayer : MonoBehaviour
{
    /// <summary>
    /// Método llamado cuando otro objeto entra en colision con este objeto.
    /// </summary>
    /// <param name="collision">Esto incluye el objeto que colisionó con este objeto.</param>
 private void OnCollisionEnter2D(Collision2D collision) 
 {
    //Verifica si el objeto que colisiona tiene la etiqueta "player"
    if (collision.transform.CompareTag("Player"))
    {
        //Imprime un mensaje de depuración indicando que el jugador a sido dañado.
        Debug.Log("Player Damaged");
        //Destruye al jugador que colisiona con este objeto.
        Destroy(collision.gameObject);
    }
 } 
}
