using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT88Main : MonoBehaviour
{
    public static int NFt88Amount;

    private void Awake()
    {
        NFt88Amount = PlayerPrefs.GetInt("NFt88Amount", 0);
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
