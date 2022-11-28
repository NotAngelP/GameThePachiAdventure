using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeDead1 : MonoBehaviour
{
    public Animator jugadorAnim;
    public bool contador;
    public Jefe1 Jefe;
    public bool EliminarEnemigo;

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
            Jefe.canMove=false;
        }    

        if(EliminarEnemigo==true){
            Destroy(gameObject,10f);
            print("Jefe eliminado");
        }    
    }

    void DesaparecerEnemigos(){
        EliminarEnemigo=true;
    }
}
