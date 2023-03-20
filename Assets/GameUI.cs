using System.Collections;
using System.Collections.Generic;
using Jackal;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum State
{
    Play,
    Playing,
    Droping,
    Lose,
}

public class GameUI : Singleton<GameUI>
{
    public State currentState;

    public GameObject Lose, Point;

    public TextMeshProUGUI point, maxPoint, score;

    public int currentPoint;

    public void Start()
    {
        SetState(State.Playing);
    }

    public void SetState(State state)
    {
        currentState = state;
    }

    public void AddPoint()
    {
        currentPoint++;

        point.SetText(currentPoint.ToString());
        
       Move.Instance.DoMove();
    }

    public void ShowLose()
    {
        SetState(State.Lose);
        
        Lose.SetActive(true);

        GameDataManager.Instance.playerData.SetPoint(currentPoint);
        score.SetText(currentPoint.ToString());
        maxPoint.SetText(GameDataManager.Instance.playerData.maxPoint.ToString());
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void ExitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Help()
    {
        if (GameDataManager.Instance.playerData.intHelp >= 1)
        {
            GameDataManager.Instance.playerData.SubHelp(1);

            Lose.SetActive(false);
        }
    }

    public bool CheckRotating()
    {
        return currentState == State.Playing;
    }

    public bool CheckDroping()
    {
        return currentState == State.Droping;
    }
}