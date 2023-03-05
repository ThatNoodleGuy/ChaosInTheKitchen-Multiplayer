using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() => 
        {
            // onClick
            Loader.Load(Loader.Scene.GameScene);
        });

        quitButton.onClick.AddListener(() => 
        {
            // onClick
            Application.Quit();
        });
    }
}