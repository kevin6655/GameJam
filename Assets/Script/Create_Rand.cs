using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Rand : MonoBehaviour
{
    //プレハブを格納
    public GameObject cube;
    private int x =0;
    private int z = 0;
    private Vector3 vector3;

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトの生成番所の範囲指定
         x = Random.Range(1, 5);
         z = Random.Range(1, 5);
        vector3 = this.gameObject.transform.position;

    }
    private void Update()
    {

        vector3 = new Vector3(x, 0, z);

    }


}
