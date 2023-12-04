using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovimientoController : MonoBehaviour
{
    public GameObject prefab;
    private GameObject objecto;
    private bool estaCreado;

    private bool avanza;
    private bool atras;
    private bool derecha;
    private bool izquierda;
    private bool aumentar;
    private bool reducir;

    // Start is called before the first frame update
    void Start()
    {
        estaCreado = false;
        avanza = false;
        atras = false;
        derecha = false;
        izquierda = false;
        aumentar = false;
        reducir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (avanza)
        {
            Avanza();
        }
        if (atras)
        {
            Atras();
        }
        if (derecha)
        {
            Derecha();
        }
        if (izquierda)
        {
            Izquierda();
        }
        if (aumentar)
        {
            Aumentar();
        }
        if (reducir)
        {
            Reducir();
        }
    }
    public void CrearObjecto()
    {
        if (!estaCreado)
        {
            objecto = Instantiate(prefab, transform.position, transform.rotation);
            //objecto.transform.localScale -= new Vector3(10f, 10f, 10f);
            objecto.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            estaCreado = true;
        }



    }
    public void Avanza()
    {
        objecto.transform.Translate(0f, 0f, -1f * Time.deltaTime);
    }
    public void Atras()
    {
        objecto.transform.Translate(0f, 0f, 1f * Time.deltaTime);
    }
    public void Derecha()
    {
        objecto.transform.Translate(-1f * Time.deltaTime, 0f, 0f);
    }
    public void Izquierda()
    {
        objecto.transform.Translate(1f * Time.deltaTime, 0f, 0f);
    }
    public void Aumentar()
    {
        objecto.transform.localScale *= 1.2f;
    }
    public void Reducir()
    {
        objecto.transform.localScale *= 0.8f;
    }

    public void ActivarAvanza()
    {
        avanza = true;
        
    }

public void DesactivarAvanza()
{

    avanza = false;
}

public void ActivarAtras()
{
    atras = true;
}

public void DesactivarAtras()
{
    atras = false;
}

public void ActivarDerecha()
{
    derecha = true;
}
public void DesactivarDerecha()
{
    derecha = false;
}
public void ActivarIzquierda()
{
    izquierda = true;
}
public void DesactivarIzquierda()
{
    izquierda = false;
}
public void ActivarAumentar()
{
    aumentar = true;
}
public void DesactivarAumentar()
{
    aumentar = false;
}
public void ActivarReducir()
{
    reducir = true;
}
public void DesactivarReducir()
{
    reducir = false;
}



}


