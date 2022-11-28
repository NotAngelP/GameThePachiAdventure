using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJefe1 : MonoBehaviour
{
    public JefeDead1 JefeDead;
    public float vidaJefe;
    public bool isLive;
    public float vidaMax;
    void Start()
    {
        isLive=true;
        vidaJefe=30;
        vidaMax = vidaJefe;
    }

    // Update is called once per frame
    void Update()
    {
        if(isLive){
            if(vidaJefe<=0){
                JefeDead.contador=false;
                isLive=false;
            }
        }
    }
}
