using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.GetComponent<Timer>();

        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        timer.StartTimer();
    }

    public void EndGame()
    {
        timer.StopTimer();
        ExisteObjeto();
    }

    void ExisteObjeto()
    {
        //if(gameObject.CompareTag("Player"))
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("Encontrado");
        }
        else
        {
            Debug.Log("NO encontrado");
        }
    }
}
