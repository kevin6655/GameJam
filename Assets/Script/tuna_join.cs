using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuna_join : MonoBehaviour
{
    public GameObject scoreGUI;
    public GameObject result_scoreGUI;
    private int point = 100;
    private int tuna_point = 50;

   
    // Start is called before the first frame update

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
        {
            Debug.Log("当たったよ");
            if (other.CompareTag("Player") || other.CompareTag("Tuna"))
            {
                Debug.Log(other);
                //this.transform.parent = other.gameObject.transform;

                this.transform.SetParent(other.gameObject.transform,true);
                scoreGUI.SendMessage("Add_point", point);
                result_scoreGUI.SendMessage("Result_Add_point", point);
            }
        }
    

    
}
