using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour
{

    float XPosToMove = 19.2f;

    GameObject[] Elements;


    // Start is called before the first frame update
    void Start()
    {
        Elements = GameObject.FindGameObjectsWithTag("ParalaxingElements");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Elements.Length; i++)
        {

            if(Elements[i].transform.position.x <= -XPosToMove){
                Elements[i].transform.position += new Vector3(XPosToMove * 3, 0, 0);
            }

            if(Elements[i].name == "1"){
                float Speed = 1f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "2"){
                float Speed = 0.7f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "3"){
                float Speed = 0.4f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "4"){
                float Speed = 0.2f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "5"){
                float Speed = 0.1f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "6"){
                float Speed = 0f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "7"){
                float Speed = 0.05f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
            if(Elements[i].name == "8"){
                float Speed = 0.02f;
                Elements[i].transform.position -= new Vector3(Speed, 0) * Time.deltaTime;
            }
        }
    }
}
