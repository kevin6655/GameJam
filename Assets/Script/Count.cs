using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    
    public int score_count = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        GetComponent<Text>().text = $"Score:{score_count}";
    }

    public void Add_point(int point)
    {

        //引数で取得した得点を格納
        score_count = score_count + point;
        Debug.Log($"今の点数は{score_count}");
        //取得した得点で更新
        GetComponent<Text>().text = $"Score : {score_count}";
    }

}
