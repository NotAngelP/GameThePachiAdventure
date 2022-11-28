using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seguirCamaraVaquita : MonoBehaviour
{
    public Image barraVida;
    private float widthBarra;
    public VidaEnemigoVaquita vidaVaquita;
    // Start is called before the first frame update
    void Start()
    {
        widthBarra = barraVida.rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
        barraVida.fillAmount = (vidaVaquita.vidaVaquita * 100 / vidaVaquita.vidaMax)/100;
        //barraVida.rectTransform.sizeDelta = new Vector2(
        //    widthBarra * ((vidaVaquita.vidaVaquita * 100 / vidaVaquita.vidaMax)/100),
        //    barraVida.rectTransform.sizeDelta.y
        //);
        // vidaMax = 4
        // vidaAct = ?
    }
}
