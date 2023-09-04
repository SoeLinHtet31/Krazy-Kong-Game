using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT5Main : MonoBehaviour
{
    public static int NFt5Amount;

    private void Awake()
    {
        NFt5Amount = PlayerPrefs.GetInt("NFt5Amount", 0);
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
