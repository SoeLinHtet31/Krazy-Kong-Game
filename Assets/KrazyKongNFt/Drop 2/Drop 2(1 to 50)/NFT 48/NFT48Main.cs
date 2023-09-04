using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT48Main : MonoBehaviour
{
    public static int NFt48Amount;

    private void Awake()
    {
        NFt48Amount = PlayerPrefs.GetInt("NFt48Amount", 0);
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
