using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engeller : MonoBehaviour
{
    
    public int engelcan;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D temas) 
    {
        if(temas.gameObject.tag=="top") 
        {
            engelcan--;
            
        }
        if(engelcan==0)
            {
                Destroy(this.gameObject);
            }
    }
}
