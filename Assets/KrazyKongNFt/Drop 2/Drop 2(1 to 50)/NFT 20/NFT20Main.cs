using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT20Main : MonoBehaviour
{
    public static int NFt20Amount;

    private void Awake()
    {
        NFt20Amount = PlayerPrefs.GetInt("NFt20Amount", 0);
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
