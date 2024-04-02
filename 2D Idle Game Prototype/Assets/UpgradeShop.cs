using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour
{
    // Start is called before the first frame update
    private Button buyBoost;
    void Start()
    {
        buyBoost.onClick.AddListener(() => BuyBoost());
    }

    // Update is called once per frame
    private void BuyBoost()
    {

    }
}
