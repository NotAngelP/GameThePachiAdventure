using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    bool iniciar;
    // Start is called before the first frame update
    void Start()
    {
        iniciar=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(iniciar){
            iniciar=false;
            StartCoroutine("Esperar");
        }
    }

    IEnumerator Esperar(){
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("PrimerNivelAngel");
    }
}
