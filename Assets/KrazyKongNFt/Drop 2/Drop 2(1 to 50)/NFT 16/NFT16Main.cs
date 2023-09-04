using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT16Main : MonoBehaviour
{
    public static int NFt16Amount;

    private void Awake()
    {
        NFt16Amount = PlayerPrefs.GetInt("NFt16Amount", 0);
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
