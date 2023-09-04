using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT36Main : MonoBehaviour
{
    public static int NFt36Amount;

    private void Awake()
    {
        NFt36Amount = PlayerPrefs.GetInt("NFt36Amount", 0);
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
