using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir_camara_barra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
}
