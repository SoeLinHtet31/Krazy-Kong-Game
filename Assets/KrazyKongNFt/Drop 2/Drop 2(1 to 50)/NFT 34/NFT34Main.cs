using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT34Main : MonoBehaviour
{
    public static int NFt34Amount;

    private void Awake()
    {
        NFt34Amount = PlayerPrefs.GetInt("NFt34Amount", 0);
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
