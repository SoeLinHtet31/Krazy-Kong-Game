using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT1Main : MonoBehaviour
{
    public static int NFt1Amount;

    private void Awake()
    {
        NFt1Amount = PlayerPrefs.GetInt("NFt1Amount", 0);
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
