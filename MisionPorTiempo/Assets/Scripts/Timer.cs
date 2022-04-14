using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public int seconds;
    private int m, s;

    //public Text timerText;
    public TextMeshProUGUI timerText;
    private GameControl gameControl;
    // Start is called before the first frame update
    void Start()
    {
        gameControl = gameObject.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTimer()
    {
        m = minutes;
        s = seconds;
        WriteTimer(m, s);
        Invoke("UpdateTimer", 1f);
        //InvokeRepeating("UpdateTimer", 1, 1);
    }

    public void StopTimer()
    {
        CancelInvoke();
    }

    private void UpdateTimer()
    {
        s--;
        if(s < 0)
        {
            if(m == 0)
            {
                // EndGAme
                gameControl.EndGame();
                return;
            }
            else
            {
                m--;
                s = 59;
            }
        }

        WriteTimer(m, s);

        Invoke("UpdateTimer", 1f);
    }

    

    private void WriteTimer(int m, int s)
    {
        if(s < 10)
        {
            timerText.text = m.ToString() + ":0" + s.ToString();
        }
        else
        {
            timerText.text = m.ToString() + ":" + s.ToString();
        }
    }
}
