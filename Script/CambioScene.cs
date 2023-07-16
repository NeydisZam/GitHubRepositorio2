using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    public void LoadScene(string nombredescena) 
    {
        SceneManager.LoadScene(nombredescena);
    }
        
    
}
