using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiente_mojarra : MonoBehaviour
{   
    public int rutina;
    public float cronometro;
    public Animator ani;
    public Quaternion angulo;
    public float grado;
    public bool atacando;
    public GameObject target;


    public void Comportamiento_Enemigo(){

        if(Vector3.Distance(transform.position, target.transform.position)>11){

    
        cronometro += 1 * Time.deltaTime;
        if(cronometro >= 4){
            rutina = Random.Range(0,2);
            cronometro = 0;
        }
        switch (rutina)
        {
            case 0:
                ani.SetBool("walk",false);
                break;
            case 1:
                grado = Random.Range(0,361);
                angulo = Quaternion.Euler(0,grado,0);
                rutina++;
                break;
            case 2:
                transform.rotation = Quaternion.RotateTowards(transform.rotation,angulo,0.5f);
                transform.Translate(Vector3.forward * 20 * Time.deltaTime);
                ani.SetBool("walk",true);
                break;
            
        }
        }else{

            if(Vector3.Distance(transform.position, target.transform.position)>1 && !atacando){
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation,2);

                ani.SetBool("walk",false);

                ani.SetBool("run",true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);

                ani.SetBool("attack",false);

            }else{
                ani.SetBool("run",false);
                ani.SetBool("walk",false);

                ani.SetBool("attack",true);
                atacando = true;
            }
        
        }
    }

    public void FinalAni(){
        ani.SetBool("attack",false);
        atacando = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Pachi");
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }

   
}
