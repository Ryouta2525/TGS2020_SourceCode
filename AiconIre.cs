using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AiconIre : MonoBehaviour
{
    public int myAicon;
    public GameObject OBJ,Text;
    private int i;
    public Sprite[] sprite;
    private Image image;
    public static string AiconTime,AiconTime2,AiconTime3;
    // Start is called before the first frame update
    void Start()
    {

        image=OBJ.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (myAicon == 1)
        {
            i = GAMEMASTER.Aicon1No;
        }

        if (myAicon == 2)
        {
            i = GAMEMASTER.Aicon2No;
        }
        if (myAicon == 3)
        {
            i = GAMEMASTER.Aicon3No;
        }

        if (i == 0)
        {
            image.sprite = sprite[0];
        }
        if (i == 1)
        {
            image.sprite = sprite[1];

        }
        if (i == 2)
        {
            image.sprite = sprite[2];
        }
        if (i == 3)
        {
            image.sprite = sprite[3];
        }
        if (i == 4)
        {
            image.sprite = sprite[4];
        }
        if (i == 5)
        {
            image.sprite = sprite[5];
        }
        if (i == 6)
        {
            image.sprite = sprite[6];
        }
        if (i == 7)
        {
            image.sprite = sprite[7];
        }
        if (i == 8)
        {
            image.sprite = sprite[8];
        }
        if (i == 9)
        {
            image.sprite = sprite[9];
        }



        if (myAicon == 1)
        {
            AiconTime=PlayerPrefs.GetString("SaveData");
            Text.GetComponent<Text>().text = AiconTime;
        }
        if (myAicon == 2)
        {
            AiconTime2 = PlayerPrefs.GetString("SaveData2");
            Text.GetComponent<Text>().text = AiconTime2;
        }
        if (myAicon == 3)
        {
            AiconTime3 = PlayerPrefs.GetString("SaveData3");
            Text.GetComponent<Text>().text = AiconTime3;
        }
    }
}
