using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT21Main : MonoBehaviour
{
    public static int NFt21Amount;

    private void Awake()
    {
        NFt21Amount = PlayerPrefs.GetInt("NFt21Amount", 0);
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
