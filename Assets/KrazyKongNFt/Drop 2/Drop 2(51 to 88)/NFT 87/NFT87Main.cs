using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT87Main : MonoBehaviour
{
    public static int NFt87Amount;

    private void Awake()
    {
        NFt87Amount = PlayerPrefs.GetInt("NFt87Amount", 0);
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
