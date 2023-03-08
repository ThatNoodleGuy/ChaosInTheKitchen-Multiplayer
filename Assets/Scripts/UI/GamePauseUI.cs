using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GamePauseUI : MonoBehaviour
{
    [SerializeField] private Button resumeBotton;
    [SerializeField] private Button mainMenuBotton;
    [SerializeField] private Button optionsBotton;

    private void Awake()
    {
        resumeBotton.onClick.AddListener(() => 
        {
            GameManager.Instance.TogglePauseGame();
        });
        mainMenuBotton.onClick.AddListener(() => 
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });
        optionsBotton.onClick.AddListener(() => 
        {
            OptionsUI.Instance.Show();
        });
    }

    private void Start()
    {
        GameManager.Instance.OnGamePaused += GameManager_OnGamePaused;
        GameManager.Instance.OnGameUnpaused += GameManager_OnGameUnpaused;

        Hide();
    }

    private void GameManager_OnGameUnpaused(object sender, EventArgs e)
    {
        Hide();
    }

    private void GameManager_OnGamePaused(object sender, EventArgs e)
    {
        Show();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}