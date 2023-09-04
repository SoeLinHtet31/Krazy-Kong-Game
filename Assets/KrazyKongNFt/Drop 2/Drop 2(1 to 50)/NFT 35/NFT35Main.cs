using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT35Main : MonoBehaviour
{
    public static int NFt35Amount;

    private void Awake()
    {
        NFt35Amount = PlayerPrefs.GetInt("NFt35Amount", 0);
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
