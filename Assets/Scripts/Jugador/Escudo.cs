using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    public Animator jugadorAnim;
    public ControlDelPersonaje jugadorScript;
    public Dash jugadorDash;
    public Ataque jugadorAtaque;

    public bool BajarEscudoCorriendo;
    public bool cubriendose;
    public bool canCubrirse;
    public int nroP;
    // Start is called before the first frame update
    void Start()
    {
        canCubrirse=true;
        BajarEscudoCorriendo=false;
        cubriendose=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(jugadorDash.dashing==false && jugadorAtaque.attacking==false){
            if(cubriendose==false){
                if(Input.GetMouseButtonDown(1)){
                    nroP++;
                    if(canCubrirse==true && nroP==1){
                    jugadorAnim.SetTrigger("ActivarEscudo");
                    cubriendose=true;
                    canCubrirse=false;
                    }     
                }  
            }
            else{
                if(Input.GetMouseButtonDown(1)){
                     if(BajarEscudoCorriendo==true){
                        jugadorAnim.SetTrigger("BajarEscudoCorriendo");
                     }
                     else{
                        jugadorAnim.SetTrigger("BajarEscudo");
                     }
                    
                }
            }

        }

    }


    void Cubriendose(){
        print("cubriendose");
    }

    void DejoDeCubrirse(){
        print("Dejo de Cubrirse");
    }

    public void BajoElEscudo(){
        canCubrirse=true;
        cubriendose=false;
        nroP=0;
        jugadorScript.canMove=true;
        BajarEscudoCorriendo=false;
        jugadorScript.velocidadDeMovimiento=12;   
        print("Bajo EL escudo");
    }

    void EscudoActivado(){
        jugadorAnim.SetTrigger("EscudoCorriendo"); 
    }



    void CanCubrirseTrue(){
        canCubrirse=true;
        cubriendose=false;
    }

     void VerificaSparry(){
        cubriendose=true;
        canCubrirse=false;
        if (nroP==2)
        {
            jugadorAnim.SetTrigger("Parry"); 
        }
        else{
            nroP=0;
        }
    }

    void Parry(){
        print("PARRY");
    }

    void BajarVelocidad(){
        jugadorScript.velocidadDeMovimiento = 5;
        jugadorScript.canMove=true;
        BajarEscudoCorriendo=true;
        }

    void VelocidadNormal(){
        jugadorScript.velocidadDeMovimiento = 12;
        jugadorScript.canMove =false;
    }

    void EmpezoACubrirse(){
    jugadorScript.canMove= false;
   }

   void NoEstaCorriendo(){
    jugadorScript.canMove=true;
    BajarEscudoCorriendo=false;
   }

}
