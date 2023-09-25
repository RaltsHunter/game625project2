using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text winDisplay;
    public TMP_Text scoreDisplay;
    public int hunger = 0;
    public int healthy = 0;
    public int junk = 0;

    // Update is called once per frame
    void Update()
    {

        scoreDisplay.text = "Fullness: " + hunger;
        winDisplay.text = "Cat Bread Man is hungry! Eat the food!";

        if (hunger == 100)
        {
            scoreDisplay.text = "You're Full!";
            if (healthy > junk)
            {
                winDisplay.text = "You are healthy!";
            }
            if (healthy < junk)
            {
                winDisplay.text = "You are unhealthy...";
            }
            if (healthy == junk)
            {
                winDisplay.text = "You ate a balanced meal!";
            }
        }
        if (hunger > 100)
        {
            scoreDisplay.text = "You're Full!";
            winDisplay.text = "You're overeating!";
        }
    }
}
