using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT33Main : MonoBehaviour
{
    public static int NFt33Amount;

    private void Awake()
    {
        NFt33Amount = PlayerPrefs.GetInt("NFt33Amount", 0);
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
