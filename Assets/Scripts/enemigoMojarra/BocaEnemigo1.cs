using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BocaEnemigo1 : MonoBehaviour
{
    public VidaJugador jugadorVida;
    public float damage;
    

    //sonidos
    public AudioClip[] sonidos;
    AudioSource mAudioSource;

    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Pachi")){
           jugadorVida.vidaDePachi=jugadorVida.vidaDePachi-damage;
           SonidoMordida();
           print("Daño -1");
            
        }
        if(collider.CompareTag("Escudo")){
           
           gameObject.GetComponent<BoxCollider>().enabled = false;
           SonidoEscudo();
           print("bloqueo");
            
        }

    }

    void SonidoEscudo(){
        mAudioSource.clip = sonidos[0];
        mAudioSource.Play();
    }

    void SonidoMordida(){
        mAudioSource.clip = sonidos[1];
        mAudioSource.Play();
    }

}
