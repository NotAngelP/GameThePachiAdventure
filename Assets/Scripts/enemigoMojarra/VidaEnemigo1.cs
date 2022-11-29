using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo1 : MonoBehaviour
{
    public EnemigoDead enemigoDead;
    public float vidaEnemigo;
    public bool isLive;
    public float vidaMax;
    public CuchilloPachi CuchilloPachi;
    
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
            if(vidaEnemigo<=0){
                enemigoDead.contador=false;
                isLive=false;
            }
        }
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("CuchilloPachi")){
           vidaEnemigo=vidaEnemigo-CuchilloPachi.damage;
           print("Daño -" + CuchilloPachi.damage);
            
        }
    }
}
