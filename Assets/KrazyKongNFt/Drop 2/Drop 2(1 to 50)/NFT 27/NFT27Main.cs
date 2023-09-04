using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT27Main : MonoBehaviour
{
    public static int NFt27Amount;

    private void Awake()
    {
        NFt27Amount = PlayerPrefs.GetInt("NFt27Amount", 0);
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
