using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMenu : MonoBehaviour
{
    public AudioClip[] sonidos;
    AudioSource mAudioSource;

    bool cancion;
    // Start is called before the first frame update
    
    private void Awake() {
        mAudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cancion=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(cancion){
            cancion=false;
            SoundTrack();
            StartCoroutine("EsperarAudio");
        }
    }

    public void SoundTrack(){
        mAudioSource.clip = sonidos[0];
        mAudioSource.Play();
    }

    IEnumerator EsperarAudio(){
        yield return new WaitForSeconds(194);
        cancion=true;
        
    }
}
