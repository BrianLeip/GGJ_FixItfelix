﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string mainGame;
    public Canvas m_creditCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(mainGame);
    }

    public void LoadTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void LoadWinGame()
    {
        SceneManager.LoadScene("GameWin");
    }

    public void LoadLoseGame()
    {
        SceneManager.LoadScene("GameEnd");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ToggleCredits()
    {
        m_creditCanvas.gameObject.SetActive(!m_creditCanvas.gameObject.activeSelf);
    }
}
