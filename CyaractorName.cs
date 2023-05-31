using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CyaractorName : MonoBehaviour
{
    [SerializeField] string[] Cyara;
    [SerializeField] Text Uitext;
    public static string nowCyaractorname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CyaractorNameHyouzi(int a)
    {
        Uitext.text=Cyara[a];
        nowCyaractorname = Cyara[a];
    }
}
