using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT53Main : MonoBehaviour
{
    public static int NFt53Amount;

    private void Awake()
    {
        NFt53Amount = PlayerPrefs.GetInt("NFt53Amount", 0);
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
