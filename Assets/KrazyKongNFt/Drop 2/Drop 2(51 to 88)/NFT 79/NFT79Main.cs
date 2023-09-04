using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT79Main : MonoBehaviour
{
    public static int NFt79Amount;

    private void Awake()
    {
        NFt79Amount = PlayerPrefs.GetInt("NFt79Amount", 0);
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
