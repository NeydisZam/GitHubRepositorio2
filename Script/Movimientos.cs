using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase pública que controla los movimientos del personaje.
/// </summary>
public class Movimientos : MonoBehaviour
{

    bool isLeft = false;
    bool isRight = false;
    bool isJump = false;
    bool canJump = true;
    
    /// <summary>
    /// Rigidbody del personaje que se moverá.
    /// </summary>
    public Rigidbody2D rb;
    /// <summary>
    /// Fuerza de movimiento horizontal aplicada al personaje.
    /// </summary>
    public float speedForce;
    /// <summary>
    /// Fuerza de salto aplicada al personaje.
    /// </summary>
    public float jumpforce;
    /// <summary>
    /// Tiempo de espera para permitir otro salto.
    /// </summary>
    public float waitjump;
    
     /// <summary>
    /// Método llamado cuando se hace clic en el botón de mover a la izquierda.
    /// </summary>
    public void clickLeft(){
        isLeft = true;
    }
     /// <summary>
    /// Método llamado cuando se suelta el botón de mover a la izquierda.
    /// </summary>
    public void releaseLeft(){
        isLeft = false;
    }
    /// <summary>
    /// Método llamado cuando se hace clic en el botón de mover a la derecha.
    /// </summary>
    public void clickRight(){
        isRight = true;
    }
    /// <summary>
    /// Método llamado cuando se suelta el botón de mover a la derecha.
    /// </summary>
    public void releaseRight(){
        isRight = false;
    }
     /// <summary>
    /// Método llamado cuando se hace clic en el botón de saltar.
    /// </summary>
    public void clickJump(){
        isJump = true;
    }
     /// <summary>
    /// Método que se ejecuta de forma constante en intervalos fijos para aplicar las fuerzas de movimiento y salto al personaje.
    /// </summary>
    private void FixedUpdate()
    {
        if (isLeft)
        {
            rb.AddForce(new Vector2(-speedForce, 0) * Time.deltaTime);
            transform.localScale = new Vector3(-1,1,1);
        }
        
        if (isRight)
        {
            rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
            transform.localScale = new Vector3(1,1,1);
        }
        
        if (isJump && canJump)
        {
            isJump = false;
            rb.AddForce(new Vector2(0, jumpforce));
            canJump = false;
            Invoke("waitToJump", waitjump);
        }
    }
   
    /// <summary>
    /// Método que espera un tiempo antes de permitir otro salto.
    /// </summary>
    void waitToJump()
    {
        canJump = true;
    }
}