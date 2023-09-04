using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT71Main : MonoBehaviour
{
    public static int NFt71Amount;

    private void Awake()
    {
        NFt71Amount = PlayerPrefs.GetInt("NFt71Amount", 0);
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
