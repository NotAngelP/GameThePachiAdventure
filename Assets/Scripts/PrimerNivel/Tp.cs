using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
    public int numeroEscena;
    public GameObject Texto;

    private bool lugar;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && lugar == true)
        {
            SceneManager.LoadScene(numeroEscena);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pachi")
        {
            Texto.SetActive(true);
            lugar = true;
        }
    }

     private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Pachi")
        {
            Texto.SetActive(false);
            lugar = false;
        }
    }

}
