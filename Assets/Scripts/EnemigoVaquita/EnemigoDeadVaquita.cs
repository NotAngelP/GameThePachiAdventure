using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDeadVaquita : MonoBehaviour
{
    public Animator jugadorAnim;
    public bool contador;
    public EnemigoVaquita enemigo;
    public bool EliminarEnemigo;
    public Contador contadorEnemy;

    //sonidos
    public AudioClip[] sonidos;
    AudioSource mAudioSource;
    
    
    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        contador=true;
        EliminarEnemigo=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador==false){
            jugadorAnim.SetTrigger("DeadEnemigo");
            contador=true;
            enemigo.canMove=false;
        }    

        if(EliminarEnemigo==true){
            Destroy(gameObject,4.25f);
            contadorEnemy.contador=contadorEnemy.contador+1;
            print("enemigo eliminado");
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
}
