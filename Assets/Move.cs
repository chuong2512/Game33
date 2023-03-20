using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Jackal;
using UnityEngine;

public class Move : Singleton<Move>
{
    public void DoMove()
    {
        transform.DOMoveY(transform.position.y - 1.68f, 3).SetEase(Ease.Linear).onComplete = () =>
        {
            Rotater.Instance.ShowObj();

            GameUI.Instance.SetState(State.Playing);
        };
    }
}