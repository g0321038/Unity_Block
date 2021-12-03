using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabeOut : MonoBehaviour
{
    public GameObject Master;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //GameObject Master = GameObject.Find("Master");
        //Master = GameObject.Find("Master");
        Master.GetComponent<GameMaster>().GameOver("ÉQÅ[ÉÄé∏îsÅDÇ‹ÇΩíßêÌÇµÇÊÇ§");
    }
}
