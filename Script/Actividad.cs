using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actividad : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    void Start()
    {
        
    }

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
    public void quitarPanel(string a)
    {
        panel.SetActive(false);
    }
}

