using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Clase pública que proporciona un método para cargar otra escena
/// </summary>
public class CambioScene : MonoBehaviour
{
    /// <summary>
    /// Carga una escena con el nombre especificado
    /// </summary>
    /// <param name="nombredescena">El nombre de la escena que se va a cargar</param>
    public void LoadScene(string nombredescena) 
    {
        SceneManager.LoadScene(nombredescena);
    }
        
    
}
