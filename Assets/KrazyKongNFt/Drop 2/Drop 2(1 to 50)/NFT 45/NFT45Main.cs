using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT45Main : MonoBehaviour
{
    public static int NFt45Amount;

    private void Awake()
    {
        NFt45Amount = PlayerPrefs.GetInt("NFt45Amount", 0);
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
