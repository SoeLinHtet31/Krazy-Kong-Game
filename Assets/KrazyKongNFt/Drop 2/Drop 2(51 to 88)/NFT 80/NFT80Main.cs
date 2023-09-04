using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT80Main : MonoBehaviour
{
    public static int NFt80Amount;

    private void Awake()
    {
        NFt80Amount = PlayerPrefs.GetInt("NFt80Amount", 0);
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
