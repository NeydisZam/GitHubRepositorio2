using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase pública que representa el comportamiento cuando un objeto entra en colisión con este objeto.
/// </summary>
public class FruitCollected : MonoBehaviour
{
    /// <summary>
    /// Método llamado cuando otro objeto entra en colisión con este objeto.
    /// </summary>
    /// <param name="collision">Información de la colisión, incluyendo el objeto que colisionó con este objeto</param>
  private void OnTriggerEnter2D(Collider2D collision)
    {
        //Verifica si el objeto que colisiona tiene la etiqueta "Player".
        if (collision.CompareTag("Player"))
        {
            //Desactiva el componente de rendarizado para hacer que el objeto sea invisible.
            GetComponent<SpriteRenderer>().enabled = false;
            //Activa el primer hijo del objeto(si existe) para mostrar algun efecto o animación.
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            // Destruye el objeto después de 0.5 segundo
            Destroy(gameObject, 0.5f);
        }
    }
}
