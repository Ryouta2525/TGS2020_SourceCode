using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentakusScript1 : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] [Multiline] string[] Sentakusis;
    AudioClip[] SentakuAudio;
    private string naiyou;
    private GameObject Oya;
    private int i;
    public GameObject maintext;
    private ScenarioScript scScript;
    private VoiseScript vcsc;
    private GameObject voiceObj;
    private GameObject scenarioOBJ;
    // Start is called before the first frame update
    void Start()
    {
        Oya = transform.parent.gameObject;
        scenarioOBJ = GameObject.Find("ScrnarioOBJ");
        voiceObj = GameObject.Find("VoiceOBJ");
        vcsc = voiceObj.GetComponent<VoiseScript>();
        scScript = scenarioOBJ.GetComponent<ScenarioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GAMEMASTER.sentakusi == 0)
        {
            naiyou = "サブカルチャーの勉強をする";
            Sentakusis = scScript.Sab_Caltya;
            SentakuAudio = vcsc.Sab_Caltya;
            text.text = naiyou+"";
        }
        if (GAMEMASTER.sentakusi == 1)
        {
            naiyou = "サブカルチャーの勉強をする";
            Sentakusis = scScript.Sub_Caltya2;
            SentakuAudio = vcsc.Sub_Caltya2;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 2)
        {
            naiyou = "サブカルチャーの勉強をする";
            Sentakusis = scScript.Sub_Caltya3;
            SentakuAudio = vcsc.Sub_Caltya3;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 3)
        {
            naiyou = "このままいつもの電車で帰る";
            Sentakusis = scScript.Taikusai_Sentakusi_2;
            SentakuAudio = vcsc.Taikusai_Sentakusi_2;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 4)
        {
            naiyou = "左の紙";
            Sentakusis = scScript.Taikusai_Sentakusi_4;
            SentakuAudio = vcsc.Taikusai_Sentakusi_4;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 5)
        {
            naiyou = "チャットで先生に質問してみる。";
            Sentakusis = scScript.Zenki_Sentaku02;
            SentakuAudio = vcsc.Zenki_Sentaku02;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 6)
        {
            naiyou = "吉田先生(現代文)に質問する";
            Sentakusis = scScript.ZenkiSentaku_02_2;
            SentakuAudio = vcsc.ZenkiSentaku_02_2;
            text.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 7)
        {
            naiyou = "…誰だろう？";
            text.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi01_02;
            SentakuAudio = vcsc.Natuyasumi01_02;
        }
        if (GAMEMASTER.sentakusi == 8)
        {
            naiyou = "吉田先生かな？";
            text.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi1_1_2;
            SentakuAudio = vcsc.Natuyasumi1_1_2;
        }
        if (GAMEMASTER.sentakusi == 9)
        {
            naiyou = "そんな先生いましたか？";
            text.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi1_2_2;
            SentakuAudio = vcsc.Natuyasumi1_2_2;
        }
        if (GAMEMASTER.sentakusi == 10)
        {
            naiyou = "装飾";
            text.text = naiyou + "";
            TextController.Komakaino = 1;
            Sentakusis = scScript.Bunkasai01_2;
            SentakuAudio = vcsc.Bunkasai01_2;
        }
        if (GAMEMASTER.sentakusi == 11)
        {
            naiyou = "沈黙を貫く";
            text.text = naiyou + "";
            Sentakusis = scScript.Bunkasai02_2;
            SentakuAudio = vcsc.Bunkasai02_2;
        }
        if (GAMEMASTER.sentakusi == 12)
        {
            naiyou = "一人で回る";
            text.text = naiyou + "";
            Sentakusis = scScript.Bunkasai03_2;
            SentakuAudio = vcsc.Bunkasai03_2;
        }
        if (GAMEMASTER.sentakusi == 13)
        {
            naiyou = "社会高得点";
            text.text = naiyou + "";
            Sentakusis = scScript.Huyuyasumi01_2;
            SentakuAudio = vcsc.Huyuyasumi01_2;
        }
        if (GAMEMASTER.sentakusi == 14)
        {
            naiyou = "左上";
            text.text = naiyou + "";
            Sentakusis = scScript.Sotugyou01_2;
            SentakuAudio = vcsc.Sotugyou01_2;
        }
    }

    public void Sentaku()
        {
        TextController controller = maintext.GetComponent<TextController>();
            controller.scenarios = Sentakusis;
        controller.Clips = SentakuAudio;
            controller.reset();
        }
}
