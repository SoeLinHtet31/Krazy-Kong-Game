using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT32Main : MonoBehaviour
{
    public static int NFt32Amount;

    private void Awake()
    {
        NFt32Amount = PlayerPrefs.GetInt("NFt32Amount", 0);
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
