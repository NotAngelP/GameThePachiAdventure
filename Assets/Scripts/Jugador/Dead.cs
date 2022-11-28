using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public Animator jugadorAnim;
    public ControlDelPersonaje jugadorScript;
    public Ataque jugadorAtaque;
    public Dash jugadorDash;
    public Escudo jugadorEscudo;

    public bool contador;
    // Start is called before the first frame update
    void Start()
    {
        contador=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador==false){
                jugadorAnim.SetTrigger("Dead");
                contador=true;
                jugadorScript.canMove=false;
                jugadorAtaque.canAttack= false;
                jugadorDash.canDash = false;
                jugadorEscudo.canCubrirse= false;
                jugadorEscudo.cubriendose=false;
            }     
    }

    void noMorverse(){
        jugadorScript.canMove=false;
    }


}

