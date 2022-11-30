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
    
    //sonidos
    public AudioClip[] espadas;
    AudioSource mAudioSource;

    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        nroP = 0;
        canAttack = true;
        attacking = false;
        

    }

    // Update is called once per frame      Input.GetKeyDown(KeyCode.J)
    void Update()
    {
        if(canAttack == true && jugadorDash.dashing==false){
            if(Input.GetMouseButtonDown(0)){
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



    //Metodos de sonidos
    void SonidoEspada1(){
        mAudioSource.clip = espadas[0];
        mAudioSource.Play();
    }

    void SonidoEspada2(){
        mAudioSource.clip = espadas[1];
        mAudioSource.Play();
    }

    void SonidoEspada3(){
        mAudioSource.clip = espadas[2];
        mAudioSource.Play();
    }

    void SonidoDash(){
        mAudioSource.clip = espadas[3];
        mAudioSource.Play();
    }

    void SonidoDead(){
        mAudioSource.clip = espadas[4];
        mAudioSource.Play();
    }

   
}
