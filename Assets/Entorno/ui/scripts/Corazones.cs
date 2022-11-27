using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corazones : MonoBehaviour
{
    public Image corazon1;
    public Image corazon2;
    public Image corazon3;
    public Sprite corazonLleno;
    public Sprite corazonMitad;
    public Sprite corazonVacio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setImagenesCorazones(float vidaDePachi) {
        if(vidaDePachi == 6) {
            corazon1.sprite = corazonLleno;
            corazon2.sprite = corazonLleno;
            corazon3.sprite = corazonLleno;
        } else if(vidaDePachi == 5) {
            // Dos corazones y medio
            corazon1.sprite = corazonLleno;
            corazon2.sprite = corazonLleno;
            corazon3.sprite = corazonMitad;
        } else if(vidaDePachi == 4) {
            // Dos corazones
            corazon1.sprite = corazonLleno;
            corazon2.sprite = corazonLleno;
            corazon3.sprite = corazonVacio;
        } else if(vidaDePachi == 3) {
            // Corazon y medio
            corazon1.sprite = corazonLleno;
            corazon2.sprite = corazonMitad;
            corazon3.sprite = corazonVacio;
        } else if(vidaDePachi == 2) {
            // Un Corazon
            corazon1.sprite = corazonLleno;
            corazon2.sprite = corazonVacio;
            corazon3.sprite = corazonVacio;
        } else if(vidaDePachi == 1) {
            // Medio corazon
            corazon1.sprite = corazonMitad;
            corazon2.sprite = corazonVacio;
            corazon3.sprite = corazonVacio;
        } else {
            // Sin corazon
            corazon1.sprite = corazonVacio;
            corazon2.sprite = corazonVacio;
            corazon3.sprite = corazonVacio;
        }
    }
}
