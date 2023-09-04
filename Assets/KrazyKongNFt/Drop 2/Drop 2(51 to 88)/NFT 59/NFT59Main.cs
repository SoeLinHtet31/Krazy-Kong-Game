using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT59Main : MonoBehaviour
{
    public static int NFt59Amount;

    private void Awake()
    {
        NFt59Amount = PlayerPrefs.GetInt("NFt59Amount", 0);
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
