using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT74Main : MonoBehaviour
{
    public static int NFt74Amount;

    private void Awake()
    {
        NFt74Amount = PlayerPrefs.GetInt("NFt74Amount", 0);
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
