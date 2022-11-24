using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dash : MonoBehaviour
{
    public Animator jugadorAnim;
    public ControlDelPersonaje jugadorScript;
    public Ataque jugadorAtaque;
    public Escudo jugadorEscudo;
    public bool canDash;
    public bool dashing;
    

    // Start is called before the first frame update
    void Start()
    {
        canDash = true;
        dashing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(canDash==true && jugadorAtaque.attacking==false && jugadorEscudo.cubriendose==false){
            if(Input.GetButtonDown("Jump")){
                dashing=true;
                Debug.Log("Estoy Dasheando");
                jugadorAnim.SetTrigger("Dash");
                
                print("x "+jugadorScript.controlador.transform.position.x +"     z "+ jugadorScript.controlador.transform.position.z );
                //jugadorScript.controlador.Move(new Vector3(4f,0f,4f));
                
            }
        }
    }

    public void Dashing(){
        canDash = false;
        jugadorScript.velocidadDeMovimiento = 18f;
    }

    public void DejaDeDashear(){
        jugadorScript.canMove = true;
        jugadorScript.velocidadDeMovimiento = 12f;
        print("Cooldown 4 segundos para Dashear");
        StartCoroutine("Esperar");
        dashing=false;
    }

    public void NoMoverse(){
        jugadorScript.canMove = false;
    }

    IEnumerator Esperar(){
        yield return new WaitForSeconds(4);
        print("ya puedes dashear");
        canDash= true;
    }
}
