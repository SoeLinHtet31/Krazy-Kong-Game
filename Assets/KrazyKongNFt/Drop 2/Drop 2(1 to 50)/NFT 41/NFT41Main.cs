using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT41Main : MonoBehaviour
{
    public static int NFt41Amount;

    private void Awake()
    {
        NFt41Amount = PlayerPrefs.GetInt("NFt41Amount", 0);
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
