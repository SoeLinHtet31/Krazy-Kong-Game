using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT23Main : MonoBehaviour
{
    public static int NFt23Amount;

    private void Awake()
    {
        NFt23Amount = PlayerPrefs.GetInt("NFt23Amount", 0);
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
