using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT44Main : MonoBehaviour
{
    public static int NFt44Amount;

    private void Awake()
    {
        NFt44Amount = PlayerPrefs.GetInt("NFt44Amount", 0);
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
