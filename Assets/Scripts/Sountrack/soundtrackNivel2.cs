using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrackNivel2 : MonoBehaviour
{

    //sonidos
    public AudioClip[] espadas;
    public AudioSource mAudioSource;

    bool cancion;

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
            StartCoroutine("repetirCancion");
        }
    }

     void SoundTrack(){
        mAudioSource.clip = espadas[0];
        mAudioSource.Play();
    }


    IEnumerator repetirCancion(){
        yield return new WaitForSeconds(164);
        cancion=true;
        
    }
}
