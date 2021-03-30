using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class CongratulationsScore : MonoBehaviour
{
    public Text congoScore;

    public void Data()
    {
        // This will create a file named sample.txt
        // at the specified location 
        string fileName = "Data/Score.ini";
        string path = Path.Combine(Environment.CurrentDirectory, @"Assets\", fileName);

        Debug.Log(path);

        StreamReader sr = new StreamReader(path);
            
        // To write a line in buffer

        congoScore.text = sr.ReadLine();

        sr.Close(); 
    }

    void Start()
    {
        Data();
    }


    void Update()
    {
        
    }
}
