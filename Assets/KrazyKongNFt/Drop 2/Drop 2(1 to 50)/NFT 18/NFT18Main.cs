using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT18Main : MonoBehaviour
{
    public static int NFt18Amount;

    private void Awake()
    {
        NFt18Amount = PlayerPrefs.GetInt("NFt18Amount", 0);
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
