using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeDead1 : MonoBehaviour
{
    public Animator jugadorAnim;
    public bool contador;
    public Jefe1 Jefe;
    public bool EliminarEnemigo;

    public AudioClip[] sonidos;
    AudioSource mAudioSource;
    // Start is called before the first frame update
    
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
            Jefe.canMove=false;
        }    

        if(EliminarEnemigo==true){
            Destroy(gameObject,10f);
            print("Jefe eliminado");
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
