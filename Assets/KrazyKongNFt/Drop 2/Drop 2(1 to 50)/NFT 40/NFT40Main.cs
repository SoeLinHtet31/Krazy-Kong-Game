using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT40Main : MonoBehaviour
{
    public static int NFt40Amount;

    private void Awake()
    {
        NFt40Amount = PlayerPrefs.GetInt("NFt40Amount", 0);
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
