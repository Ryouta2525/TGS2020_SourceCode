using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tatie : MonoBehaviour
{
    public Sprite[] Yosida, YosidaNatu, YosidaHuyu, YosiHaka;
    public Sprite[] Tutiya, TutiNatu, TutiHuyu, TutiHaka;
    public Sprite[] Mondou, MonNatu, MonHuyu, MonHaka;
    public Sprite[] Sasahara, SasaNatu, SasaHuyu, SasaHaka;
    public Sprite[] Waida, WaiNatu, WaiHuyu, WaiHaka;
    public Sprite Toumei,kuroyosida;
    public bool lord;
    private Sprite sprite;
    public static Sprite NowSprite;
    private Image image;
    private int Kao;
    private bool YosidaTatie, TutiyaTatie, MonTatie, SasaTatie,WaiTatie, Normal, Natu, Huyu, Hakama;
    // Start is called before the first frame update

    private void Awake()
    {
        image = this.gameObject.GetComponent<Image>();

    }

    void Start()
    {
        sprite = Toumei;
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = NowSprite;
        NowSprite = sprite;
        if (YosidaTatie && !lord)
        {
            if (Normal)
            {
                sprite = Yosida[Kao];
            }
            if (Natu)
            {
                sprite = YosidaNatu[Kao];
            }
            if (Huyu)
            {
                sprite = YosidaHuyu[Kao];
            }
            if (Hakama)
            {
                sprite = YosiHaka[Kao];
            }
        }
        if (TutiyaTatie && !lord)
        {
            if (Normal)
            {
                sprite=Tutiya[Kao];
            }
            if (Natu)
            {
                sprite = TutiNatu[Kao];
            }
            if (Huyu)
            {
                sprite = TutiHuyu[Kao];
            }
            if (Hakama)
            {
                sprite = TutiHaka[Kao];
            }
        }
        if (MonTatie && !lord)
        {
            if (Normal)
            {
               sprite= Mondou[Kao];
            }
            if (Natu)
            {
               sprite = MonNatu[Kao];
            }
            if (Huyu)
            {
                sprite = MonHuyu[Kao];
            }
            if (Hakama)
            {
                sprite=MonHaka[Kao];
            }
        }
        if (SasaTatie && !lord)
        {
            if (Normal)
            {
                sprite = Sasahara[Kao];
            }
            if (Natu)
            {
                sprite = SasaNatu[Kao];
            }
            if (Huyu)
            {
                sprite = SasaHuyu[Kao];
            }
            if (Hakama)
            {
               sprite = SasaHaka[Kao];
            }
        }
        if (WaiTatie && !lord)
        {
            if (Normal)
            {
                sprite = Waida[Kao];
            }
            if (Natu)
            {
                sprite = WaiNatu[Kao];
            }
            if (Huyu)
            {
                sprite = WaiHuyu[Kao];
            }
            if (Hakama)
            {
                sprite = WaiHaka[Kao];
            }
        }
    }

    //吉田
    public void yosida()
    {
        YosidaTatie = true;
        SasaTatie = false;
        MonTatie = false;
        TutiyaTatie = false;
        WaiTatie = false;
    }

    //笹原
    public void Sasa()
    {
        SasaTatie = true;
        MonTatie = false;
        TutiyaTatie = false;
        YosidaTatie = false;
        WaiTatie = false;
    }


    //門藤
    public void Mon()
    {
        MonTatie = true;
        TutiyaTatie = false;
        YosidaTatie = false;
        SasaTatie = false;
        WaiTatie = false;
    }


    //土屋
    public void Tuti()
    {
        TutiyaTatie = true;
        YosidaTatie = false;
        SasaTatie = false;
        MonTatie = false;
        WaiTatie = false;
    }

    //和井田
    public void waida()
    {
        TutiyaTatie = false;
        YosidaTatie = false;
        SasaTatie = false;
        MonTatie = false;
        WaiTatie = true;
    }
    public void Kuroyosida()
    {
        TutiyaTatie = false;
        YosidaTatie = false;
        SasaTatie = false;
        MonTatie = false;
        WaiTatie = false;
        sprite = kuroyosida;
    }

    //スーツ
    public void NormalHuku()
    {
        Normal = true;
        Natu = false;
        Huyu = false;
        Hakama = false;
    }
    //夏服
    public void NatuHuku()
    {
        Normal = false;
        Natu = true;
        Huyu = false;
        Hakama = false;
    }
    //冬服
    public void HuyuHuku()
    {
        Normal = false;
        Natu = false;
        Huyu = true;
        Hakama = false;
    }
    //袴
    public void HakamaHuku()
    {
        Normal = false;
        Natu = false;
        Huyu = false;
        Hakama = true;
    }

    public void NormalKao()
    {
        Kao = 0;
    }

    public void Akire()
    {
        Kao = 1;
    }

    public void Aseri()
    {
        Kao = 2;
    }

    public void Egao()
    {
        Kao = 3;
    }

    public void Odoroki()
    {
        Kao = 4;
    }

    public void Tere()
    {
        Kao = 5;
    }

    public void Nigawarai()
    {
        Kao = 6;
    }

    public void yame()
    {
        YosidaTatie = false;
        MonTatie = false;
        TutiyaTatie = false;
        YosidaTatie = false;
        WaiTatie = false;
        Normal = false;
        Natu = false;
        Huyu = false;
        Hakama = false;
        sprite = Toumei;
    }

    public void Lord(Sprite o)
    {
        sprite = o;
    }
}
