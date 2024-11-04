using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update

    public Button firstthing;
    public GameManager gameManager;
    public Image chef;
    public TMP_Text x2;
    public int chefcount;
    public TMP_Text chefprice;
    public float clickTimer;
    void Start()
    {
        chef.color = Color.grey;
        x2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.score == 10) 
        { 
           chef.color = Color.white;
        }

        clickTimer += Time.deltaTime;
        if(clickTimer > 1f)
        {
            gameManager.score++;
            clickTimer = 0;
        }

    }

    public void BuyChef()
    {
        gameManager.score -= 10;
        chefcount++;
    }
}
