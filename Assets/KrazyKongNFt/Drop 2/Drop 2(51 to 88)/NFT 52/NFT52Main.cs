using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT52Main : MonoBehaviour
{
    public static int NFt52Amount;

    private void Awake()
    {
        NFt52Amount = PlayerPrefs.GetInt("NFt52Amount", 0);
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
