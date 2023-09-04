using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT9Main : MonoBehaviour
{
    public static int NFt9Amount;

    private void Awake()
    {
        NFt9Amount = PlayerPrefs.GetInt("NFt9Amount", 0);
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
