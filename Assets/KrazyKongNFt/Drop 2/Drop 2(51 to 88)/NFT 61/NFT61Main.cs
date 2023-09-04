using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT61Main : MonoBehaviour
{
    public static int NFt61Amount;

    private void Awake()
    {
        NFt61Amount = PlayerPrefs.GetInt("NFt61Amount", 0);
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
