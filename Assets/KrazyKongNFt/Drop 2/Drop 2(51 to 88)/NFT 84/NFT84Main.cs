using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT84Main : MonoBehaviour
{
    public static int NFt84Amount;

    private void Awake()
    {
        NFt84Amount = PlayerPrefs.GetInt("NFt84Amount", 0);
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
