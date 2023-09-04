using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT62Main : MonoBehaviour
{
    public static int NFt62Amount;

    private void Awake()
    {
        NFt62Amount = PlayerPrefs.GetInt("NFt62Amount", 0);
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
