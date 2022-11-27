using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDeadVaquita : MonoBehaviour
{
    public Animator jugadorAnim;
    public bool contador;
    public Enemigo enemigo;
    public bool EliminarEnemigo;
    public GameObject Mojarra;
    // Start is called before the first frame update
    void Start()
    {
        contador=true;
        EliminarEnemigo=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador==false){
            jugadorAnim.SetTrigger("DeadEnemigo");
            contador=true;
            enemigo.canMove=false;
        }    

        if(EliminarEnemigo==true){
            Destroy(gameObject,4.25f);
            print("enemigo eliminado");
        }    
    }

    void DesaparecerEnemigos(){
        EliminarEnemigo=true;
    }
}
