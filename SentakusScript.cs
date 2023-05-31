using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentakusScript : MonoBehaviour
{
    [SerializeField] Text uitext;
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
            naiyou = "授業に備えて教科の勉強をする";
            Sentakusis =scScript.zyugyounisonaeru;
            SentakuAudio = vcsc.zyugyounisonaeru;
            uitext.text = naiyou+"";
        }
        if (GAMEMASTER.sentakusi == 1)
        {
            naiyou = "授業に備えて教科の勉強をする";
            Sentakusis = scScript.Manabi;
            SentakuAudio = vcsc.Manabi;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 2)
        {
            naiyou = "授業に備えて勉強をする";
            Sentakusis = scScript.Manabi2;
            SentakuAudio = vcsc.Manabi2;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 3)
        {
            naiyou = "いつもとは別の電車を使う";
            Sentakusis = scScript.Taikusai_Sentakusi_1;
            SentakuAudio = vcsc.Taikusai_Sentakusi_1;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 4)
        {
            naiyou = "右の紙";
            Sentakusis = scScript.Taikusai_Sentakusi_3;
            SentakuAudio = vcsc.Taikusai_Sentakusi_3;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 5)
        {
            naiyou = "友達と勉強会を開く。";
            Sentakusis = scScript.Zenki_Sentaku01;
            SentakuAudio = vcsc.Soudan_Zenki01;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 6)
        {
            naiyou = "笹原先生(情報)に質問する";
            Sentakusis = scScript.Zenki_Sentaku_02_1;
            SentakuAudio = vcsc.Zenki_Sentaku_02_1;
            uitext.text = naiyou + "";
        }
        if (GAMEMASTER.sentakusi == 7)
        {
            naiyou = "…あ、もしかして";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi01_01;
            SentakuAudio = vcsc.Natuyasumi01_01;
        }
        if (GAMEMASTER.sentakusi == 8)
        {
            naiyou = "門藤先生かな？";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi1_1_1;
            SentakuAudio = vcsc.Natuyasumi1_1_1;
        }
        if (GAMEMASTER.sentakusi == 9)
        {
            naiyou = "和井田先生、誰ですか～？";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Natuyasumi1_2_1;
            SentakuAudio = vcsc.Natuyasumi1_2_1;
        }
        if (GAMEMASTER.sentakusi == 10)
        {
            naiyou = "機材";
            uitext.text = naiyou + "";
            TextController.Komakaino = 0;
            Sentakusis = scScript.Bunkasai01_1;
            SentakuAudio = vcsc.Bunkasai01_1;
        }
        if (GAMEMASTER.sentakusi == 11)
        {
            naiyou = "自分がリーダーになる";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Bunkasai02_1;
            SentakuAudio = vcsc.Bunkasai02_1;
        }
        if (GAMEMASTER.sentakusi == 12)
        {
            naiyou = "親友と回る";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Bunkasai03_1;
            SentakuAudio = vcsc.Bunkasai03_1;
        }
        if (GAMEMASTER.sentakusi == 13)
        {
            naiyou = "英語高得点";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Huyuyasumi01_1;
            SentakuAudio = vcsc.Huyuyasumi01_1;
        }
        if (GAMEMASTER.sentakusi == 14)
        {
            naiyou = "右上";
            uitext.text = naiyou + "";
            Sentakusis = scScript.Sotugyou01_1;
            SentakuAudio = vcsc.Sotugyou01_1;
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
