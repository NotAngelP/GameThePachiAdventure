using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seguir_camara_barra : MonoBehaviour
{
    public Image barraVida;
    private float widthBarra;
    public VidaEnemigo1 vidaEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        widthBarra = barraVida.rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
        barraVida.fillAmount = (vidaEnemigo.vidaEnemigo * 100 / vidaEnemigo.vidaMax)/100;
        //barraVida.rectTransform.sizeDelta = new Vector2(
        //    widthBarra * ((vidaEnemigo.vidaEnemigo * 100 / vidaEnemigo.vidaMax)/100),
        //    barraVida.rectTransform.sizeDelta.y
        //);
        // vidaMax = 4
        // vidaAct = ?
    }
}
