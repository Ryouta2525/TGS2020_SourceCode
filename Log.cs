using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Log : MonoBehaviour
{
    public static string log;
    Text text;
    private ScrollRect scroll;
    public GameObject scrollOBJ;
    private bool i;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        scroll = scrollOBJ.GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = log;


        if (log.Contains("/主人公"))
        {
            log = log.Replace("/主人公", "");
        }
        if (log.Contains("/"))
        {
            log = log.Replace("/", "");
        }

        //スクロールを一番下へ
        if (i)
        {
            scroll.verticalNormalizedPosition = 0f;
        }
    }
    public void LogOn()
    {
        i = true;
        Invoke("Sitahe", 0.5f);
    }

    public void Sitahe()
    {
        i = false;
    }
}
