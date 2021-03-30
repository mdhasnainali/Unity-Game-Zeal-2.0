﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGameAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

}
