using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT69Main : MonoBehaviour
{
    public static int NFt69Amount;

    private void Awake()
    {
        NFt69Amount = PlayerPrefs.GetInt("NFt69Amount", 0);
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
