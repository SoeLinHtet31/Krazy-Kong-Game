using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT4Main : MonoBehaviour
{
    public static int NFt4Amount;

    private void Awake()
    {
        NFt4Amount = PlayerPrefs.GetInt("NFt4Amount", 0);
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
