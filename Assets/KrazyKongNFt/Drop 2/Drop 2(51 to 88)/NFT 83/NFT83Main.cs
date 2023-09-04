using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT83Main : MonoBehaviour
{
    public static int NFt83Amount;

    private void Awake()
    {
        NFt83Amount = PlayerPrefs.GetInt("NFt83Amount", 0);
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
