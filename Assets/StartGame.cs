using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button start, exit;

    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(PlayGame);
        exit.onClick.AddListener(ExitGame);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
    }
}