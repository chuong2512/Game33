using System;
using UnityEngine;

public class Constant
{
    public static string DataKey_PlayerData = "player_data";
    public static int countSong = 19;
    public static int priceUnlockSong = 1000;
}

public class PlayerData : BaseData
{
    public int intHelp;

    public int maxPoint;
    
    public int currentSong;
    public bool[] listSongs;

    public Action<int> onChangeDiamond;

    public void SetPoint(int point)
    {
        if (point >= maxPoint)
        {
            maxPoint = point;
        }
        
        Save();
    }
    
    public override void Init()
    {
        prefString = Constant.DataKey_PlayerData;
        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }


    public override void ResetData()
    {
        intHelp = 0;
        currentSong = 0;
        listSongs = new bool[Constant.countSong];

        for (int i = 0; i < 8; i++)
        {
            listSongs[i] = true;
        }

        Save();
    }

    public bool CheckLock(int id)
    {
        return this.listSongs[id];
    }

    public void Unlock(int id)
    {
        if (!listSongs[id])
        {
            listSongs[id] = true;
        }

        Save();
    }

    public void AddDiamond(int a)
    {
        intHelp += a;

        onChangeDiamond?.Invoke(intHelp);
        
        Save();
    }

    public bool CheckCanUnlock()
    {
        return intHelp >= Constant.priceUnlockSong;
    }

    public void SubHelp(int a)
    {
        intHelp -= a;

        if (intHelp < 0)
        {
            intHelp = 0;
        }

        onChangeDiamond?.Invoke(intHelp);
        
        Save();
    }

    public void ChooseSong(int i)
    {
        currentSong = i;
        Save();
    }
}