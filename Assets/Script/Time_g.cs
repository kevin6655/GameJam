using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Time_g : MonoBehaviour
{
    private float time = 30;

    public GameObject player;
    public GameObject Timeup_text;
    public GameObject backscene_text;
    public GameObject result_Count_txt;
    public GameObject Score;
    [SerializeField] private GameObject time_txt;
   


    // Start is called before the first frame update
    private void Start()

    {   //時間がfloat型で定義されているので、数値に変えてから文字列に変えてる。
        //小数点を考慮する目的
        GetComponent<Text>().text = ((int)time).ToString();
        Timeup_text.SetActive (false);
        backscene_text.SetActive(false);
        result_Count_txt.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        player.SetActive(true);
        Score.SetActive(true);
        time_txt.SetActive(true);
        


    }

    // Update is called once per frame
    private void Update()
    {
        //毎フレームに秒数を減らす・
        time -= Time.deltaTime;

        if (time < 0) { StartCoroutine("Timeup"); }

        //時間をマイナス表示しない
        if (time < 0) time = 0;
        {   //時間表示
            GetComponent<Text>().text = ((int)time).ToString();
        }


    }

   
    private void Timeup()
    {
        Timeup_text.SetActive(true);
        backscene_text.SetActive(true);
        result_Count_txt.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        player.SetActive(false);
        time_txt.SetActive(false);
        Score.SetActive(false);
    }

}














