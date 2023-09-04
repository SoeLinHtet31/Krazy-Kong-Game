using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT65Main : MonoBehaviour
{
    public static int NFt65Amount;

    private void Awake()
    {
        NFt65Amount = PlayerPrefs.GetInt("NFt65Amount", 0);
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
