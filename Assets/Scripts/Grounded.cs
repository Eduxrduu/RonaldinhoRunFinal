using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
     PlayerController controller;

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.CompareTag("Ground"))
      {
        controller.isGrounded = true;
      }
      if(collision.gameObject.CompareTag("Star"))
      {
        Destroy(gameObject,0.5f);
      }
    }
        void OnCollisionExit2D(Collision2D collision)
    {
      if(!collision.gameObject.CompareTag("Ground"))
      {
        controller.isGrounded = false;
      }
    }
    

}
