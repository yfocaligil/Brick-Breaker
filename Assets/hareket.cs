using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float harekethizi;
    private  float yataykontrol;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Translate(-harekethizi*Time.deltaTime,0f,0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(harekethizi*Time.deltaTime,0f,0f);
        }
     
       
    }
}
