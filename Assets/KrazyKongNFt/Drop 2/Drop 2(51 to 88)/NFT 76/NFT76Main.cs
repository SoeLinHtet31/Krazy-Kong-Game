using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT76Main : MonoBehaviour
{
    public static int NFt76Amount;

    private void Awake()
    {
        NFt76Amount = PlayerPrefs.GetInt("NFt76Amount", 0);
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
