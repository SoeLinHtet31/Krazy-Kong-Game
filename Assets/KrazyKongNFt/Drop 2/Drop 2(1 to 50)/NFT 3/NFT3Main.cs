using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT3Main : MonoBehaviour
{
    public static int NFt3Amount;

    private void Awake()
    {
        NFt3Amount = PlayerPrefs.GetInt("NFt3Amount", 0);
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
