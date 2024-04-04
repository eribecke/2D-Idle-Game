using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buyBoost;
    private GameManger gm;
    private List<GameObject> list;
    [SerializeField] GameObject spawn;
    [SerializeField] GameObject Jeffry;
    void Start()
    {
        buyBoost.onClick.AddListener(() => BuyBoost());
        gm = GameObject.FindAnyObjectByType<GameManger>().GetComponent<GameManger>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(this.GetComponent<Canvas>().enabled)
            {
                this.GetComponent<Canvas>().enabled = false;
            }
            else
            {
                this.GetComponent<Canvas>().enabled =true;
            }
           
        }
    }
    // Update is called once per frame
    public void BuyBoost()
    {
        if(gm.GetIncome() >= 50)
        {
            gm.SetIncome(gm.GetIncome() - 50);
            //list = GameObject.FindGameObjectsWithTag("jeffry").ToList();
            Vector3 pos = spawn.transform.position;
            Instantiate(Jeffry, pos, Quaternion.identity);
        }
    }
}
