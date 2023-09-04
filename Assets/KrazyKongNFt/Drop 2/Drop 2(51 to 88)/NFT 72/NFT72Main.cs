using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT72Main : MonoBehaviour
{
    public static int NFt72Amount;

    private void Awake()
    {
        NFt72Amount = PlayerPrefs.GetInt("NFt72Amount", 0);
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
