using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData : MonoBehaviour
{
    [System.Serializable]
    public class Player
    {
        public int nowText, cyara,nowVoiceLine,Aicon1,Aicon2,Aicon3,SavedataName;
        public string testString, SaveLog;
        public string[] nowScenarios;
        public int YosidaLove, TutiyaLove, SasaharaLove, MondouLove, SeveSentajysunaiyou;
        public bool Sentakusi, SentakusiText, SantakuText, YontakuText, Nanasi, Anten,End,Aicon1OK,Aicon2OK,Aicon3Ok,Aicon4OK,Aicon5OK;
        public Sprite sprite,Haikei;
        public AudioClip[] Clips;
        public AudioClip nowclip;
    }
    // Start is called before the first frame update

    public GameObject Main;
    TextController controller;

    
    void Start()
    {

        controller = Main.GetComponent<TextController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TitlSave.Save == 1)
        {
            OnLord();
            TitlSave.Save = 0;
        }
        if (TitlSave.Save == 2)
        {
            OnLord2();
            TitlSave.Save = 0;
        }
    }
    public void SeveStart()
    {
        Player player = new Player();
        player.SavedataName = TextController.BamenNo;
        player.cyara = TextController.Cyarabangou;
        player.nowText = TextController.WoldNowLine;
        player.testString = TextController.WoldNowtext;
        player.nowScenarios = TextController.WoldScenarios;
        player.SaveLog = TextController.Woldnowlog;
        player.YosidaLove = GAMEMASTER.YosidaLove;
        player.SasaharaLove = GAMEMASTER.SasaharaLove;
        player.MondouLove = GAMEMASTER.MondouLove;
        player.TutiyaLove = GAMEMASTER.TutiyaLove;
        player.Sentakusi = TextController.SeveSentakusi;
        player.SentakusiText = TextController.SeveSentakusitext;
        player.SantakuText = TextController.SaveSantakuText;
        player.YontakuText = TextController.SaveYontakuText;
        player.SeveSentajysunaiyou = GAMEMASTER.sentakusi;
        player.Nanasi = TextController.NANANANANSI;
        player.Anten = TextController.ANTEN;
        player.sprite = Tatie.NowSprite;
        player.Haikei = TextController.WarldHaikei;
        player.End = TextController.END;
        player.Clips = TextController.WarldClips;
        player.nowclip = TextController.WarldClip;
        player.nowVoiceLine = TextController.WorldclipLine;
        player.Aicon1 = GAMEMASTER.Aicon1No;
        player.Aicon2 = GAMEMASTER.Aicon2No;
        player.Aicon3 = GAMEMASTER.Aicon3No;
        player.Aicon1OK = GAMEMASTER.AiconOK1;
        player.Aicon2OK = GAMEMASTER.AiconOK2;
        player.Aicon3Ok = GAMEMASTER.AiconOK3;
        player.Aicon4OK = GAMEMASTER.AiconOK4;
        player.Aicon5OK = GAMEMASTER.AiconOK5;
        savePlayerData(player);
    }
    public void SeveStart2()
    {
        Player player = new Player();
        player.SavedataName = TextController.BamenNo;
        player.cyara = TextController.Cyarabangou;
        player.nowText = TextController.WoldNowLine;
        player.testString = TextController.WoldNowtext;
        player.nowScenarios = TextController.WoldScenarios;
        player.SaveLog = TextController.Woldnowlog;
        player.YosidaLove = GAMEMASTER.YosidaLove;
        player.SasaharaLove = GAMEMASTER.SasaharaLove;
        player.MondouLove = GAMEMASTER.MondouLove;
        player.TutiyaLove = GAMEMASTER.TutiyaLove;
        player.Sentakusi = TextController.SeveSentakusi;
        player.SentakusiText = TextController.SeveSentakusitext;
        player.SantakuText = TextController.SaveSantakuText;
        player.YontakuText = TextController.SaveYontakuText;
        player.SeveSentajysunaiyou = GAMEMASTER.sentakusi;
        player.Nanasi = TextController.NANANANANSI;
        player.Anten = TextController.ANTEN;
        player.sprite = Tatie.NowSprite;
        player.Haikei = TextController.WarldHaikei;
        player.End = TextController.END;
        player.Clips = TextController.WarldClips;
        player.nowclip = TextController.WarldClip;
        player.nowVoiceLine = TextController.WorldclipLine;
        player.Aicon1 = GAMEMASTER.Aicon1No;
        player.Aicon2 = GAMEMASTER.Aicon2No;
        player.Aicon3 = GAMEMASTER.Aicon3No;
        player.Aicon1OK = GAMEMASTER.AiconOK1;
        player.Aicon2OK = GAMEMASTER.AiconOK2;
        player.Aicon3Ok = GAMEMASTER.AiconOK3;
        player.Aicon4OK = GAMEMASTER.AiconOK4;
        player.Aicon5OK = GAMEMASTER.AiconOK5;
        savePlayerData2(player);
    }
    public void SeveStart3()
    {
        Player player = new Player();
        player.SavedataName = TextController.BamenNo;
        player.cyara = TextController.Cyarabangou;
        player.nowText = TextController.WoldNowLine;
        player.testString = TextController.WoldNowtext;
        player.nowScenarios = TextController.WoldScenarios;
        player.SaveLog = TextController.Woldnowlog;
        player.YosidaLove = GAMEMASTER.YosidaLove;
        player.SasaharaLove = GAMEMASTER.SasaharaLove;
        player.MondouLove = GAMEMASTER.MondouLove;
        player.TutiyaLove = GAMEMASTER.TutiyaLove;
        player.Sentakusi = TextController.SeveSentakusi;
        player.SentakusiText = TextController.SeveSentakusitext;
        player.SantakuText = TextController.SaveSantakuText;
        player.YontakuText = TextController.SaveYontakuText;
        player.SeveSentajysunaiyou = GAMEMASTER.sentakusi;
        player.Nanasi = TextController.NANANANANSI;
        player.Anten = TextController.ANTEN;
        player.sprite = Tatie.NowSprite;
        player.Haikei = TextController.WarldHaikei;
        player.End = TextController.END;
        player.Clips = TextController.WarldClips;
        player.nowclip = TextController.WarldClip;
        player.nowVoiceLine = TextController.WorldclipLine;
        player.Aicon1 = GAMEMASTER.Aicon1No;
        player.Aicon2 = GAMEMASTER.Aicon2No;
        player.Aicon3 = GAMEMASTER.Aicon3No;
        player.Aicon1OK = GAMEMASTER.AiconOK1;
        player.Aicon2OK = GAMEMASTER.AiconOK2;
        player.Aicon3Ok = GAMEMASTER.AiconOK3;
        player.Aicon4OK = GAMEMASTER.AiconOK4;
        player.Aicon5OK = GAMEMASTER.AiconOK5;
        savePlayerData3(player);
    }

    public void savePlayerData(Player player)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(player);
        
            writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
            writer.Write(jsonstr);
            writer.Flush();
            writer.Close();

    }
    public void savePlayerData2(Player player)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(player);

        writer = new StreamWriter(Application.dataPath + "/savedata2.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();

    }
    public void savePlayerData3(Player player)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(player);

        writer = new StreamWriter(Application.dataPath + "/savedata3.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();

    }

    public void OnLord()
    {
        Player player = loadPlayerData();
        controller.load(player);
    }
    public Player loadPlayerData()
    {
        string datastr = "";
        StreamReader reader;
            reader = new StreamReader(Application.dataPath + "/savedata.json");
            datastr = reader.ReadToEnd();
            reader.Close();
        return JsonUtility.FromJson<Player>(datastr);
    }




    public void OnLord2()
    {
        Player player = loadPlayerData2();
        controller.load(player);
    }

    public Player loadPlayerData2()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/savedata2.json");
        datastr = reader.ReadToEnd();
        reader.Close();
        return JsonUtility.FromJson<Player>(datastr);
    }

    public void OnLord3()
    {
        Player player = loadPlayerData3();
        controller.load(player);
    }

    public Player loadPlayerData3()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/savedata3.json");
        datastr = reader.ReadToEnd();
        reader.Close();
        return JsonUtility.FromJson<Player>(datastr);
    }
}
