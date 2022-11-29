using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario5 : MonoBehaviour
{
    public Contador contador;
    bool activarAnimacion;
    public Animator ani;
    public puertaCerrada puerta;

    public AudioClip[] sonidos;
    public AudioSource mAudioSource;

    public soundtrack soundtrack;
    // Start is called before the first frame update
    
    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
       activarAnimacion=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador.contador==12){
            if(activarAnimacion){
                activarAnimacion=false;
                print("puertas abiertas");
                ani.SetTrigger("OpenDoor");
                puerta.activarSonido=true;
            }
        }
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Pachi")){
           gameObject.GetComponent<BoxCollider>().enabled = false;
           soundtrack.mAudioSource.Stop();
           SoundTrack();
        }
    }

    public void SoundTrack(){
        mAudioSource.clip = sonidos[0];
        mAudioSource.Play();
    }
}
