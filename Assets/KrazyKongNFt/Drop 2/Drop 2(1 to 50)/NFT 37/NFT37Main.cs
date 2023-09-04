using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFT37Main : MonoBehaviour
{
    public static int NFt37Amount;

    private void Awake()
    {
        NFt37Amount = PlayerPrefs.GetInt("NFt37Amount", 0);
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
