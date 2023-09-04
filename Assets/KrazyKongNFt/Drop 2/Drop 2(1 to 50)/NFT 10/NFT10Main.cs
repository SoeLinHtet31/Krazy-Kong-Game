using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT10Main : MonoBehaviour
{
    public static int NFt10Amount;

    private void Awake()
    {
        NFt10Amount = PlayerPrefs.GetInt("NFt10Amount", 0);
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
