using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuchilloPachi : MonoBehaviour
{
    public VidaEnemigo1 EnemigoVida;
    public VidaJefe1 vidaJefe;
    public VidaEnemigoVaquita vidaVaquita;
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
        if(collider.CompareTag("EnemigoMojarra")){
           EnemigoVida.vidaEnemigo=EnemigoVida.vidaEnemigo-damage;
           print("Daño -2");
        }

        if(collider.CompareTag("JefePulpo")){
           vidaJefe.vidaJefe=vidaJefe.vidaJefe-damage;
           print("Daño -2");
        }

        if(collider.CompareTag("EnemigoVaquita")){
           vidaVaquita.vidaVaquita=vidaVaquita.vidaVaquita-damage;
           print("Daño -2");
        }
    }

   
}
