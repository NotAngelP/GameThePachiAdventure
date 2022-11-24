using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{

    public Animator jugadorAnim;
    public ControlDelPersonaje jugadorScript;
    public Dash jugadorDash;
    public Escudo jugadorEscudo;

    public bool attacking;
    public int nroP;
    public bool canAttack;
  

    // Start is called before the first frame update
    void Start()
    {
        nroP = 0;
        canAttack = true;
        attacking = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(canAttack == true && jugadorDash.dashing==false){
            if(Input.GetKeyDown(KeyCode.J)){
                nroP++;
                if(canAttack==true && nroP==1){
                    jugadorAnim.SetTrigger("Attack");
                    print("Combo1");
                    canAttack=false;
                }     

            }
        }
   }
 

    void Atacando(){
        attacking=true;
        jugadorScript.canMove = false;
    }

    void DejoDeAtacar(){
        print("Dejo de atacar");
       jugadorScript.canMove = true;
       canAttack=true;
       nroP=0;
       attacking=false;
       jugadorScript.canMove = true;
       jugadorEscudo.BajoElEscudo();
    }

    void Damage(){
        print("daño");
    }
    
    void canAttackTrue()
    {
                canAttack=true;
    }
    
    void verificaCombo(){
        canAttack=false;
        if (nroP==2)
        {
            jugadorAnim.SetTrigger("Attack2"); 
            print("Combo2");
        }
        else{
            nroP=0;
        }
    }

     void verificaCombo2(){
        canAttack=false;
        if (nroP>=3){
            jugadorAnim.SetTrigger("Attack3");
            print("Combo3");
        }
        else{
            nroP=0;
        }
    }
}
