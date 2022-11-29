using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambioImagenes : MonoBehaviour
{
    public Image imagenUI;
    bool transicion;
    bool transicion2;
    // Start is called before the first frame update
    void Start()
    {
        imagenUI = GameObject.Find("Image").GetComponent<Image>();
        transicion=true;
        transicion2= false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transicion){
            transicion=false;
            StartCoroutine("EsperarAudio");
        }
        if(transicion2){
            transicion2=false;
            StartCoroutine("EsperarAudio2");
        }
    }

    IEnumerator EsperarAudio(){
        yield return new WaitForSeconds(8);
        imagenUI.sprite = Resources.Load<Sprite>("Imagenes/Menu2");
        transicion2=true;
    }

    IEnumerator EsperarAudio2(){
        yield return new WaitForSeconds(8);
        imagenUI.sprite = Resources.Load<Sprite>("Imagenes/Menu");
        transicion=true;
    }
}
