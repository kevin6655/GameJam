using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result_Count : MonoBehaviour
{
    
    public int result_score_count = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = $"Score:{result_score_count}";
    }

    public void Result_Add_point(int point)
    {
        //引数で取得した得点を格納
        result_score_count = result_score_count + point;
        //取得した得点で更新
        GetComponent<Text>().text = $"Score : {result_score_count}";

    }

}
