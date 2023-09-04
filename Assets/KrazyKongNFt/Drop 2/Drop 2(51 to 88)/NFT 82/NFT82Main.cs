using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT82Main : MonoBehaviour
{
    public static int NFt82Amount;

    private void Awake()
    {
        NFt82Amount = PlayerPrefs.GetInt("NFt82Amount", 0);
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
