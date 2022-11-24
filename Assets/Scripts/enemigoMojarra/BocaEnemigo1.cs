using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BocaEnemigo1 : MonoBehaviour
{
    public VidaJugador jugadorVida;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("Pachi")){
           jugadorVida.vidaDePachi=jugadorVida.vidaDePachi-damage;
           print("Daño -1");
            
        }
        if(collider.CompareTag("Escudo")){
           
           gameObject.GetComponent<BoxCollider>().enabled = false;
           print("bloqueo");
            
        }
    }
}
