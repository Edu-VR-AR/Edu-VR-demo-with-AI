using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INNMOD : MonoBehaviour
{
    public void Red()
    {

        GetComponent<Renderer>().material.color = Color.red;
            }
    public void Blue()
    {

        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Blackd()
    {

        GetComponent<Renderer>().material.color = Color.black;
    }


}
