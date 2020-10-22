using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatioon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Rotate(0, 1.0f, 0.0f);
    }
}
