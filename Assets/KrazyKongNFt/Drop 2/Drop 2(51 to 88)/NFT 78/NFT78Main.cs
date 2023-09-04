using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT78Main : MonoBehaviour
{
    public static int NFt78Amount;

    private void Awake()
    {
        NFt78Amount = PlayerPrefs.GetInt("NFt78Amount", 0);
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
