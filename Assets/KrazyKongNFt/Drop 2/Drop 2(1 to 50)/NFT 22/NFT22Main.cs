using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT22Main : MonoBehaviour
{
    public static int NFt22Amount;

    private void Awake()
    {
        NFt22Amount = PlayerPrefs.GetInt("NFt22Amount", 0);
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
