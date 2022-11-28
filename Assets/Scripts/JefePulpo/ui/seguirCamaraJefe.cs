using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seguirCamaraJefe : MonoBehaviour
{
    public Image barraVida;
    private float widthBarra;
    public VidaJefe1 vidaJefe;
    // Start is called before the first frame update
    void Start()
    {
        widthBarra = barraVida.rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
        barraVida.fillAmount = (vidaJefe.vidaJefe * 100 / vidaJefe.vidaMax)/100;
        //barraVida.rectTransform.sizeDelta = new Vector2(
        //    widthBarra * ((vidaJefe.vidaJefe * 100 / vidaJefe.vidaMax)/100),
        //    barraVida.rectTransform.sizeDelta.y
        //);
        // vidaMax = 4
        // vidaAct = ?
    }
}
