using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuchilloPachi : MonoBehaviour
{
    public VidaEnemigo1 EnemigoVida;
    public VidaJefe1 vidaJefe;
    public float damageMojarra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.CompareTag("EnemigoMojarra")){
           EnemigoVida.vidaEnemigo=EnemigoVida.vidaEnemigo-damageMojarra;
           print("Daño -2");
        }

        if(collider.CompareTag("JefePulpo")){
           vidaJefe.vidaJefe=vidaJefe.vidaJefe-damageMojarra;
           print("Daño -2");
        }
    }

   
}
