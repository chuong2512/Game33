using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasingManager : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    public void OnPressDown(int i)
    {
        ///
        switch (i)
        {
            ///
            case 1:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(1);
                IAPManager.Instance.BuyProductID(IAPKey.PACK1);
                break;


            case 2:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(10 + 5);
                IAPManager.Instance.BuyProductID(IAPKey.PACK2);
                break;


            case 3:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(15 + 8);
                IAPManager.Instance.BuyProductID(IAPKey.PACK3);
                break;
            case 4:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(20 + 10);
                IAPManager.Instance.BuyProductID(IAPKey.PACK4);
                break;
            ///


            ///
            case 5:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(50 + 25);
                IAPManager.Instance.BuyProductID(IAPKey.PACK5);
                break;


            case 6:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Instance.playerData.AddDiamond(100 + 50);
                IAPManager.Instance.BuyProductID(IAPKey.PACK6);
                break;
        }
    }

    public void Sub(int i)
    {
        GameDataManager.Instance.playerData.SubHelp(i);
    }
}