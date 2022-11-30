using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeDead1 : MonoBehaviour
{
    public Animator jugadorAnim;
    public bool contador;
    public Jefe1 Jefe;
    public bool EliminarEnemigo;
    public Contador contadorEnemy;
    bool Idle;
    public Escenario5 escenario;

    public AudioClip[] sonidos;
    AudioSource mAudioSource;
    bool validar;
    // Start is called before the first frame update
    
    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Idle=true;
        contador=true;
        EliminarEnemigo=false;
        validar =true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(contador==false){
            if(validar){
                validar=false;
                Idle=false;
                mAudioSource.Stop();
                jugadorAnim.SetTrigger("DeadEnemigo");
                SonidoMuerte();
                Jefe.canMove=false;
            }
        }
        else{
            if(Idle){
            SonidoIdle();
            Idle=false;
            StartCoroutine("EsperarAudio");
            }  
        }


        if(EliminarEnemigo==true){
            Destroy(gameObject,10f);
            StartCoroutine("Abrir");
            escenario.mAudioSource.Stop();
            print("Jefe eliminado");
            EliminarEnemigo=false;
        }   

    }

    void DesaparecerEnemigos(){
        EliminarEnemigo=true;
    }

    public void SonidoMuerte(){
        mAudioSource.clip = sonidos[0];
        mAudioSource.Play();
    }

    public void SonidoIdle(){
        mAudioSource.clip = sonidos[1];
        mAudioSource.Play();
    }

    IEnumerator Abrir(){
        yield return new WaitForSeconds(4);
        contadorEnemy.contador=contadorEnemy.contador+1;
        
    }

    IEnumerator EsperarAudio(){
        yield return new WaitForSeconds(8);
        if(contador==false){
            Idle=false;
        }
        else{
            Idle=true;
        }
        
    }
}
