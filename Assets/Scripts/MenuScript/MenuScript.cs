﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void GoToPlay(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
