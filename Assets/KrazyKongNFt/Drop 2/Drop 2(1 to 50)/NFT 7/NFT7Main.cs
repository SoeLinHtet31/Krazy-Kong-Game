using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT7Main : MonoBehaviour
{
    public static int NFt7Amount;

    private void Awake()
    {
        NFt7Amount = PlayerPrefs.GetInt("NFt7Amount", 0);
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
