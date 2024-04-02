using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    // Start is called before the first frame update
    private float currIncome;
    [SerializeField] TextMeshProUGUI displayText;
    public void AddMoney(float money)
    {
        currIncome += money;
        displayText.SetText("Income: " + currIncome);
    }
}
