using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT50Main : MonoBehaviour
{
    public static int NFt50Amount;

    private void Awake()
    {
        NFt50Amount = PlayerPrefs.GetInt("NFt50Amount", 0);
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
