using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathController : MonoBehaviour
{
    public float life;
    public Transform player;
    [SerializeField]
    private float y;

    public Text gameOverText;

    public AudioSource deathSound; 

    // Update is called once per frame
    void Update()
    {
        y = player.transform.position.y;
         Death();
       
    }
    private void Death()
    {
        if(y<=-2f)
        {
            //deathSound.Play();
            GetComponent<AudioSource>().Play(); 
            gameOverText.text = "GAME OVER";
            
            
        }
        if(life<=0)
        {
            deathSound.Play();
        }
    }
}
