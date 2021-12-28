using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maviengel : MonoBehaviour
{
    public int engelcan;
    public SpriteRenderer ressam;
    public Material mavikirik;
    void Start()
    {
        ressam=GetComponent<SpriteRenderer>();
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
         if(engelcan==1)
            {
            ressam.material=mavikirik;
            }
        if(engelcan==0)
            {
                Destroy(this.gameObject);
            }

    }

}
