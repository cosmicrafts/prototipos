using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject nave;
    public int cantidad;
    public int maximo;
    int maximoNum = 0;
    int numero = 0;
    GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if(numero < cantidad && maximoNum < maximo)
        {
            Instantiate(nave, new Vector3(0, 0, 0), nave.transform.rotation);
            numero++;
            maximoNum++;
            Debug.Log(" numero:"+numero);
            if(numero == cantidad)
            {
                Debug.Log("Tienes:" + cantidad + "Maximo permitido simultaneo");
            }
        }else
        {
            objetos = GameObject.FindGameObjectsWithTag("Player");
            if(objetos.Length < cantidad)
            {
                //numero--;
                //numero = cantidad - objetos.Length;
                numero = objetos.Length;
            }
        }

        if(maximoNum == maximo)
        {
            Debug.Log("Numero MAXIMO de "+ maximo + " unidades");
        }
        
        //Debug.Log("objetos:" + objetos.Length + "numero:" + numero);
    }
}
