using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida_piraña_punk_1 : MonoBehaviour
{   
    public int vida_max;
    public float vida_actual;
    public Image imagen_barra_de_vida;
    // Start is called before the first frame update
    void Start()
    {
        vida_actual = vida_max;
    }

    // Update is called once per frame
    void Update()
    {
        Revisar_vida();
        if (vida_actual <= 0){
            gameObject.SetActive(false);
        }
    }

    public void Revisar_vida(){
        imagen_barra_de_vida.fillAmount = vida_actual / vida_max;
    }
}
