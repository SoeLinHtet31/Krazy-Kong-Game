using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT46Main : MonoBehaviour
{
    public static int NFt46Amount;

    private void Awake()
    {
        NFt46Amount = PlayerPrefs.GetInt("NFt46Amount", 0);
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
