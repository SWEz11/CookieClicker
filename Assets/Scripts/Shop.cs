using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update

    public Button firstthing;
    public GameManager gameManager;
    void Start()
    {
        firstthing.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.score == 10) 
        { 
            firstthing.enabled = true;
        }
    }

}
