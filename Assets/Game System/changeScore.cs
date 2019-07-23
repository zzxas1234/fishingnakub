using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeScore : MonoBehaviour
{
    public Text myScore;
    public static int nowScore;
    public static int gameStart;
    public static int gameReset;

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("reset");
        Debug.Log(gameReset);
        Debug.Log("start");
        Debug.Log(gameStart);*/
        nowScore = 0;
        if (gameStart == 1)
        {
            if (gameReset == 1)
            {
                Debug.Log("reset ja");
                fishBurn.numRight = 0;
                gameReset = 0;
            }
            else
            {
                nowScore = fishBurn.numRight * 100;
            }
            
            string newString = nowScore.ToString();
            myScore.text = newString;
        }
        else if (gameStart == 0) { Debug.Log("gameEnd"); }

    }
}
