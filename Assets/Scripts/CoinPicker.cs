using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour {

    private int coin;
    public Text scoreText;
     public Text lifeText;
    private float life;
    public Image healthbar;

    public AudioSource coinSound;
    public AudioSource lifeSound; 

    public AudioSource faseSound; 
    
    
    private void Start()
    {
        coin = 0;
        scoreText.text = "";
        lifeText.text = "";
        life = 2;
      
    }

    private void Update()
    {
        scoreText.text = "Coins: "+coin.ToString();
        lifeText.text = "Life: "+life.ToString();
        UpdateHealthBar();
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Item") == true)
          {
              coinSound.Play();
              //GetComponent<AudioSource>().Play();  
              coin += 1;
              Destroy(collision.gameObject);
          }
          if(collision.CompareTag("Obstaculo") == true)
          {
              lifeSound.Play();
              //GetComponent<AudioSource>().Play();  
              life -= 1;
              Destroy(collision.gameObject);
          }
          if(collision.CompareTag("Fase") == true)
          {
              faseSound.Play();
              //SceneManager.LoadScene("fase2");
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
              
          }
    }
    private void UpdateHealthBar()
    {
        healthbar.fillAmount = life/2;
    }
    


}