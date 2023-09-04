using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT51Main : MonoBehaviour
{
    public static int NFt51Amount;

    private void Awake()
    {
        NFt51Amount = PlayerPrefs.GetInt("NFt51Amount", 0);
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
