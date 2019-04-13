using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {
    [SerializeField] private Vector3 velocity; // 移動方向
    [SerializeField] private float moveSpeed;
    
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start() {

        Rigidbody rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update() {

        float xhr = Input.GetAxis("Horizontal");
        float zyr = Input.GetAxis("Vertical");
        
        //進んだ距離を格納
        Vector3 vector3_Direction = new Vector3(xhr, 0, zyr) * moveSpeed;
      
        //rigidbody反映

        rb.AddForce(vector3_Direction);

    }
}
    

