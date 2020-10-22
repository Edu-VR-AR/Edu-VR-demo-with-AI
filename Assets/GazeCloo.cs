using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeCloo : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    //float speed = 60.0f;
    bool spin = false;
    bool tclc = false;
    private float timer = 0.0f;
    
    void Start()
    {
       // menu1.SetActive(spin);
       // menu2.SetActive(!spin);
    }

    
    void Update()
    {

        if (tclc == true)
        { //float timer1 = timer;
            timer += Time.deltaTime;
           
            if (timer >= 3.0f)
            {
                OnClickStart();
            }
        }
        else timer = 0;
    }

    public void OnClickStart()
    {
        spin = !spin;                
        menu2.SetActive(!menu2.activeSelf);
        menu1.SetActive(!menu1.activeSelf);
        
        timer = 0;
    }

    public void OnClickBack()
    {
        timer = 0;
       // spin = false;
        menu1.SetActive(true);
        menu2.SetActive(false);

    }

    public void TimeClickStart()
    {
        //timer += Time.deltaTime;
        tclc = true;
      //  Debug.Log(timer1);
        
       

    }
    public void TimerReset()
    {
        timer = 0;
        tclc = false;
         //return tclc;
    }
}