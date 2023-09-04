using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT31Main : MonoBehaviour
{
    public static int NFt31Amount;

    private void Awake()
    {
        NFt31Amount = PlayerPrefs.GetInt("NFt31Amount", 0);
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
