using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo1 : MonoBehaviour
{
    public EnemigoDead enemigoDead;
    public float vidaEnemigo;
    public bool isLive;
    public float vidaMax;
    void Start()
    {
        isLive=true;
        vidaEnemigo=4;
        vidaMax = vidaEnemigo;
    }

    // Update is called once per frame
    void Update()
    {
        if(isLive){
            if(vidaEnemigo==0){
                enemigoDead.contador=false;
                isLive=false;
            }
        }
    }
}
