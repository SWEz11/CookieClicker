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
    public int chefcount;
    public TMP_Text chefcountText;
    public TMP_Text chefpriceText;
    public int chefprice;
    public float clickTimer;
    void Start()
    {
        chefprice = 10;
        chef.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.score == chefprice) 
        { 
            BuyChef();
        }
        chefcountText.text = chefcount.ToString();
        chefpriceText.text = chefprice.ToString();

    }

    public void BuyChef()
    {
        gameManager.score -= chefprice;
        chefcount++;
        chefprice *= 2;
        chefcount++;

        clickTimer += Time.deltaTime;
        if (clickTimer > 1f)
        {
            gameManager.score++;
            clickTimer = 0;
        }
    }
}
