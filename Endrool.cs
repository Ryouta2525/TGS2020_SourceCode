using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endrool : MonoBehaviour
{
    public GameObject thinks,skip;
    private bool i,e;
    private Text text;
    float k = 0.01f,a;
    int o;
    // Start is called before the first frame update
    void Start()
    {
        text = thinks.GetComponent<Text>();
        skip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        a += Time.deltaTime;
        if (a >= 10&&skip!=null)
        {
            skip.SetActive(true);
        }
        if (i)
        {
            if (k <= 1)
            {
                text.color = new Color(1, 1, 1, k);
                k += 0.01f;
            }
            else
            {
                Destroy(skip);
                if (o == 0)
                {
                    StartCoroutine("end");
                    o = 1;
                }

            }
        }
        if (e&&Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Titl");
        }
    }

    public void Owari()
    {
        i = true;
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(3f);
        e = true;
    }
}
