using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenarioinfinito : MonoBehaviour
{
    public float velocidadeDoCenario;

    void Update()
    {
        MovimentarCenario();
    }

    private void MovimentarCenario()
    {
        Vector2 deslocamento = new Vector2(Time.time * velocidadeDoCenario, 0);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }

}
