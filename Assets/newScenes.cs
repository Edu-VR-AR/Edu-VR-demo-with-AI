using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newScenes : MonoBehaviour
{
    public int scene;
   // float speed = 60.0f;
  //  bool spin = false;
    bool tclc = false;
    private float timer = 0.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
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
        SceneManager.LoadScene(scene);
        timer = 0;
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