using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [Multiline] public string[] scenarios;//シナリオ
    [SerializeField] Text UItext;
    [SerializeField] GameObject cyaraName, Name_panel;
    [SerializeField]
    [Range(0.001f, 0.3f)] float OneMoziTime = 0.05f;
    public AudioClip[] Clips;

    public static int WoldNowLine, Cyarabangou,WorldclipLine;
    public static string WoldNowtext, Woldnowlog;
    public static string[] WoldScenarios;
    public static int SeveYosidaLove, SeveSasaharaLove, SeveMondouLove, SeveTutiyaLove,SeveSentakusiNaiyou;
    public static bool SeveSentakusi, SeveSentakusitext, SaveSantakuText, SaveYontakuText,NANANANANSI,ANTEN,END,AUTOANTEN;
    public static AudioClip[] WarldClips;
    public static AudioClip WarldClip;
    public static Sprite WarldHaikei;
    public GameObject AntenPanel,SEOBJ,HaikeiObj,VoiceOBJ;
    private Image Haikeiimage;
    private int nowLine,nowVoceLine;
    private string nowText = string.Empty;
    private AudioClip nowClip;
    private float hyouziTime = 0;
    private float StartTime = 1;
    private int lastMozi = -1, logseiri = 0;
    private bool Sentakusi, SentakuText, SantakuText, YontakuText;
    private bool Onclik, AntenBool,NanasiOn,HayaiAntenbool;
    private string Yosida, YosidaLove, Yosida_tatieON;//よし
    private string Sasahara, SasaharaLove, Sasa_tatieON,Sasa_Kiraware;//ささ
    private string Mondou, MondouLove, Mon_tatieON;//もん
    private string Tutiya, TutiyaLove, Tuti_tatieON;//つち
    private string Waida,Waida_TatieON;//和井田
    private string Natu, Huyu, Surtu, Owari;//立ち絵（夏服など）
    private string Normal, Akire, Aseri, Niko, Bikkuri, Tere, Nigawarai;
    private string Miyuki, MiyukiMAMA;//主人公,まま
    private string Siori, Oono;//親友
    private string NanuNull;//名前「？？？」のやつ
    private string KuroYosida;//黒塗りのやつ
    private string Anten, HayaiAnten;//暗転など
    private string Mob,Iintyo,SaikoMob;//モブ
    private string Anauns;//アナウンス
    private string Tenin,TENIN;//店員
    private string Mob_and_Syuzin,Misaki_and_sasa;
    private string Nanasi;//名前のない表現
    private string SenTakusi1, Sentakusi2, Sentakusi3, Sentakusi4, Sentakusi5, Sentakusi6, Sentakusi7, Sentakusi8, Sentakusi9, Sentakusi10;//選択肢のないよう
    private string Sentakusi11,Sentakusi12, Sentakusi13, Sentakusi14, Sentakusi15;
    private string Day2, Day2_2, Day2_3;
    private string Nyuugaku;
    private string Taiku_SaiDay1_1, Taiku_SaiDay2_1;//体育祭
    private string Zenki_Test_01;//前期テスト
    private string Zenki_Soudan;//前期受験相談
    private string Bunkasai01,Bunkasai02;//文化祭パート１
    private string Natuyasumi01, Natuyasumi02, Kaidasi;//夏休み
    private string Dert1;//デート
    private string Kouki_Soudan;//後期受験相談
    private string Huyuyasumi01;//冬休み
    private string Zyuken01,Zyuken02,Zyuken03;//受験
    private string SotuGyou01;//卒業
    private string LogRiset;//ログリセット

    private Sprite nowhaikei;

    private string end;
    private bool EndBool;

    private string Voice;
    private bool VoiceON;

    private bool SEon;
    private string Don, Stata, Gasyan,GASYAN, Gayagaya, Hatena, Tyaimu, wwGayaga,TuuwaHazimari, TuuwaOwari, Pistl, Batan, Intarhon;//効果音
    private string Bunkasai, Bunkasai2, Bunkasai3,Syokuin, Genkan, Densya, Densya_Yuu,Densyanai, AKIBA, AKIBA_Eki,Kaijou, Jinja, Rouka, Honya, Honya_Iriguti, Kyousitu, Park, MyHome, MyHome_Yuu, MyHome_Yoru, Soto, Taikukan, Kaidan,yuugata;//背景
    private bool sasa, yosi, tuti, mon;

    private float SaveTime;

    private bool Scene;
    private string Hantei,Hantei2;//ルート判定;
    
    private CyaractorName Name;
    private Tatie tatie;
    private GameObject  savedataobj, logobj, tatieOBJ;
    public GameObject Panel, SantakuPanel, YontakuPanel;
    private int Kao;
    private ScenarioScript scScript;
    private GameObject scenarioOBJ;
    public static int Komakaino;
    private AudioSource audioSource;
    private AudioClip nowSE;
    private SEScript ses;
    private HaikeiScript hisc;
    private VoiseScript vosc;
    private AudioSource Vocesource;
    BGMscript bG;
    private AudioClip BGM;
    private AudioSource BGMsource;
    private string bgTuukin, bgHosi, bgSyosai, bgManatu, bgSotugyou, bgMura, bgKaityu, bgKibou,bgStop;

    private string AiconOK, AiconOK2, AiconOK3, AiconOK4, AiconOK5;


    public string[] Bamen;
    public static int BamenNo;
    public bool OKtext
    {
        get { return Time.time > StartTime + hyouziTime; }
    }


    private void Awake()
    {
        TextUpdate();

        Voice = "/ボイス";
        Yosida = "/吉田";
        YosidaLove = "?吉田";
        Sasahara = "/笹原";
        SasaharaLove = "?笹原";
        Sasa_Kiraware = "_笹原";
        Mondou = "/門藤";
        MondouLove = "?門藤";
        Tutiya = "/土屋";
        TutiyaLove = "?土屋";
        Miyuki = "/主人公";
        Waida = "/和井田";
        MiyukiMAMA = "/母主人公";
        Siori = "/親友";
        Oono = "/大野";
        Tenin = "/司会";
        TENIN = "/店員";
        Iintyo = "/委員";
        SaikoMob = "/サイコ";
        Mob_and_Syuzin = "/モブと主人公";
        Misaki_and_sasa = "/美咲と笹原";
        Yosida_tatieON = "/立ち絵吉田";
        Sasa_tatieON = "/立ち絵笹原";
        Mon_tatieON = "/立ち絵門藤";
        Tuti_tatieON = "/立ち絵土屋";
        Waida_TatieON = "/立ち絵和井田";

        Surtu = "/スーツ";
        Natu = "/夏";
        Huyu = "/冬";
        Owari = "/終業式";
        Normal = "/通常";
        Akire = "/呆れ";
        Aseri = "/焦り";
        Niko = "/笑顔";
        Bikkuri = "/驚き";
        Tere = "/照れ";
        Nigawarai = "/苦笑い";

        LogRiset = "/ログリセット";

        Hantei = "/判定１";
        Hantei2 = "/判定２";

        NanuNull = "/？？？";
        KuroYosida = "/黒吉田";
        Anauns = "/アナウンス";
        Nanasi = "/名無し";
        HayaiAnten = "/早い暗転";
        Anten = "/暗転";
        Mob = "/生徒";
        SenTakusi1 = "?選択肢１";
        Sentakusi2 = "?選択肢２";
        Sentakusi3 = "?選択肢３";
        Sentakusi4 = "?選択肢４";
        Sentakusi5 = "?選択肢５";
        Sentakusi6 = "?選択肢６";
        Sentakusi7 = "?選択肢７";
        Sentakusi8 = "?選択肢８";
        Sentakusi9 = "?選択肢９";
        Sentakusi10 = "_選択肢１０";
        Sentakusi11 = "_選択肢１１";
        Sentakusi12 = "_選択肢１２";
        Sentakusi13 = "_選択肢１３";
        Sentakusi14 = "_選択肢１４";
        Sentakusi15 = "_選択肢１５";
        Nyuugaku = "/入学";
        Day2 = "/二日目";
        Day2_2 = "?二日目";
        Day2_3 = "/2日目";
        Taiku_SaiDay1_1 = "/体育祭一日目＿０１";
        Taiku_SaiDay2_1 = "/体育祭二日目＿０１";
        Zenki_Test_01 = "/前期テスト＿０１";
        Zenki_Soudan = "/前期受験相談";
        Kouki_Soudan = "/後期受験相談";
        Dert1 = "/デート";
        Natuyasumi01 = "/なつやすみ０１";
        Natuyasumi02 = "/なつやすみ０２";
        Bunkasai01 = "/文化祭０１";
        Bunkasai02 = "/文化祭０２";
        Kaidasi = "/買い出し";
        Huyuyasumi01 = "/ふゆやすみ０１";
        Zyuken01 = "/受験０１";
        Zyuken02 = "/受験０２";
        Zyuken03 = "/受験０３";
        SotuGyou01 = "/卒業０１";

        Don = "/衝突音";
        Stata = "/走り去っていく音";
        GASYAN = "/勢いよくドア";
        Gasyan = "/ドアを開ける音";
        Gayagaya = "/がやがや音";
        Hatena = "/効果音「？」";
        Tyaimu = "/チャイム音";
        wwGayaga = "/笑い声＆がやがや音";
        TuuwaHazimari = "/通話始まり";
        TuuwaOwari = "/通話終了の音";
        Pistl = "/ピストルの音";
        Batan = "/倒れる音";
        Intarhon = "/インターホン";


        Genkan = "/玄関";
        Densya = "/電車";
        Densya_Yuu = "/夕電車";
        Densyanai = "/車内";
        AKIBA = "/秋葉原";
        AKIBA_Eki = "/駅秋葉原";
        Jinja = "/神社";
        Rouka = "/廊下";
        Honya = "/本屋";
        Honya_Iriguti = "/入口本屋";
        Kyousitu = "/教室";
        Park = "/公園";
        Kaijou = "/会場";
        MyHome = "/自分の部屋";
        MyHome_Yuu = "/夕自分の部屋";
        MyHome_Yoru = "/夜自分の部屋";
        Soto = "/外";
        yuugata = "/夕方";
        Taikukan = "/体育館"; 
        Kaidan = "/階段";
        Syokuin = "/職員室";
        Bunkasai = "/背景文化祭";
        Bunkasai2 = "/２背景文化祭";
        Bunkasai3 = "/３背景文化祭";

        bgHosi = "/BGM星";
        bgSotugyou = "/BGM卒業";
        bgKaityu = "/BGM海中";
        bgKibou = "/BGM希望";
        bgManatu = "/BGM真夏";
        bgMura = "/BGM村";
        bgSyosai="/BGM書斎";
        bgTuukin = "/BGM通勤";
        bgStop = "/BGMやめ";

        end = "/END";


        AiconOK = "/アイコン１";
        AiconOK2 = "/アイコン２";
        AiconOK3 =  "/アイコン３";
        AiconOK4 = "/アイコン４";
        AiconOK5 = "/アイコン５";
        
        audioSource = SEOBJ.GetComponent<AudioSource>();
        ses = SEOBJ.GetComponent<SEScript>();
        Name = cyaraName.GetComponent<CyaractorName>();
        Panel.SetActive(false);
        SantakuPanel.SetActive(false);
        YontakuPanel.SetActive(false);
        tatieOBJ = GameObject.Find("Tatie");
        tatie = tatieOBJ.GetComponent<Tatie>();
        savedataobj = GameObject.Find("SavedataOBJ");
        scenarioOBJ = GameObject.Find("ScrnarioOBJ");
        bG = GameObject.Find("BGMOBJ").GetComponent<BGMscript>();
        BGMsource = GameObject.Find("BGMOBJ").GetComponent<AudioSource>();
        scScript = scenarioOBJ.GetComponent<ScenarioScript>();
        Haikeiimage = HaikeiObj.GetComponent<Image>();
        hisc = HaikeiObj.GetComponent<HaikeiScript>();
        Vocesource = VoiceOBJ.GetComponent<AudioSource>();
        vosc = VoiceOBJ.GetComponent<VoiseScript>();
        AntenPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //テキストを流す、流れているときにクリックすると最後まで飛ぶ
        if (OKtext)
        {
            if ((nowLine < scenarios.Length && Input.GetMouseButtonDown(0) && !Sentakusi && Onclik) || (nowLine < scenarios.Length && Input.GetKeyDown(KeyCode.Return) && !Sentakusi && Onclik))
            {
                TextUpdate();
            }
        }
        else
        {
            if ((Input.GetMouseButtonDown(0) && (!Sentakusi) && Onclik) || (Input.GetKeyDown(KeyCode.Return)) && (!Sentakusi) && Onclik)
            {
                hyouziTime = 0;
            }
        }


        if (nowText != null)
        {

            //BGM
            if (nowText.Contains(bgHosi))
            {
                nowText = nowText.Replace(bgHosi,"");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }else
            if (nowText.Contains(bgSyosai))
            {
                nowText = nowText.Replace(bgSyosai, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgTuukin))
            {
                nowText = nowText.Replace(bgTuukin, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgSotugyou))
            {
                nowText = nowText.Replace(bgSotugyou, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgMura))
            {
                nowText = nowText.Replace(bgMura, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgManatu))
            {
                nowText = nowText.Replace(bgManatu, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgKibou))
            {
                nowText = nowText.Replace(bgKibou, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }
            else
            if (nowText.Contains(bgKaityu))
            {
                nowText = nowText.Replace(bgKaityu, "");
                BGMsource.clip = bG.Hosi;
                BGMsource.Play();
            }else
            if (nowText.Contains(bgStop))
            {
                nowText = nowText.Replace(bgStop, "");
                BGMsource.clip = null;
            }


            //名前表示
            if (nowText.Contains(Yosida))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Yosida, "");
                Name.CyaractorNameHyouzi(0);
                Cyarabangou = 0;
            }
            else if (nowText.Contains(Sasahara))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Sasahara, "");
                Name.CyaractorNameHyouzi(1);
                Cyarabangou = 1;
            }
            else if (nowText.Contains(Mondou))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Mondou, "");
                Name.CyaractorNameHyouzi(2);
                Cyarabangou = 2;
            }
            else if (nowText.Contains(Tutiya))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Tutiya, "");
                Name.CyaractorNameHyouzi(3);
                Cyarabangou = 3;
            }
            else if (nowText.Contains(Miyuki))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Miyuki, "");
                Name.CyaractorNameHyouzi(4);
                Cyarabangou = 4;
            }
            else if (nowText.Contains(Siori))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Siori, "");
                Name.CyaractorNameHyouzi(5);
                Cyarabangou = 5;
            }
            else if (nowText.Contains(MiyukiMAMA))
            {
                NanasiOn = false;
                nowText = nowText.Replace(MiyukiMAMA, "");
                Name.CyaractorNameHyouzi(6);
                Cyarabangou = 6;
            }
            else if (nowText.Contains(NanuNull))
            {
                NanasiOn = false;
                nowText = nowText.Replace(NanuNull, "");
                Name.CyaractorNameHyouzi(7);
                Cyarabangou = 7;
            }
            else if (nowText.Contains(Mob))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Mob, "");
                Name.CyaractorNameHyouzi(8);
                Cyarabangou = 8;
            }
            else if (nowText.Contains(Oono))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Oono, "");
                Name.CyaractorNameHyouzi(9);
                Cyarabangou = 9;
            }
            else if (nowText.Contains(Anauns))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Anauns, "");
                Name.CyaractorNameHyouzi(10);
                Cyarabangou = 10;
            }
            else if (nowText.Contains(Nanasi))
            {
                nowText = nowText.Replace(Nanasi, "");
                Name.CyaractorNameHyouzi(11);
                Cyarabangou = 11;
                NanasiOn = true;
            }
            else if (nowText.Contains(Tenin))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Tenin, "");
                Name.CyaractorNameHyouzi(12);
                Cyarabangou = 12;
            }
            else if (nowText.Contains(Waida))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Waida, "");
                Name.CyaractorNameHyouzi(13);
                Cyarabangou = 13;
            }
            else if (nowText.Contains(Mob_and_Syuzin))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Mob_and_Syuzin, "");
                Name.CyaractorNameHyouzi(14);
                Cyarabangou = 14;
            }
            else if (nowText.Contains(Iintyo))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Iintyo, "");
                Name.CyaractorNameHyouzi(15);
                Cyarabangou = 15;
            }
            else if (nowText.Contains(SaikoMob))
            {
                NanasiOn = false;
                nowText = nowText.Replace(SaikoMob, "");
                Name.CyaractorNameHyouzi(16);
                Cyarabangou = 16;
            }else if (nowText.Contains(TENIN))
            {
                NanasiOn = false;
                nowText = nowText.Replace(TENIN, "");
                Name.CyaractorNameHyouzi(17);
                Cyarabangou = 17;
            }else if (nowText.Contains(Misaki_and_sasa))
            {
                NanasiOn = false;
                nowText = nowText.Replace(Misaki_and_sasa, "");
                Name.CyaractorNameHyouzi(18);
                Cyarabangou = 18;
            }


            if (NanasiOn)
            {
                Name_panel.SetActive(false);
            }
            else
            {
                Name_panel.SetActive(true);
            }
            //選択肢の内容
            if (nowText.Contains(SenTakusi1))
            {
                nowText = nowText.Replace(SenTakusi1, "");
                GAMEMASTER.sentakusi = 0;
            }
            else if (nowText.Contains(Sentakusi2))
            {
                nowText = nowText.Replace(Sentakusi2, "");
                GAMEMASTER.sentakusi = 1;
            }
            else if (nowText.Contains(Sentakusi3))
            {
                nowText = nowText.Replace(Sentakusi3, "");
                GAMEMASTER.sentakusi = 2;
            }
            else if (nowText.Contains(Sentakusi4))
            {
                nowText = nowText.Replace(Sentakusi4, "");
                GAMEMASTER.sentakusi = 3;
            }
            else if (nowText.Contains(Sentakusi5))
            {
                nowText = nowText.Replace(Sentakusi5, "");
                GAMEMASTER.sentakusi = 4;
            }
            else if (nowText.Contains(Sentakusi6))
            {
                nowText = nowText.Replace(Sentakusi6, "");
                GAMEMASTER.sentakusi = 5;
            }
            else if (nowText.Contains(Sentakusi7))
            {
                nowText = nowText.Replace(Sentakusi7, "");
                GAMEMASTER.sentakusi = 6;
            }
            else if (nowText.Contains(Sentakusi8))
            {
                nowText = nowText.Replace(Sentakusi8, "");
                GAMEMASTER.sentakusi = 7;
            }
            else if (nowText.Contains(Sentakusi9))
            {
                nowText = nowText.Replace(Sentakusi9, "");
                GAMEMASTER.sentakusi = 8;
            }
            else if (nowText.Contains(Sentakusi10))
            {
                nowText = nowText.Replace(Sentakusi10, "");
                GAMEMASTER.sentakusi = 9;
            }
            else if (nowText.Contains(Sentakusi11))
            {
                nowText = nowText.Replace(Sentakusi11, "");
                GAMEMASTER.sentakusi = 10;
            }
            else if (nowText.Contains(Sentakusi12))
            {
                nowText = nowText.Replace(Sentakusi12, "");
                GAMEMASTER.sentakusi = 11;
            }
            else if (nowText.Contains(Sentakusi13))
            {
                nowText = nowText.Replace(Sentakusi13, "");
                GAMEMASTER.sentakusi = 12;
            }
            else if (nowText.Contains(Sentakusi14))
            {
                nowText = nowText.Replace(Sentakusi14, "");
                GAMEMASTER.sentakusi = 13;
            }
            else if (nowText.Contains(Sentakusi15))
            {
                nowText = nowText.Replace(Sentakusi15, "");
                GAMEMASTER.sentakusi = 14;
            }
            //好感度
            if (nowText.Contains(YosidaLove))
            {
                nowText = nowText.Replace(YosidaLove, "");
                GAMEMASTER.YosidaLove++;
                Debug.Log("吉田の好感度が上がりました");
            }
            if (nowText.Contains(SasaharaLove))
            {
                nowText = nowText.Replace(SasaharaLove, "");
                GAMEMASTER.SasaharaLove++;
                Debug.Log("笹原の好感度が上がりました");
            }
            if (nowText.Contains(MondouLove))
            {
                nowText = nowText.Replace(MondouLove, "");
                GAMEMASTER.MondouLove++;
                Debug.Log("門藤の好感度が上がりました");
            }
            if (nowText.Contains(TutiyaLove))
            {
                nowText = nowText.Replace(TutiyaLove, "");
                GAMEMASTER.TutiyaLove++;
                Debug.Log("土屋の好感度が上がりました");
            }

            if (nowText.Contains(Sasa_Kiraware))
            {
                nowText = nowText.Replace(Sasa_Kiraware, "");
                GAMEMASTER.SasaharaLove--;
                Debug.Log("ささの好感度が下がりました");
            }

            if (nowText.Contains("渡辺"))
            {
                nowText = nowText.Replace("渡辺", "榎本");
            }

            //立ち絵

            if (nowText.Contains(Yosida_tatieON))
            {
                tatie.yosida();
                nowText = nowText.Replace(Yosida_tatieON, "");
                tatie.lord = false;
            }
            if (nowText.Contains(Sasa_tatieON))
            {
                tatie.Sasa();
                nowText = nowText.Replace(Sasa_tatieON, "");
                tatie.lord = false;
            }
            if (nowText.Contains(Mon_tatieON))
            {
                tatie.Mon();
                nowText = nowText.Replace(Mon_tatieON, "");
                tatie.lord = false;
            }
            if (nowText.Contains(Tuti_tatieON))
            {
                tatie.Tuti();
                nowText = nowText.Replace(Tuti_tatieON, "");
                tatie.lord = false;
            }
            if (nowText.Contains(Waida_TatieON))
            {
                tatie.waida();
                nowText = nowText.Replace(Waida_TatieON, "");
                tatie.lord = false;
            }
            if (nowText.Contains(KuroYosida))
            {
                tatie.Kuroyosida();
                nowText = nowText.Replace(KuroYosida, "");
                tatie.lord = false;
            }
            //表情
            if (nowText.Contains(Normal))
            {
                tatie.NormalKao();
                nowText = nowText.Replace(Normal, "");
            }
            if (nowText.Contains(Akire))
            {
                tatie.Akire();
                nowText = nowText.Replace(Akire, "");
            }
            if (nowText.Contains(Aseri))
            {
                tatie.Aseri();
                nowText = nowText.Replace(Aseri, "");
            }
            if (nowText.Contains(Niko))
            {
                tatie.Egao();
                nowText = nowText.Replace(Niko, "");
            }
            if (nowText.Contains(Bikkuri))
            {
                tatie.Odoroki();
                nowText = nowText.Replace(Bikkuri, "");
            }
            if (nowText.Contains(Tere))
            {
                tatie.Tere();
                nowText = nowText.Replace(Tere, "");
            }
            if (nowText.Contains(Nigawarai))
            {
                tatie.Nigawarai();
                nowText = nowText.Replace(Nigawarai, "");
            }
            //服装
            if (nowText.Contains(Surtu))
            {
                tatie.NormalHuku();
                nowText = nowText.Replace(Surtu, "");
            }
            if (nowText.Contains(Natu))
            {
                tatie.NatuHuku();
                nowText = nowText.Replace(Natu, "");
            }
            if (nowText.Contains(Huyu))
            {
                tatie.HuyuHuku();
                nowText = nowText.Replace(Huyu, "");
            }
            if (nowText.Contains(Owari))
            {
                tatie.HakamaHuku();
                nowText = nowText.Replace(Owari, "");
            }

            if (nowText.Contains("/立ち絵やめ"))
            {
                nowText = nowText.Replace("/立ち絵やめ", "");
                tatie.yame();
            }

            //選択肢
            if (nowText.Contains("/選択肢"))
            {
                nowText = nowText.Replace("/選択肢", "");
                SentakuText = true;
            }
            if (nowText.Contains("/三択"))
            {
                nowText = nowText.Replace("/三択", "");
                SantakuText = true;
            }
            if (nowText.Contains("/四択"))
            {
                nowText = nowText.Replace("/四択", "");
                YontakuText = true;
            }

            //暗転
            if (nowText.Contains(Anten))
            {
                nowText = nowText.Replace(Anten, "");
                AntenBool = true;
            }
            if (nowText.Contains(HayaiAnten))
            {
                nowText = nowText.Replace(HayaiAnten, "");
                HayaiAntenbool = true;
            }
            //背景


            Haikeiimage.sprite = nowhaikei;
            if (nowText.Contains(Syokuin))
            {
                nowhaikei = hisc.Syokuin;
                nowText = nowText.Replace(Syokuin, "");
            }
            if (nowText.Contains(Bunkasai))
            {
                nowhaikei = hisc.BUnkasia;
                nowText = nowText.Replace(Bunkasai, "");
            }
            if (nowText.Contains(Bunkasai2))
            {
                nowhaikei = hisc.BUnkasia2;
                nowText = nowText.Replace(Bunkasai2, "");
            }
            if (nowText.Contains(Bunkasai3))
            {
                nowhaikei = hisc.BUnkasia3;
                nowText = nowText.Replace(Bunkasai3, "");
            }
            if (nowText.Contains(Genkan))
            {
                nowhaikei = hisc.Genkan;
                nowText = nowText.Replace(Genkan, "");
            }
            if (nowText.Contains(Densya))
            {
                nowhaikei = hisc.Densya;
                nowText = nowText.Replace(Densya, "");
            }
            if (nowText.Contains(Densya_Yuu))
            {
                nowhaikei = hisc.Densya_Yuu;
                nowText = nowText.Replace(Densya_Yuu, "");
            }
            if (nowText.Contains(Densyanai))
            {
                nowhaikei = hisc.Densyanai;
                nowText = nowText.Replace(Densyanai, "");
            }
            if (nowText.Contains(AKIBA))
            {
                nowhaikei = hisc.AKIBA;
                nowText = nowText.Replace(AKIBA, "");
            }
            if (nowText.Contains(AKIBA_Eki))
            {
                nowhaikei = hisc.AKIBA_Eki;
                nowText = nowText.Replace(AKIBA_Eki, "");
            }
            if (nowText.Contains(Jinja))
            {
                nowhaikei = hisc.Jinja;
                nowText = nowText.Replace(Jinja, "");
            }
            if (nowText.Contains(Kaijou))
            {
                nowhaikei = hisc.Kajo;
                nowText = nowText.Replace(Kaijou, "");
            }
            if (nowText.Contains(Rouka))
            {
                nowhaikei = hisc.Rouka;
                nowText = nowText.Replace(Rouka, "");
            }
            if (nowText.Contains(Honya))
            {
                nowhaikei = hisc.Honya;
                nowText = nowText.Replace(Honya, "");
            }
            if (nowText.Contains(Honya_Iriguti))
            {
                nowhaikei = hisc.Honya_Iriguti;
                nowText = nowText.Replace(Honya_Iriguti, "");
            }
            if (nowText.Contains(Kyousitu))
            {
                nowhaikei = hisc.Kyousitu;
                nowText = nowText.Replace(Kyousitu, "");
            }
            if (nowText.Contains(Park))
            {
                nowhaikei = hisc.Park;
                nowText = nowText.Replace(Park, "");
            }
            if (nowText.Contains(MyHome))
            {
                nowhaikei = hisc.MyHome;
                nowText = nowText.Replace(MyHome, "");
            }
            if (nowText.Contains(MyHome_Yuu))
            {
                nowhaikei = hisc.MyHome_Yuu;
                nowText = nowText.Replace(MyHome_Yuu, "");
            }
            if (nowText.Contains(MyHome_Yoru))
            {
                nowhaikei = hisc.MyHome_Yoru;
                nowText = nowText.Replace(MyHome_Yoru, "");
            }
            if (nowText.Contains(Soto))
            {
                nowhaikei = hisc.Soto;
                nowText = nowText.Replace(Soto, "");
            }
            if (nowText.Contains(Taikukan))
            {
                nowhaikei = hisc.Taikukan;
                nowText = nowText.Replace(Taikukan, "");
            }
            if (nowText.Contains(Kaidan))
            {
                nowhaikei = hisc.Kaidan;
                nowText = nowText.Replace(Kaidan, "");
            }
            if (nowText.Contains(yuugata))
            {
                nowhaikei = hisc.yuugata;
                nowText = nowText.Replace(yuugata, "");
            }

            //SE
            if (nowText.Contains(Don))//衝突
            {
                nowText = nowText.Replace(Don, "");
                nowSE = ses.Don;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Stata))//走る
            {
                nowText = nowText.Replace(Stata, "");
                nowSE = ses.Sutata;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Gayagaya))
            {
                nowText = nowText.Replace(Gayagaya, "");
                nowSE = ses.Gayagaya;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(GASYAN))
            {
                nowText = nowText.Replace(GASYAN, "");
                nowSE = ses.GASYAN;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(TuuwaHazimari))
            {
                nowText = nowText.Replace(TuuwaHazimari, "");
                nowSE = ses.TuuwaHazimari;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(TuuwaOwari))
            {
                nowText = nowText.Replace(TuuwaOwari, "");
                nowSE = ses.TuuwaOwari;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(wwGayaga))
            {
                nowText = nowText.Replace(wwGayaga, "");
                nowSE = ses.wwgayagaya;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Hatena))
            {
                nowText = nowText.Replace(Hatena, "");
                nowSE = ses.Hatena;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Tyaimu))
            {
                nowText = nowText.Replace(Tyaimu, "");
                nowSE = ses.Tyaimu;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Pistl))
            {
                nowText = nowText.Replace(Pistl, "");
                nowSE = ses.Pistol;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Batan))
            {
                nowText = nowText.Replace(Batan, "");
                nowSE = ses.Batan;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Intarhon))
            {
                nowText = nowText.Replace(Intarhon, "");
                nowSE = ses.IntarHon;
                SEon = true;
                OnSE();
            }
            if (nowText.Contains(Gasyan))
            {
                nowText = nowText.Replace(Gasyan, "");
                nowSE = ses.Gayan;
                SEon = true;
                OnSE();
            }
            //入学
            if (nowText.Contains(Nyuugaku))
            {
                nowText = nowText.Replace(Nyuugaku, "");
                BamenNo = 0;
            }

            //二日目
            if (nowText.Contains(Day2))
            {
                nowText = nowText.Replace(Day2, "");
                scenarios = scScript.Day2Scenario;
                Clips = vosc.Day2Scenario;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Day2_2))
            {
                nowText = nowText.Replace(Day2_2, "");
                scenarios = scScript.Day2Scenario2;
                Clips = vosc.Day2Scenario2;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Day2_3))
            {
                nowText = nowText.Replace(Day2_3, "");
                scenarios = scScript.Day2Scenario3;
                Clips = vosc.Day2Scenario3;
                Scene = true;
                reset();
            }

            //体育祭
            if (nowText.Contains(Taiku_SaiDay1_1))
            {
                BamenNo = 1;
                nowText = nowText.Replace(Taiku_SaiDay1_1, "");
                scenarios = scScript.Taikusai_01;
                Clips = vosc.Taikusai_01;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Taiku_SaiDay2_1))
            {
                nowText = nowText.Replace(Taiku_SaiDay2_1, "");
                scenarios = scScript.Taikusai_02;
                Clips = vosc.Taikusai_02;
                Scene = true;
                reset();
            }

            //前期テスト 
            if (nowText.Contains(Zenki_Test_01))
            {
                BamenNo = 2;
                nowText = nowText.Replace(Zenki_Test_01, "");
                scenarios = scScript.Zenki_Test01;
                Clips = vosc.Zenki_Test01;
                Scene = true;
                reset();
            }

            //受験相談
            if (nowText.Contains(Zenki_Soudan))
            {
                BamenNo = 3;
                nowText = nowText.Replace(Zenki_Soudan, "");
                scenarios = scScript.Soudan_Zenki01;
                Clips = vosc.Soudan_Zenki01;
                Scene = true;
                reset();
            }

            //夏休み
            if (nowText.Contains(Natuyasumi01))
            {
                BamenNo = 5;
                nowText = nowText.Replace(Natuyasumi01, "");
                scenarios = scScript.Natuyasumi01;
                Clips = vosc.Natuyasumi01;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Natuyasumi02))
            {
                nowText = nowText.Replace(Natuyasumi02, "");
                scenarios = scScript.Natuyasumi02;
                Clips = vosc.Natuyasumi02;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Dert1))
            {
                BamenNo = 6;
                nowText = nowText.Replace(Dert1, "");
                scenarios = scScript.Dert01;
                Clips = vosc.Dert01;
                Scene = true;
                reset();
            }

            //買い出し
            if (nowText.Contains(Kaidasi))
            {
                nowText = nowText.Replace(Kaidasi, "");
                if (Komakaino == 0)
                {
                    scenarios = scScript.Natuyasumi02_1;
                    Scene = true;
                    Clips = vosc.Natuyasumi02_1;
                    reset();
                }
                else if (Komakaino == 1)
                {
                    scenarios = scScript.Natuyasumi02_2;
                    Scene = true;
                    Clips = vosc.Natuyasumi02_2;
                    reset();
                }
                else if (Komakaino == 2)
                {
                    scenarios = scScript.Natuyasumi02_3;
                    Clips = vosc.Natuyasumi02_3;
                    Scene = true;
                    reset();
                }
            }


            //文化祭
            if (nowText.Contains(Bunkasai01))
            {
                BamenNo = 4;
                nowText = nowText.Replace(Bunkasai01, "");
                scenarios = scScript.Bunkasai01;
                Clips = vosc.Bunkasai01;
                Scene = true;
                reset();
            }
            if (nowText.Contains(Bunkasai02))
            {
                BamenNo = 7;
                nowText = nowText.Replace(Bunkasai02, "");
                scenarios = scScript.Bunkasai03;
                Clips = vosc.Bunkasai03;
                Scene = true;
                reset();
            }
            // 後期受験相談
            if (nowText.Contains(Kouki_Soudan))
            {
                BamenNo = 8;
                nowText = nowText.Replace(Kouki_Soudan, "");
                scenarios = scScript.Kouki_test01;
                Clips = vosc.Kouki_test01;
                Scene = true;
                reset();
            }
            //冬休み
            if (nowText.Contains(Huyuyasumi01))
            {
                BamenNo = 9;
                nowText = nowText.Replace(Huyuyasumi01, "");
                scenarios = scScript.Huyuyasumi01;
                Clips = vosc.Huyuyasumi01;
                Scene = true;
                reset();
            }
            //受験
            if (nowText.Contains(Zyuken01))
            {
                BamenNo = 10;
                nowText = nowText.Replace(Zyuken01, "");
                scenarios = scScript.Zyuken01;
                Scene = true;
                Clips = vosc.Zyuken01;
                reset();
            }
            if (nowText.Contains(Zyuken02))
            {
                nowText = nowText.Replace(Zyuken02, "");
                scenarios = scScript.Zyuken02;
                Scene = true;
                Clips = vosc.Zyuken02;
                reset();
            }
            if (nowText.Contains(Zyuken03))
            {
                nowText = nowText.Replace(Zyuken03, "");
                scenarios = scScript.Zyuken03;
                Scene = true;
                Clips = vosc.Zyuken03;
                reset();
            }

            //卒業
            if (nowText.Contains(SotuGyou01))
            {
                BamenNo = 11;
                nowText = nowText.Replace(SotuGyou01, "");
                scenarios = scScript.Sotugyou01;
                Clips = vosc.Sotugyou01;
                Scene = true;
                reset();
            }

            //ボイス
            if (nowText.Contains(Voice))
            {
                nowText = nowText.Replace(Voice, "");
                VoiceON = true;
                VoiceUpdata();
            }

            //アイコン開放
            if (nowText.Contains(AiconOK))
            {
                GAMEMASTER.AiconOK1 = true;
                nowText = nowText.Replace(AiconOK,"");
            }
            if (nowText.Contains(AiconOK2))
            {
                GAMEMASTER.AiconOK2 = true;
                nowText = nowText.Replace(AiconOK2, "");
            }
            if (nowText.Contains(AiconOK3))
            {
                GAMEMASTER.AiconOK3 = true;
                nowText = nowText.Replace(AiconOK3, "");
            }
            if (nowText.Contains(AiconOK4))
            {
                GAMEMASTER.AiconOK4 = true;
                nowText = nowText.Replace(AiconOK4, "");
            }
            if (nowText.Contains(AiconOK5))
            {
                GAMEMASTER.AiconOK5 = true;
                nowText = nowText.Replace(AiconOK5, "");
            }

            if (nowText.Contains("ミユキ"))
            {
                nowText = nowText.Replace("ミユキ", "ミサキ");
            }

            //判定
            if (nowText.Contains(Hantei))
            {
                int i = HanteiSuruyo();
                int o = hantei();
                int randm;
                nowText = nowText.Replace(Hantei, "");
                if (o == 0)//1=ささ.2=吉田.3=もｎ,４＝つち
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }
                }
                else if (o == 1)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                }
                else if (o == 2)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 4;
                    }

                }
                else if (o == 3)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }

                }
                else if (o == 4)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }

                }
                else if (o == 5)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 3;
                    }
                    else if (randm == 2)
                    {
                        i = 4;
                    }

                }
                else if (o == 6)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }
                    else if (randm == 3)
                    {
                        i = 3;
                    }

                }
                else if (o == 7)
                {
                    randm = Random.Range(1, 4);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 8)
                {
                    randm = Random.Range(1, 4);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 9)
                {
                    randm = Random.Range(1, 4);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 10)
                {
                    i = Random.Range(1, 5);
                }
                if (i==1)
                {
                    scenarios = scScript.Zyuken01_1;
                    Clips = vosc.Zyuken01_1;
                    reset();
                }
                if(i==2)
                {
                    scenarios = scScript.Zyuken01_2;
                    Clips = vosc.Zyuken01_2;
                    reset();
                }
                if (i==3)
                {
                    scenarios = scScript.Zyuken01_3;
                    Clips = vosc.Zyuken01_3;
                    reset();
                }
                if(i==4)
                {
                    scenarios = scScript.Zyuken01_4;
                    Clips = vosc.Zyuken01_4;
                    reset();
                }
            }
            if (nowText.Contains(Hantei2))
            {
                int i = HanteiSuruyo();
                int o = hantei();
                int randm;
                nowText = nowText.Replace(Hantei2, "");
                if (o == 0)//1=ささ.2=吉田.3=もｎ,４＝つち
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }
                }
                else if (o == 1)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                }
                else if (o == 2)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 4;
                    }

                }
                else if (o == 3)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }

                }
                else if (o == 4)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }

                }
                else if (o == 5)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 3;
                    }
                    else if (randm == 2)
                    {
                        i = 4;
                    }

                }
                else if (o == 6)
                {
                    randm = Random.Range(1, 4);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }else if(randm == 3)
                    {
                        i = 3;
                    }

                }
                else if (o == 7)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 2;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 8)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 1;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 9)
                {
                    randm = Random.Range(1, 3);
                    if (randm == 1)
                    {
                        i = 2;
                    }
                    else if (randm == 2)
                    {
                        i = 3;
                    }
                    else if (randm == 3)
                    {
                        i = 4;
                    }

                }
                else if (o == 10)
                {
                    i = Random.Range(1, 5);
                }
                    if (i == 1)
                    {
                        scenarios = scScript.Zyuken02_1;
                    Clips = vosc.Zyuken02_1;
                        reset();
                    }
                    if (i == 2)
                    {
                        scenarios = scScript.Zyuken02_2;
                    Clips = vosc.Zyuken02_2;
                        reset();
                    }
                    if (i == 3)
                    {
                        scenarios = scScript.Zyuken02_3;
                    Clips = vosc.Zyuken02_3;
                        reset();
                    }
                    if (i == 4)
                    {
                        scenarios = scScript.Zyuken02_4;
                    Clips = vosc.Zyuken02_4;
                        reset();
                    }
            }

            if (nowText.Contains(LogRiset))
            {
                nowText = nowText.Replace(LogRiset, "");
                Log.log = "";
            }

            if (nowText.Contains(end))
            {
                nowText = nowText.Replace(end, "");
                EndBool = true;
            }
    }
        //1もじずつだす
        int MoziCount = (int)(Mathf.Clamp01((Time.time - StartTime) / hyouziTime) * nowText.Length);

        //文字数が前回と違うならテキスト更新
        if (MoziCount != lastMozi)
        {
            if (MoziCount >= 0)
            {
                UItext.text = nowText.Substring(0, MoziCount);
                lastMozi = MoziCount;
            }
        }
        if (MoziCount == lastMozi && logseiri == 0)
        {
            if (!Scene) { 
            logseiri = 1;
            Log.log += CyaractorName.nowCyaractorname + ":" + nowText + "\n" + "\n";//ログ
            }
            else
            {
                logseiri = 1;
                Scene = false;
            }
        }

        //選択肢の表示
        if (MoziCount == nowText.Length && SentakuText)
        {
            Panel.SetActive(true);
            Sentakusi = true;
        }
        if (MoziCount == nowText.Length && SantakuText)
        {
            SantakuPanel.SetActive(true);
            Sentakusi = true;
        }
        if (MoziCount == nowText.Length && YontakuText)
        {
            YontakuPanel.SetActive(true);
            Sentakusi = true;
        }

        if (MoziCount == nowText.Length && AntenBool && Input.GetMouseButtonDown(0))
        {
            AntenPanel.SetActive(true);
            AntenPanel.GetComponent<PanelAnima>().Anten(this.gameObject.GetComponent<TextController>());
            AntenBool = false;
        }

        if (MoziCount == nowText.Length && HayaiAntenbool && Input.GetMouseButtonDown(0))
        {
            AntenPanel.SetActive(true);
            AntenPanel.GetComponent<PanelAnima>().Anten(this.gameObject.GetComponent<TextController>());
            HayaiAntenbool = false;
        }

        if (MoziCount == nowText.Length && EndBool && Input.GetMouseButtonDown(0))
        {
            AntenPanel.SetActive(true);
            AntenPanel.GetComponent<PanelAnima>().Owaridayo();
           EndBool = false;
        }


        if (MoziCount == nowText.Length && GAMEMASTER.Auto && !Sentakusi && nowLine < scenarios.Length)//オート
        {
            StartCoroutine("AOOOt");
        }
    }

    int HanteiSuruyo()
    {
        if (GAMEMASTER.SasaharaLove > GAMEMASTER.YosidaLove && GAMEMASTER.SasaharaLove > GAMEMASTER.MondouLove && GAMEMASTER.SasaharaLove > GAMEMASTER.TutiyaLove)
        {
            return 1;
        }
        if (GAMEMASTER.YosidaLove > GAMEMASTER.SasaharaLove && GAMEMASTER.YosidaLove > GAMEMASTER.MondouLove && GAMEMASTER.YosidaLove > GAMEMASTER.TutiyaLove)
        {
            return 2;
        }
        if (GAMEMASTER.MondouLove > GAMEMASTER.SasaharaLove && GAMEMASTER.MondouLove > GAMEMASTER.YosidaLove && GAMEMASTER.MondouLove > GAMEMASTER.TutiyaLove)
        {
            return 3;
        }
        if (GAMEMASTER.TutiyaLove > GAMEMASTER.SasaharaLove && GAMEMASTER.TutiyaLove > GAMEMASTER.YosidaLove && GAMEMASTER.TutiyaLove > GAMEMASTER.MondouLove)
        {
            return 4;
        }
        else
        {
            return 0;
        }
    }


    int hantei()
    {
        if (GAMEMASTER.SasaharaLove >= GAMEMASTER.YosidaLove && GAMEMASTER.SasaharaLove >= GAMEMASTER.MondouLove && GAMEMASTER.SasaharaLove >= GAMEMASTER.TutiyaLove)
        {
            sasa = true;
        }
        if (GAMEMASTER.YosidaLove >= GAMEMASTER.SasaharaLove && GAMEMASTER.YosidaLove >= GAMEMASTER.MondouLove && GAMEMASTER.YosidaLove >= GAMEMASTER.TutiyaLove)
        {
            yosi = true;
        }
        if (GAMEMASTER.MondouLove >= GAMEMASTER.SasaharaLove && GAMEMASTER.MondouLove >= GAMEMASTER.YosidaLove && GAMEMASTER.MondouLove >= GAMEMASTER.TutiyaLove)
        {
            tuti = true;
        }
        if (GAMEMASTER.TutiyaLove >= GAMEMASTER.SasaharaLove && GAMEMASTER.TutiyaLove >= GAMEMASTER.YosidaLove && GAMEMASTER.TutiyaLove >= GAMEMASTER.MondouLove)
        {
            mon = true;
        }


        if (sasa && yosi && mon && tuti)
        {
            return 10;
        }
        else
        if (yosi && mon && tuti)
        {
            return 9;
        }
        else
        if (sasa && yosi && tuti)
        {
            return 7;
        }else
        if (sasa && mon && tuti)
        {
            return 8;
        }
        else
        if (sasa && yosi && mon)
        {
            return 6;
        }
        else
        if (tuti && mon)
        {
            return 5;
        }
        else
        if (yosi && tuti)
        {
            return 4;
        }
        else
        if (yosi && mon)
        {
            return 3;
        }
        else
        if (sasa && tuti)
        {
            return 2;
        }
        else
        if (sasa && mon)
        {
            return 1;
        }else
        if (sasa&&yosi)
        {
            return 0;
        }
        else { return 11; }

    }
    public void TextUpdate()
    {
        if (nowLine < scenarios.Length&&!HayaiAntenbool&&!AntenBool)
        {
            nowText = scenarios[nowLine];
            nowLine++;

            hyouziTime = nowText.Length * OneMoziTime;
            StartTime = Time.time;

            logseiri = 0;
            lastMozi = -1;
            if (VoiceON)
            {
                Vocesource.clip = null;
            }
            if (SEon)
            {
                audioSource.clip = null;
            }
        }
    }

    public void VoiceUpdata()
    {
        nowClip = Clips[nowVoceLine];
        nowVoceLine++;

        Vocesource.clip = nowClip;
        Vocesource.Play();
    }



    void OnSE (){
        audioSource.clip = nowSE;
        audioSource.Play();
    }
    


    public void reset()
    {
        nowLine = 0;
        nowVoceLine = 0;
        Sentakusi = false;
        SentakuText = false;
        SantakuText = false;
        YontakuText = false;
        Panel.SetActive(false);
        SantakuPanel.SetActive(false);
        YontakuPanel.SetActive(false);
        TextUpdate();
    }

    public void Nokkateru()
    {
        Onclik = true;
    }

    public void Hanareta()
    {
        Onclik = false;
    }

    public void AUTO()
    {
        if (GAMEMASTER.Auto)
        {
            GAMEMASTER.Auto = false;
        }
        else
        {
            GAMEMASTER.Auto = true;
        }
    }
    IEnumerator AOOOt()
    {
        GAMEMASTER.Auto = !GAMEMASTER.Auto;
        yield return new WaitForSeconds(3f);
  
        if (!Sentakusi&&!AntenBool&&!HayaiAntenbool)
        {
            Debug.Log("おーと");
            TextUpdate();
        }
        GAMEMASTER.Auto = !GAMEMASTER.Auto;
    }

    public void Save()
    {
        PlayerPrefs.SetString("SaveData",Bamen[BamenNo]);

        WoldNowLine = nowLine;

        WoldNowtext = nowText;

        WoldScenarios = scenarios;

        Woldnowlog = Log.log;

        SeveYosidaLove = GAMEMASTER.YosidaLove;

        SeveSasaharaLove = GAMEMASTER.SasaharaLove;

        SeveMondouLove = GAMEMASTER.MondouLove;

        SeveTutiyaLove = GAMEMASTER.TutiyaLove;

        SeveSentakusiNaiyou = GAMEMASTER.sentakusi;
        NANANANANSI = NanasiOn;
        ANTEN = AntenBool;
        END = EndBool;

        WarldHaikei = nowhaikei;
        WarldClips = Clips;
        WarldClip = nowClip;
        WorldclipLine = nowVoceLine;


        SeveSentakusi = Sentakusi;

        SeveSentakusitext = SentakuText;


        SaveSantakuText = SantakuText;


        SaveYontakuText = YontakuText;

        savedataobj.GetComponent<SaveData>().SeveStart();
    }
    public void Save2()
    {
        PlayerPrefs.SetString("SaveData2",Bamen[BamenNo]);
        PlayerPrefs.Save();

        WoldNowLine = nowLine;

        WoldNowtext = nowText;

        WoldScenarios = scenarios;

        Woldnowlog = Log.log;

        SeveYosidaLove = GAMEMASTER.YosidaLove;

        SeveSasaharaLove = GAMEMASTER.SasaharaLove;

        SeveMondouLove = GAMEMASTER.MondouLove;

        SeveTutiyaLove = GAMEMASTER.TutiyaLove;

        SeveSentakusiNaiyou = GAMEMASTER.sentakusi;
        NANANANANSI = NanasiOn;
        ANTEN = AntenBool;
        END = EndBool;

        WarldHaikei = nowhaikei;
        WarldClips = Clips;
        WarldClip = nowClip;
        WorldclipLine = nowVoceLine;


        SeveSentakusi = Sentakusi;

        SeveSentakusitext = SentakuText;


        SaveSantakuText = SantakuText;


        SaveYontakuText = YontakuText;

        savedataobj.GetComponent<SaveData>().SeveStart2();
    }
    public void Save3()
    {
        PlayerPrefs.SetString("SaveData3", Bamen[BamenNo]);
        PlayerPrefs.Save();

        WoldNowLine = nowLine;

        WoldNowtext = nowText;

        WoldScenarios = scenarios;

        Woldnowlog = Log.log;

        SeveYosidaLove = GAMEMASTER.YosidaLove;

        SeveSasaharaLove = GAMEMASTER.SasaharaLove;

        SeveMondouLove = GAMEMASTER.MondouLove;

        SeveTutiyaLove = GAMEMASTER.TutiyaLove;

        SeveSentakusiNaiyou = GAMEMASTER.sentakusi;
        NANANANANSI = NanasiOn;
        ANTEN = AntenBool;
        END = EndBool;

        WarldHaikei = nowhaikei;
        WarldClips = Clips;
        WarldClip = nowClip;
        WorldclipLine = nowVoceLine;


        SeveSentakusi = Sentakusi;

        SeveSentakusitext = SentakuText;


        SaveSantakuText = SantakuText;


        SaveYontakuText = YontakuText;

        savedataobj.GetComponent<SaveData>().SeveStart3();
    }

    public void load(SaveData.Player savedata)
         {
        if (savedata.nowScenarios != null)
        {
            hyouziTime = 0;
            nowLine = savedata.nowText;
            nowText = savedata.testString;
            scenarios = savedata.nowScenarios;
            BamenNo = savedata.SavedataName;
            GAMEMASTER.YosidaLove = savedata.YosidaLove;
            GAMEMASTER.TutiyaLove = savedata.TutiyaLove;
            GAMEMASTER.SasaharaLove = savedata.SasaharaLove;
            GAMEMASTER.MondouLove = savedata.MondouLove;
            GAMEMASTER.sentakusi = savedata.SeveSentajysunaiyou;
            GAMEMASTER.Aicon1No = savedata.Aicon1;
            GAMEMASTER.Aicon2No = savedata.Aicon2;
            GAMEMASTER.Aicon3No = savedata.Aicon3;
            GAMEMASTER.AiconOK1 = savedata.Aicon1OK;
            GAMEMASTER.AiconOK2 = savedata.Aicon2OK;
            GAMEMASTER.AiconOK3 = savedata.Aicon3Ok;
            GAMEMASTER.AiconOK4 = savedata.Aicon4OK;
            GAMEMASTER.AiconOK5 = savedata.Aicon5OK;
            tatie.lord = true;
            Tatie.NowSprite = savedata.sprite;
            Sentakusi = savedata.Sentakusi;
            SentakuText = savedata.SentakusiText;
            SantakuText = savedata.SantakuText;
            YontakuText = savedata.YontakuText;
            NanasiOn = savedata.Nanasi;
            Log.log = savedata.SaveLog;
            Name.CyaractorNameHyouzi(savedata.cyara);
            AntenBool = savedata.Anten;
            EndBool = savedata.End;

            Clips = savedata.Clips;
            nowVoceLine = savedata.nowVoiceLine;

            nowhaikei = savedata.Haikei;

            tatie.Lord(savedata.sprite);

            if (!Sentakusi)
            {
                Panel.SetActive(false);
            }
            if (NanasiOn)
            {
                Name_panel.SetActive(false);
            }
        }
        else
        {
            return;
        }

    }
    }

