using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario4 : MonoBehaviour
{
    public Contador contador;
    bool activarAnimacion;
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
       activarAnimacion=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador.contador==11){
            if(activarAnimacion){
                activarAnimacion=false;
                print("puertas abiertas");
                ani.SetTrigger("OpenDoor");
            }
        }
    }
}
