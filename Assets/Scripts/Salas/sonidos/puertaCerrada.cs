using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaCerrada : MonoBehaviour
{
    bool canPlay;
    public bool activarSonido;

    //sonidos
    public AudioClip[] sonidos;
    AudioSource mAudioSource;
    
    
    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        canPlay=true;
        activarSonido=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(activarSonido){
            activarSonido=false;
            Sonido2();
        }
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Pachi")){
            print("master");
           if(canPlay){
                canPlay=false;
                Sonido();
                StartCoroutine("Esperar");

           }
        }
    }

    public void Sonido(){
        mAudioSource.clip = sonidos[0];
        mAudioSource.Play();
    }

    public void Sonido2(){
        mAudioSource.clip = sonidos[1];
        mAudioSource.Play();
    }

    IEnumerator Esperar(){
        yield return new WaitForSeconds(1);
        canPlay=true;
        
    }
}
