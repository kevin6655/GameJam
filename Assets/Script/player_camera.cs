using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_camera : MonoBehaviour {
    //追従するためのplayer
    [SerializeField] private Transform tunakan;
    //カメラ距離
    [SerializeField] private float camera_distance = 10.0f;
    //カメラの回転軸(y)
    [SerializeField] private Quaternion hrRotetion_y;
    //カメラの回転軸(x)
    [SerializeField] private Quaternion verRotetion_x;
    // Start is called before the first frame update
    void Start () {

        //回転方向の初期化
        //x軸方向(垂直)に30度の角度をつけて見渡す。
        verRotetion_x = Quaternion.Euler (30, 0, 0);
        //y軸方向（水平）には何もしない。
        hrRotetion_y = Quaternion.identity;
        //Rotationを更新
        transform.rotation = verRotetion_x * hrRotetion_y;

        //開始位置の初期化
        //カメラの位置をplayerの位置から距離をかけた値にする。
        transform.position = tunakan.position - transform.rotation * Vector3.forward * camera_distance;

    }

    // Update is called once per frame
    void Update () {
        //カメラの位置をplayerの位置から距離をかけた値にする。
        transform.position = tunakan.position - transform.rotation * Vector3.forward * camera_distance;
    }
}
