using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT17Main : MonoBehaviour
{
    public static int NFt17Amount;

    private void Awake()
    {
        NFt17Amount = PlayerPrefs.GetInt("NFt17Amount", 0);
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
