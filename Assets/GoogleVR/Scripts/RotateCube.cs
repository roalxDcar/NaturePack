using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float Spinforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Spinforce*Time.deltaTime,0);

    }

    public void ChangeSpin()
    {

        Spinforce =-Spinforce;
    }
}
