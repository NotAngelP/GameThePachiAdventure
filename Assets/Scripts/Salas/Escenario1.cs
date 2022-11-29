using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenario1 : MonoBehaviour
{
    public Contador contador;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(contador.contador==2){
            print("abrir puertas");
        }
    }
}
