using System.Collections;
using System.Collections.Generic;
using Jackal;
using UnityEngine;

public class Rotater : Singleton<Rotater>
{
    public spawnObj spawnObj, staticObj;

    private spawnObj _current;

    // Start is called before the first frame update
    void Start()
    {
        staticObj.RandomIndex();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameUI.Instance.CheckRotating())
        {
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        staticObj.Hide();

        _current = Instantiate(spawnObj, staticObj.transform.position, Quaternion.identity);

        GameUI.Instance.SetState(State.Droping);
        _current.SetImage(staticObj.index);
    }

    public void ShowObj()
    {
        staticObj.RandomIndex();
    }
}