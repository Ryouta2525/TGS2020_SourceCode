using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button : MonoBehaviour
{

    private Color gray, siro;
    private bool On;
    // Start is called before the first frame update
    void Start()
    {
        gray = Color.gray;
        siro = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOff()
    {
        On = !On;
        if (On)
        {
            gameObject.GetComponent<Image>().color = gray;
        }
        else
        {
            gameObject.GetComponent<Image>().color = siro;
        }
    }

    public void Off()
    {
        On = false;
        gameObject.GetComponent<Image>().color = siro;
    }

}
