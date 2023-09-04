using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT12Main : MonoBehaviour
{
    public static int NFt12Amount;

    private void Awake()
    {
        NFt12Amount = PlayerPrefs.GetInt("NFt12Amount", 0);
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
