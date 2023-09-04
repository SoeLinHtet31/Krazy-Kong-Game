using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT30Main : MonoBehaviour
{
    public static int NFt30Amount;

    private void Awake()
    {
        NFt30Amount = PlayerPrefs.GetInt("NFt30Amount", 0);
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
