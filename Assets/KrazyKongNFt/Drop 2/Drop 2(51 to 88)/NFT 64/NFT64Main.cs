using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT64Main : MonoBehaviour
{
    public static int NFt64Amount;

    private void Awake()
    {
        NFt64Amount = PlayerPrefs.GetInt("NFt64Amount", 0);
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
