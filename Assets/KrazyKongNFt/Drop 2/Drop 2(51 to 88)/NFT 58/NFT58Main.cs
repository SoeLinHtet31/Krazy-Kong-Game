using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT58Main : MonoBehaviour
{
    public static int NFt58Amount;

    private void Awake()
    {
        NFt58Amount = PlayerPrefs.GetInt("NFt58Amount", 0);
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
