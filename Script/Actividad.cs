using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// </summary> 
/// Clase pública llamada Actividad que representa las opciones de falso y verdadero 
/// </summary>
public class Actividad : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    /// <summary>
    /// Valida la respuesta proporcionada y carga la scena "verdadero" o "falso" según corresponda.
    /// </summary>
    /// <param name="respuesta">La respuesta proporcionada puede ser verdadero </param>
    public void validarPregunta(string respuesta)
    {
        if (respuesta == "verdadero")
        {
            SceneManager.LoadScene("verdadero");
        }
        else
        {
            SceneManager.LoadScene("falso");
      }
    }
    /// <summary>
    /// Valida la respuesta proporcionada y carga la scena "falso" o "verdadero" segun corresponda.
    /// </summary>
    /// <param name="respuesta">La respuesta proporcioada debe de ser falso </param>
    
    public void validarPreguntaF(string respuesta)
    {
        if (respuesta == "falso")
        {
            SceneManager.LoadScene("falso");
        }
        else
        {
            SceneManager.LoadScene("verdadero");
        }
    }
    /// <summary>
    /// Oculta el panel especificado
    /// </summary>
    /// <param name="a">Este parametro no se utiliza en el método</param>
    public void quitarPanel(string a)
    {
        panel.SetActive(false);
    }
}

