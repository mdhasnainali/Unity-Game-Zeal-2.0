﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratulationsGameSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGameAgain2()
    {
        SceneManager.LoadScene(1);
    }
    public void GotoMenu2()
    {
        SceneManager.LoadScene(0);
    }

}
