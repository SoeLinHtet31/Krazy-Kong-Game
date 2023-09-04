using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT24Main : MonoBehaviour
{
    public static int NFt24Amount;

    private void Awake()
    {
        NFt24Amount = PlayerPrefs.GetInt("NFt24Amount", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
