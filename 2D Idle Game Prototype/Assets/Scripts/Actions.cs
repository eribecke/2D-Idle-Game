using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Actions : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManger gm;
    [SerializeField] float jumpPow;
    private Coroutine timerCo;
    private SpriteRenderer jeffry;
 
    
    void Start()
    {
        gm = GameObject.FindAnyObjectByType<GameManger>().GetComponent<GameManger>();
        jeffry = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerCo == null)
        {
            timerCo = StartCoroutine("timer");
        }
       
    }

    IEnumerator timer()
    {
        float randFloat = Random.Range(-5f, 5f);

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(randFloat, jumpPow, 0), ForceMode2D.Impulse);
        if(randFloat < 0)
        {
            jeffry.flipX = true;
        }
        yield return new WaitForSecondsRealtime(2);
        jeffry.flipX = false;
        timerCo = null;
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked");
        gm.AddMoney(5);
        
    }
}
