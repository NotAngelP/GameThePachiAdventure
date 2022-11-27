using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public float random;
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    public Animator animator;
    public GameObject arma;
    public bool canMove;

    bool estarAlerta;
    bool rangoAtacar;
    bool esperar;
    
    // Start is called before the first frame update
    void Start()
    {
        esperar=false;
        canMove=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            estarAlerta = Physics.CheckSphere(transform.position,rangoDeAlerta,capaDelJugador);
            rangoAtacar = Physics.CheckSphere(transform.position,2.5f,capaDelJugador);


            if(rangoAtacar==false){
                animator.SetBool("Atacar",false);
                if(estarAlerta){
                    Vector3 posJugador = new Vector3(jugador.position.x,transform.position.y,jugador.position.z);
                    transform.LookAt(posJugador);
                    animator.SetFloat("EstaEnMovimiento", 2);
                    transform.position = Vector3.MoveTowards(transform.position,posJugador, velocidad * Time.deltaTime);
                }
                else{
                    if(esperar==false){
                        
                    }
                }
            }
            else{
                    animator.SetFloat("EstaEnMovimiento", 0);
                    animator.SetBool("Atacar",true);
            }
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
        Gizmos.DrawWireSphere(transform.position, 2.5f);
    }   

    void caminarAleatorio(){
        random = Random.Range(-5,6);
        animator.SetFloat("EstaEnMovimiento", 3);
       // transform.position = Vector3.MoveTowards(transform.position,, velocidad * Time.deltaTime);
        StartCoroutine("Esperar2");
    }

    IEnumerator Esperar(){
        yield return new WaitForSeconds(6);
        esperar=false;
        print("hola");
    }

    IEnumerator Esperar2(){
        yield return new WaitForSeconds(1);
        animator.SetFloat("EstaEnMovimiento", 0);
        StartCoroutine("Esperar");

    }



    public void ColliderWeaponTrue(){
        arma.GetComponent<BoxCollider>().enabled = true;
    }

    public void ColliderWeaponFalse(){
        arma.GetComponent<BoxCollider>().enabled = true;
    }

     
}
