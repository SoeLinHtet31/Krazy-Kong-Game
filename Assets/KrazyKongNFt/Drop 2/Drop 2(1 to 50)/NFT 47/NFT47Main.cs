using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT47Main : MonoBehaviour
{
    public static int NFt47Amount;

    private void Awake()
    {
        NFt47Amount = PlayerPrefs.GetInt("NFt47Amount", 0);
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
