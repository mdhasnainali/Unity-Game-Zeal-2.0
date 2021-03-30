using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System;


//using CongratulationsScore;

public class CoinCount : MonoBehaviour
{

    int Score = 0;

    

    public Text ScoreText;
    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {

        if (collisioninfo.collider.tag == "Coin")
        {
            Score++;

        }

    }
   
    public void Data()
        {
            // This will create a file named sample.txt
            // at the specified location 
            string fileName = "Data/Score.ini";
            string path = Path.Combine(Environment.CurrentDirectory, @"Assets\", fileName);

            Debug.Log(path);

            StreamWriter sw = new StreamWriter(path);
              
            // To write a line in buffer
            sw.WriteLine(Score); 
              
            // To write in output stream
            sw.Flush(); 
              
            // To close the stream
            sw.Close(); 
        }


    void Update()
    {
        ScoreText.text = Score.ToString();
        Data();
        //CongratulationsScore.congratulationsScore = Score;
    }

}
