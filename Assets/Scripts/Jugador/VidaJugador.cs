using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public Dead playerDead;
    public float vidaDePachi;
    public bool isLive;
    public Corazones corazones;
    // Start is called before the first frame update
    void Start()
    {
        isLive=true;
        vidaDePachi=6;
    }

    // Update is called once per frame
    void Update()
    {
        if(isLive){
            if(vidaDePachi<=0){
                playerDead.contador=false;
                isLive=false;
            }
        }
        corazones.setImagenesCorazones(vidaDePachi);
        
    }

}