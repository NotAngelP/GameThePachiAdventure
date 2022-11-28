using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoVaquita : MonoBehaviour
{
    public EnemigoDeadVaquita enemigoDead;
    public float vidaVaquita;
    public bool isLive;
    public float vidaMax;
    void Start()
    {
        isLive=true;
        vidaVaquita=4;
        vidaMax = vidaVaquita;
    }

    // Update is called once per frame
    void Update()
    {
        if(isLive){
            if(vidaVaquita<=0){
                enemigoDead.contador=false;
                isLive=false;
            }
        }
    }
}
