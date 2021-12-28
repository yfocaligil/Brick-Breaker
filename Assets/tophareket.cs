using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tophareket : MonoBehaviour
{
    public Rigidbody2D top;
    public float dikeyguc,yatayguc;
    void Start()
    {
        top.velocity=new Vector2(Random.Range(-yatayguc,yatayguc),top.velocity.y);
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D temas) 
    {
        
         if(temas.gameObject.tag=="Player")
         {
            top.velocity=new Vector2(top.velocity.x,dikeyguc);  
         }
        
        if(temas.gameObject.tag=="solduvar")
        {
            top.velocity=new Vector2(yatayguc,top.velocity.y);
        }
         if(temas.gameObject.tag=="sagduvar")
        {
            top.velocity=new Vector2(-yatayguc,top.velocity.y);
        }
         if(temas.gameObject.tag=="ustduvar")
        {
            top.velocity=new Vector2(top.velocity.x,-dikeyguc);
        }
        if(temas.gameObject.tag=="bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
